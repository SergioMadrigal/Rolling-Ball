using UnityEngine;
using System.Collections;

public class Esfera : MonoBehaviour {

	public float speed = 20F;
	//private Transform thisTransform;
	public Rigidbody rb;
	void Start () {
		rb = GetComponent<Rigidbody>();	
	}
	void FixedUpdate() {
		//float moveHorizontal = Input.GetAxis ("Horizontal");
		//float moveVertical = Input.GetAxis ("Vertical");
		
		float moveHorizontal = Input.acceleration.x*speed;
		float moveVertical = Input.acceleration.y*speed;
		
		Vector3 movement = new Vector3 (-moveHorizontal*speed, 0.0f, -moveVertical*speed);
		
		GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
	}
}



