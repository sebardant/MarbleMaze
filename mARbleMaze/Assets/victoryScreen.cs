﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class victoryScreen : MonoBehaviour {

    public Text score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnEnable()
    {
        Debug.Log("score = " + Camera.main.GetComponent<ScoreHandler>().score);
        score.text = Camera.main.GetComponent<ScoreHandler>().score.ToString();
    }
}
