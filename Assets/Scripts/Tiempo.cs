using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour {
	double cambioEscena = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.deltaTime >= cambioEscena){
			SceneManager.LoadScene ("Scene01");
		}
	}
}
