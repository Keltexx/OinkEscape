using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoPlayer : MonoBehaviour {
	
	public bool Disparar = false;
	
	public MueveBala Bala;
	public float VelocidadBala;
	public float VelocidadDisparo;
	public float TiempoEspera;
	public Transform SalidaBala;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		DispararBala();
	}
	void DispararBala(){
		if(Disparar == true){
			TiempoEspera -= Time.deltaTime;
			if(TiempoEspera <= 0){
				TiempoEspera = VelocidadDisparo;
				MueveBala newBala = Instantiate (Bala, SalidaBala.position, SalidaBala.rotation) as MueveBala;
				newBala.Velocidad = VelocidadBala;
			}
		}
	}
}
