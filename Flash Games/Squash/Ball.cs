using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Ball : MonoBehaviour 
{
	/// <summary>
	/// Used to handle the ball function
	/// </summary>

	public Rigidbody2D rb;

	private float torque;

	// Use this for initialization
	void Start ()
	{
		// Launch the ball in a random direction
		rb.velocity = new Vector2(-5f, 0f);
		torque = 35;
	}
	
	void OnCollisionEnter2D(Collision2D collision)
    {
		// We adjust the direction of the ball based on where the ball hits
		if(collision.collider.CompareTag("Player"))
        {
			rb.AddTorque(torque);
			torque = Random.Range(35f, 50f);
			
        }

		if(collision.collider.CompareTag("Bottom Collider"))
        {
			rb.AddForce(new Vector2(0f, 2f));
        }

    }
	
	public void Reset()
    {
		transform.position = new Vector3(0, 0, 0);
		Start();
    }
}
