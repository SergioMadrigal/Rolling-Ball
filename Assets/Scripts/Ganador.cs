using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Events;

public class Ganador : MonoBehaviour {

	public GameObject Obj;
	public float time = 30.0f;
	public GameObject textgameobject;
	public GameObject per;
	public bool act;

	void Start(){

		MeshRenderer m = Obj.GetComponent<MeshRenderer> ();
		m.enabled = false;

		MeshRenderer p= per.GetComponent<MeshRenderer> ();
		p.enabled = false;;

	}

	void Update () {
		
		time -= Time.deltaTime;
		Text text = textgameobject.GetComponent<Text>();
		text.text =" " + time.ToString("0");
		if (time <= 0 ) {
			time = 0;
			MeshRenderer p = per.GetComponent<MeshRenderer> ();
			p.enabled = true;
			Time.timeScale = 0;
		} 
	}	
	
	public void OnCollisionEnter(Collision other ){
		 if (other.gameObject.name == "Copa" ) {
			Handheld.Vibrate();
			Time.timeScale = 0.0f;
			MeshRenderer m = Obj.GetComponent<MeshRenderer> ();
			m.enabled = true;
		}
	}

	
}



	






	
	
	
