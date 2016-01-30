using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour 
{
	public GameObject bulletPrefab;
	public float bulletSpeed = 10.0f;
	public static int enemiesKilled = 0;
	public ParticleSystem muzzleFlash;

	AudioSource gunshot;
	// Use this for initialization

	void Start () 
	{
		muzzleFlash.emissionRate = 0;
		gunshot = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.UpArrow))
		{
			Fire ();
			muzzleFlash.Emit (30);
			gunshot.Play();

		}
		else
		{
			muzzleFlash.emissionRate = 0;
		}
	}

	void Fire()
	{
		Instantiate(bulletPrefab, transform.position+(transform.forward*2), transform.rotation);
	}
}
