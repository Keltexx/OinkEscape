﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MueveBala : MonoBehaviour {

	public float Velocidad = 200f;
	
	// Use this for initialization
	void Start () {
		Destroy(gameObject,1f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Velocidad * Time.deltaTime);
	}
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Enemigo"){
			Destroy(gameObject);
		}
		if(collision.gameObject.tag == "Boss"){
			Destroy(gameObject);
		}
		if(collision.gameObject.tag == "Shooteable"){
			Destroy(gameObject);
		}
	}

}