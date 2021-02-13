using UnityEngine;
using UnityEngine.UI;

public class GameManagerSquash : MonoBehaviour 
{
    #region Variables

    // This script is used to manage the game
 
    public static GameManagerSquash gm;
    public TextSet ts;
    public Text go;
    public PlayerCharecterstics pc;
    public AudioManager am;
    #endregion
    void Awake()
    {

        ts.SetText(pc.GetPlayerLives());   

    }

    void Start()
    {
        #region Playing Audio

        am.AdjustPitch(Random.Range(0.9f, 1.3f), "Bgm");
        am.AdjustVolume(0.7f, "Bgm");
        am.PlayAudio("Bgm"); 
        #endregion
    }
    
    public void UpdateScore()
    {
        ts.SetText(pc.GetPlayerLives());
    }

    public void EndGame()
    {
        am.StopAudio("Bgm");
        am.PlayAudio("Over");
        go.gameObject.SetActive(true);
    }
	
    
}
