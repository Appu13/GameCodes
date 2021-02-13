using UnityEngine;

public class PlayerCharecterstics : MonoBehaviour {
    /// <summary>
    /// To handle the player related charecterstics
    /// </summary>
    [SerializeField]
    private int playerLives;
    
    // To return the number of lives
    public int GetPlayerLives()
    {
        return playerLives;
    }

    // Reduce the lives
    public void ReduceLives()
    {
        playerLives -= 1;

    }

}
