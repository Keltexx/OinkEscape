using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MueveBala : MonoBehaviour {

	public float Velocidad = 200f;

	// Use this for initialization
	void Start () {
		Destroy(gameObject,2f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * Velocidad * Time.deltaTime);
	}
	void OnCollisionEnter(Collision target){
		if(target.gameObject.tag == "Enemigo"){
			Destroy(gameObject);
		}
		if(target.gameObject.layer == 12){
			Destroy(gameObject);
		}
	}
}
