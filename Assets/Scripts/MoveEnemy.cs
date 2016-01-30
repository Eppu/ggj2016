using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveEnemy : MonoBehaviour {

	public Transform target;
	public float moveSpeed = 3f;
	public float rotateSpeed = 3f;
	public Text killCounter;
	public AudioClip[] deathSound;
	
	void Start()
	{
		target = GameObject.Find("Shrine").transform;
		//killCounter = GetComponent<Text> ();
	}

	void Update()
	{
		Quaternion rotation = Quaternion.LookRotation
			(target.transform.position - transform.position, transform.TransformDirection(Vector3.forward));
		transform.rotation = new Quaternion(0, 0, rotation.z, rotation.w);

		transform.position = Vector2.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);
		//move towards the player
		//if (Vector3.Distance (transform.position, target.position) > 1f) {//move if distance from target is greater than 1
		//	transform.Translate (new Vector3 (moveSpeed * Time.deltaTime, 0, 0));
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "Bullet")
		{
			PlayerScript.enemiesKilled++;
			Debug.Log(PlayerScript.enemiesKilled);
			Destroy(gameObject);
		}
	}
	
}

	

