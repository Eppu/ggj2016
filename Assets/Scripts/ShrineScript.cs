using UnityEngine;
using System.Collections;

public class ShrineScript : MonoBehaviour {

	// Use this for initialization
	public bool hasHitShrine = false;
	public GameObject dieScreen;
	public LogoScaler logoScaler;
	public GameObject gameManager;

	void Start () 
	{
		dieScreen = GameObject.Find ("DieScreen");
		logoScaler = dieScreen.GetComponent<LogoScaler> ();
		gameManager = GameObject.Find ("GameManager");
	}
	

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Enemy") 
		{
			logoScaler.scaleUp();
			gameManager.SetActive(false);

			if(Input.GetKey(KeyCode.Return))
			{
				Application.LoadLevel(Application.loadedLevel);
			}
			
		}
		
	}


}
