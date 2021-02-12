using UnityEngine;

public class Dna : MonoBehaviour
{
	/// <summary>
	/// This script is used to control the dna object
	/// </summary>
	private float randX;
	private float randY;
	private int score = 0;
	[SerializeField]
	ScoreUpdate su;


	void Start()
    {
		randX = Random.Range(-4.8f, 4.9f);
		randY = Random.Range(-3.3f, 2.8f);
		gameObject.transform.position = new Vector3(randX, randY, 0);
	}
	// Update is called once per frame
	void Update () 
	{
		// Rotate the dna with respect to the frame rate
		transform.Rotate(new Vector3(0, Time.deltaTime * 60, 0));

	}
	void OnTriggerEnter2D(Collider2D collider)
    {
		if (collider.CompareTag("Player"))
		{

			randX = Random.Range(-4.8f, 4.9f);
			randY = Random.Range(-3.3f, 2.8f);
			gameObject.transform.position = new Vector3(randX, randY, 0);
			score++;
		}
	}
	 
	// Getter method for score
	public int GetScore()
    {
		return score;
    }
	
}
