﻿using UnityEngine;
using System.Collections;

public class Nivel1 : MonoBehaviour {

	public void Level1(int Level1To){
		
		Application.LoadLevel ("Game 1");
		Time.timeScale = 1;
	}
	public void Level2(int Level2To){
		
		Application.LoadLevel ("Menu");
		Time.timeScale = 1;
		
	}
}
