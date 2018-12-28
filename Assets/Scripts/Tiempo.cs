using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour {
	public double cambioEscena = 7f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		cambioEscena -= Time.deltaTime;
		if(cambioEscena <= 0){
			SceneManager.LoadScene ("Scene01");
		}
	}
}
