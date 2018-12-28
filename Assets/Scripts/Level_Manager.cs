using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level_Manager : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public void CargaNivel(string nombreNivel){
		SceneManager.LoadScene (nombreNivel);
	}
	public void Salir () {
		Application.Quit();
	}
}
