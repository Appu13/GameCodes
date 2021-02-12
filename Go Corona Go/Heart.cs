using UnityEngine;
public class Heart : MonoBehaviour 
{
    /// <summary>
    /// This script is used to handle the lives of the player
    /// </summary>

    #region Variables
    [SerializeField]
    private GameObject[] hearts;
    private int index = 0;
    private float beats;
    public PlayerCharecterstics pc; 
    #endregion


    #region Methods
    void Start()
    {
        beats = Random.Range(0.8f, 1f);
    }

    public void RemoveHeart()
    {
        // Check if the given index is correct before deactivating it
        if (index < hearts.Length-1)
        {
            hearts[index].gameObject.SetActive(false);
            index++;
            // Increasing the beat of the game when life reduces
            FindObjectOfType<AudioManager>().AdjustPitch((beats + 0.5f),"Bgm");

        }
        else
        {
            // Kill the player once he runs out of life
            hearts[index].gameObject.SetActive(false);
            pc.KillPlayer();
        }
    } 
    #endregion
}
