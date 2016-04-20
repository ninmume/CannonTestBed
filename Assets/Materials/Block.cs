using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour {

	public float health = 15;

	void Collide(Collision collision){
		if (collision.relativeVelocity.magnitude > 0.5){
			health -= collision.relativeVelocity.magnitude;
		}
		if (health <= 0){
			Destroy(gameObject);
			GameObject[] boxes = GameObject.FindGameObjectsWithTag("Box");
		}
		Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
