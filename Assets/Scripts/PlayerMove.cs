using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour 
{
	public float rotationSpeed = 100.0f;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			RotateLeft();
		}
		if(Input.GetKey(KeyCode.RightArrow ))
		{
			RotateRight();
		}


	}

	void RotateLeft ()
	{
		transform.Rotate (Vector3.forward * rotationSpeed);
	}
	void RotateRight()
	{
		transform.Rotate (Vector3.back * rotationSpeed);
	}
}
