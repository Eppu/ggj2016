﻿using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Input.GetKey(KeyCode.Return))
		{
			Application.LoadLevel("main scene");
		}
	}
}
