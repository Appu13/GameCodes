using UnityEngine;

public class StartUp : MonoBehaviour 
{
	/// <summary>
	/// used to do the inital setups of the game
	/// </summary>

	void Awake()
    {
		// Resetting the stored high score in memory
		PlayerPrefs.SetInt("HighScore", 0);
		Debug.Log(PlayerPrefs.GetInt("HighScore"));
    }
	
}
