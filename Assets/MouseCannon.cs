﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

// Same as Cannon.cs, only for test purposes
public class MouseCannon : MonoBehaviour {
	public GameObject projectilePrefab;

	private bool fire = true;

	void LateUpdate(){

		//// Code for movement using mouse
		float x = Input.GetAxis("Mouse X") * 2;
		float y = -Input.GetAxis("Mouse Y");

		////vertical
		float yClamped = transform.eulerAngles.x + y;
		transform.rotation = Quaternion.Euler(yClamped, transform.eulerAngles.y, transform.eulerAngles.z);

		////horizontal
		//transform.RotateAround(new Vector3(0, 3, 0), Vector3.up, x);
		////test horizontal
		float xClamped = transform.eulerAngles.y + x;
		transform.rotation = Quaternion.Euler(transform.eulerAngles.x, xClamped, transform.eulerAngles.z);


	}



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
		//if (Input.GetKey(KeyCode.Space) && fire){
			StartCoroutine(Fire());
    		}
	}

	IEnumerator Fire(){
		fire = false;
		GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation) as GameObject;
       		 //projectile.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, 0, 3000));
		projectile.GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * 110, ForceMode.Impulse);
		// change firing rate here
		yield return new WaitForSeconds(0.5f);
		fire = true;
	}
}
