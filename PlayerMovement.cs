using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	/// <summary>
	/// Script used to move the player and shoot
	/// </summary>
	public float speed;
	public float jumpForce;
	private Vector2 position;
	private Animator anim;
	private Rigidbody2D rb;


	// Use this for initialization
	void Start () 
	{
		rb = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		// Get the player input
		position.x = Input.GetAxisRaw("Horizontal");
		position.y = Input.GetAxisRaw("Vertical");
		
		// Play the appropriate animation based on the player input
		if (position.x > 0)
		{
			anim.Play("Right");
		}
		else if (position.x < 0)
		{
			anim.Play("Left");
		}
		else if (position.y > 0)
		{
			anim.Play("Up");
		}
		else if (position.y < 0)
		{
			anim.Play("Down");
		}
		else
        {
			anim.SetBool("IsWalking", false);
        }

	}

	void FixedUpdate()
    {
		rb.velocity = position*speed;
		
	}
}
