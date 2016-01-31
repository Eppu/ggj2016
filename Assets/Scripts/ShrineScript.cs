using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShrineScript : MonoBehaviour {

	// Use this for initialization
	public bool hasHitShrine = false;
	public GameObject dieScreen;
	public LogoScaler logoScaler;
	public GameObject gameManager;
	public GameObject player;
	public EnemySpawner enemySpawner;

	void Start () 
	{
		dieScreen = GameObject.Find ("DieScreen");
		logoScaler = dieScreen.GetComponent<LogoScaler> ();
		gameManager = GameObject.Find ("GameManager");
		player = GameObject.Find ("PlayerPivot");
	}
	

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Enemy") 
		{
			//logoScaler.scaleUp();
			gameObject.GetComponent<LogoScaler>().enabled=true;
			gameManager.GetComponent<EnemySpawner>().enabled=false;
			player.GetComponent<PlayerMove>().enabled=false;	
			gameManager.GetComponent<AudioSource>().volume=0.1f;
		}
		
	}

	void Update()
	{
		if(Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		if(Input.GetKey(KeyCode.Escape))
		{
			Application.Quit();
		}
	}



}
