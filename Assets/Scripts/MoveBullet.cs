using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour
{
	public float bulletSpeed = 2.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate(Vector3.up * Time.deltaTime * bulletSpeed);
		StartCoroutine (Die ());
	}

	IEnumerator Die()
	{
		yield return new WaitForSeconds(3); //waits 3 seconds
		Destroy(gameObject); //this will work after 3 seconds.
	}
}
