using UnityEngine;
using System.Collections;
public class GameManager : MonoBehaviour 
{
    #region Variables

    // This script is used to manage the game
    [SerializeField]
    private Dna dna;
    [SerializeField]
    private ScoreUpdate sUpdate;
    public LevelLoader levelLoader;
    public static GameManager gm;
    private GameObject player;
    #endregion
    void Awake()
    {

        #region Intialization of variables
        gm = this;
        
        // Get the player object so we can deactivate after the infection is complete
        player = GameObject.FindGameObjectWithTag("Player");
        if (player == null)
        {
            Debug.LogError("Missing Player");
        }
        

        #endregion

    }

	void Update()
    {
		// Send the dna value to be updated to the update script
		sUpdate.UpdateScore(dna.GetScore());
       
    }
	
	public void DeadPlayer()
    {
        // once this method is called we save the high score and call the level loader
       
        if( PlayerPrefs.GetInt("HighScore") < dna.GetScore() )
        {
            PlayerPrefs.SetInt("HighScore", dna.GetScore());
        }

        // Play the audio and wait before loading the final score
        FindObjectOfType<AudioManager>().PlayAudio("Death");
        FindObjectOfType<AudioManager>().AdjustVol(0, "Bgm");
        StartCoroutine(DelayForLoad());
       


    }

    // An enumerator to delay the level loading till the audio is played
    private IEnumerator DelayForLoad()
    {
        yield return new WaitForSeconds(1.5f);
        levelLoader.LoadLevel();
    }
}
