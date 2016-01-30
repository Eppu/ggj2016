using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public Text deathCount;

	void Start ()
	{
		deathCount = GetComponent<Text> ();
	}
	

	void Update ()
	{
		deathCount.text = "Enemies killed: " + PlayerScript.enemiesKilled;
	}
}
