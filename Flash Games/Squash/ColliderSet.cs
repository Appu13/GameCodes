using UnityEngine;

public class ColliderSet : MonoBehaviour 
{
	/// <summary>
	/// This script is used to setup the colliders for the scene
	/// </summary
	

	private Camera cam;
	private float camHeight;
	private float camWidth;
	private float sizeCorrection = .01f;


	public BoxCollider2D topCollider;
	public BoxCollider2D bottomCollider;
	public BoxCollider2D leftCollider;
	public BoxCollider2D rightCollider;

	// Use this for initialization
	void Start () 
	{
		// Intializing the camera and its height and width
		cam = Camera.main;
		camHeight = 2f * cam.orthographicSize;
		camWidth = camHeight * cam.aspect;

		

		// Setting the location of the colliders
		topCollider.size = new Vector2(camWidth, sizeCorrection);
		topCollider.offset = new Vector2(0, camHeight/2);

		bottomCollider.size = new Vector2(camWidth, sizeCorrection);
		bottomCollider.offset = new Vector2(0, -camHeight / 2);

		leftCollider.size = new Vector2(sizeCorrection, camHeight);
		leftCollider.offset = new Vector2(-camWidth/2f, 0);
		leftCollider.isTrigger = true;

		rightCollider.size = new Vector2(sizeCorrection, camHeight);
		rightCollider.offset = new Vector2(camWidth / 2f, 0);
	}
	
	
	
}
