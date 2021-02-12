using UnityEngine;
using System.Collections;

public class DestroyGameObject : MonoBehaviour 
{
	/// <summary>
	/// Used to destroy the game object 
	/// </summary>

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(Delay());
	}
	IEnumerator Delay()
    {
		yield return new WaitForSeconds(1f);
		Destroy(gameObject);
    }
	
}
