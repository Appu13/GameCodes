using UnityEngine;

public class PaddleMovement : MonoBehaviour 
{
	/// <summary>
	/// Used to control the paddles
	/// </summary>

	private Rigidbody2D rb;
	private float dir;

	public float speed = 5f;


	// Use this for initialization
	void Awake () 
	{
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		dir = Input.GetAxisRaw("Vertical");
		Move();
	}

	void Move()
    {

		transform.Translate(new Vector3(0, dir, 0) * Time.deltaTime * speed);
    }
}
