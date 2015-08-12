using UnityEngine;
using System.Collections;

public class Cubo : MonoBehaviour {

	// Use this for initialization
	void Start () { 

		Debug.Log ("Hola soy cubo");
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetKey(KeyCode.LeftArrow)){

			transform.position =new Vector3(1,0,0);

		}

		if(Input.GetKey (KeyCode.RightArrow)){
			transform.position =new Vector3 (-1,0,0);
		}
		if(Input.GetKey (KeyCode.UpArrow)){
			transform.position =new Vector3 (0,1,0);	
	}
		if (Input.GetKey (KeyCode.DownArrow)){ 
			transform.position =new Vector3 (0,-1,0);
			 }

			 }

			 }