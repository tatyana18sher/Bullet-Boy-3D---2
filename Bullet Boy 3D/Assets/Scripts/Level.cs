﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{

    public Text text;
	public static int sceneIndex;


	void Start() {
		text = GetComponent<Text>();
		sceneIndex = SceneManager.GetActiveScene().buildIndex;
	}
	
	void Update() {
		text.text = "Level " + sceneIndex;
	}

}
