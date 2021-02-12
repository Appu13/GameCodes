using UnityEngine;

public class TargetFrameRate : MonoBehaviour 
{
	/// <summary>
	/// This is used to control the frame rate of the game
	/// </summary>
	
	public int frameRate = 30;
	
	// Use this for initialization
	void Start () 
	{
		QualitySettings.vSyncCount = 0;
		Application.targetFrameRate = frameRate;
	}
	
}
