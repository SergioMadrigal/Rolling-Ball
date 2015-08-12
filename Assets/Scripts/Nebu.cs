using UnityEngine;
using System.Collections;

public class Nebu : MonoBehaviour {

   public void ChangeToScene(int sceneToChangeTo){

		Application.LoadLevel ("Game");
		Time.timeScale = 1;
	}
	public void ChangeToScene1(int sceneToChangeTo1){

		Application.LoadLevel ("Acerca");

	}
	public void ChangeToScene2(int sceneToChangeTo2){
		
		Application.LoadLevel ("Menu");
	}
	public void ChangeToScene3(int sceneToChangeTo3){
		
		Application.Quit ();
	}
	public void ChangeToScene4(int sceneToChangeTo4){
		 
		Application.LoadLevel ("Game 1");
		Time.timeScale = 1;
	}
	public void ChangeToSceneL1(int sceneToChangeToL1){
		
		Application.LoadLevel ("Game 1");
		Time.timeScale = 1;
	}

}
