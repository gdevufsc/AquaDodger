﻿using UnityEngine;
using System.Collections;

public class ReturnButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseDown(){
		GameObject.FindGameObjectWithTag ("recordsButton").gameObject.SendMessage ("returnToMainMenu");
	}
}
