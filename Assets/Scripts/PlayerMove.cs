using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	public float rotationSpeed = 100.0f;
	GameObject player;
	Animator playerAnim;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find ("Player");
		playerAnim = player.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
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
		else
		{
			playerAnim.SetInteger("Direction", 0);
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
