using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salir : MonoBehaviour {

	// Hace que salgamos del juego
	void Salimos () {
		Application.Quit();
		Debug.Log("Salimos.");
	}
}
