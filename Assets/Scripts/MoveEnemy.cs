using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MoveEnemy : MonoBehaviour {

	public Transform target;
	public float moveSpeed = 3f;
	public float rotateSpeed = 3f;
	public Text killCounter;
	public AudioClip[] deathSound;
	public AudioSource enemyAudio;
	public SpriteRenderer spriteRend;
	public PolygonCollider2D polyColl;
	public bool hasHitShrine = false;
	

	void Start()
	{
		target = GameObject.Find("Shrine").transform;
		//killCounter = GetComponent<Text> ();
		enemyAudio = GetComponent<AudioSource> ();
		polyColl = GetComponent<PolygonCollider2D> ();
		spriteRend = GetComponent<SpriteRenderer> ();
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
		if (col.gameObject.tag == "Bullet") {
			enemyAudio.PlayOneShot (deathSound [Random.Range (0, deathSound.Length)]);
			PlayerScript.enemiesKilled++;
			Debug.Log (PlayerScript.enemiesKilled);
			spriteRend.enabled = false;
			polyColl.enabled = false;
			Destroy(gameObject, 1.0f);

		}

	}


	IEnumerator KillEnemy()
	{
		yield return new WaitForSeconds(1); //waits 1 second
		Destroy(gameObject); //this will work after 1 second.
	}
}

	

