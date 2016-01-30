using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	public GameObject bulletPrefab;
	public float bulletSpeed = 10.0f;
	// Use this for initialization

	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			Fire ();
		}
	}

	void Fire()
	{
		Instantiate(bulletPrefab, transform.position+(transform.forward*2), transform.rotation);
	}
}
