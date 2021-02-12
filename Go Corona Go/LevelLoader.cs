using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour 
{
	/// <summary>
	/// This script to handle loading functions
	/// </summary>

	public string levelToLoad;

	public void LoadLevel()
    {
		SceneManager.LoadScene(levelToLoad);
    }

	public void Exit()
    {
		Debug.Log("Quiting");
		Application.Quit();
		
    }
}
