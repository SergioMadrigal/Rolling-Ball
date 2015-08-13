using UnityEngine;
using System.Collections;

public class Levels : MonoBehaviour {

	public void Level1(int Level1To){
		
		Application.LoadLevel ("Game 1");
		Time.timeScale = 1;
	}
	public void Level2(int Level2To){
		
		Application.LoadLevel ("Game 2");
		
	}
	public void Level3(int Level2To3){
		
		Application.LoadLevel ("");
	}
	public void Back(int BackTo){
		
		Application.LoadLevel ("Menu");
	}
}
