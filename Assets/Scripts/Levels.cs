using UnityEngine;
using System.Collections;

public class Levels : MonoBehaviour {

	public void Level1(int Level1To){
		
		Application.LoadLevel ("Game");
		Time.timeScale = 1;
	}
	public void Level2(int Level2To){
		
		Application.LoadLevel ("Acerca");
		
	}
	public void Level3(int Level2To3){
		
		Application.LoadLevel ("Menu");
	}
}
