using UnityEngine;

public class ZombieCharecterstics: MonoBehaviour 
{
	/// <summary>
	/// Used to do the zombie shuffle XD
	/// </summary>

	private float shuffleSpeed;
	[SerializeField]
	private float rateOfIncrease = .01f;
	private Animator anim;
	private int tester;
	private Rigidbody2D rb;
	public PlayerCharecterstics pc;

	// Use this for initialization
	
	void OnEnable () 
	{

		rb = gameObject.GetComponent<Rigidbody2D>();
		anim = gameObject.GetComponent<Animator>();

		// Calculate a random shuffle speed for the zombie
		shuffleSpeed = Random.Range(3.5f, 7f);
		
		// We use tester variable to find the inital position of the variable and then mobe it appropriately 
		if(transform.position.x<0)
        {
			tester = -1;
        }
		else if(transform.position.x>0)
        {
			tester = 1;
        }

	}
	
	void FixedUpdate ()
	{
		Walk();
	}

  void OnCollisionEnter2D(Collision2D collision)
    {
        Hit(collision);
    }

    #region Walk
    private void Walk()
    {
        // If tester shows 1 then the object is located on the right and we need to move it to the left
        if (tester == 1)
        {
            rb.AddForce(Vector3.left * shuffleSpeed * Time.fixedDeltaTime);
            anim.Play("ZRight");
        }
        // if the tester shows -1 then the object is located on the left side and we need to move it to the right
        else if (tester == -1)
        {
            rb.AddForce(Vector3.right * shuffleSpeed * Time.fixedDeltaTime, ForceMode2D.Force);
            anim.Play("ZLeft");
        }

    }

    #endregion


    #region Hit

    private void Hit(Collision2D collision)
    {
        // If the zombie hits a wall then make him inactive
        if (collision.collider.CompareTag("Wall") || collision.collider.CompareTag("Zombie Dude"))
        {
            gameObject.SetActive(false);

        }
        // if the zombie hits the player then increase his infection rate
        if (collision.collider.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            pc.UpdateRate(rateOfIncrease);
        }
    }

#endregion
}
