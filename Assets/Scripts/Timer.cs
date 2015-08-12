using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public float time = 30.0f;
	public GameObject textgameobject;
	public GameObject per;
	// Use this for initialization
	void Start () {
		MeshRenderer p= per.GetComponent<MeshRenderer> ();
		p.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
		time -= Time.deltaTime;
		Text text = textgameobject.GetComponent<Text>();
		text.text =" " + time.ToString("0");
		if (time <= 0) {
			time = 0;
			MeshRenderer p =per.GetComponent<MeshRenderer>();
			p.enabled = true;
			Time.timeScale = 0;
		}
	}
}
