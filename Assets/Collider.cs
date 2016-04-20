using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Collider : MonoBehaviour {

	List<Collider> colliders = new List<Collider>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

 
    	void OnCollisionStay(Collision collision)
     	{
		Debug.Log("collision name = " + collision.gameObject.tag);
        	if (collision.gameObject.tag == "Box"){
        		Destroy(collision.gameObject);
    		}
	}
}
