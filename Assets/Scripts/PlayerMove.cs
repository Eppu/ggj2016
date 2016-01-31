using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	public float rotationSpeed = 100.0f;
	GameObject player;
	Animator playerAnim;
	
	void Start () 
	{
		//player = GameObject.Find ("Player");
		//playerAnim = player.GetComponent<Animator> ();
	}

	void Update () 
	{
		if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			RotateLeft();

		}
		if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.W))
		{
			RotateRight();

		}
	}

	void RotateLeft ()
	{
		transform.Rotate (Vector3.forward * rotationSpeed);
		//playerAnim.SetInteger("Direction", 1);
	}
	void RotateRight()
	{
		transform.Rotate (Vector3.back * rotationSpeed);
		//playerAnim.SetInteger("Direction", 1);
	}
}
