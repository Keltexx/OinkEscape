using UnityEngine;
using System.Collections;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class BossHealth : MonoBehaviour
{
	
    public int startingHealth = 800;            // The amount of health the enemy starts the game with.
    public int currentHealth = 800;                   // The current health the enemy has.
	public int dmg = 10;
	public bool muerto = false;
	public GameObject Llave1;
	public GameObject Llave2;
	
	
	void Start(){
	}
	
	void Update(){
		if(currentHealth <= 0 && muerto == false){
			Muere();
			muerto = true;
		}
	}
	
	void Muere(){
		Destroy(this.gameObject);
		if(SceneManager.GetActiveScene().name == "Scene01"){
			Instantiate(Llave2, this.transform.position, this.transform.rotation);
		}else{
			Instantiate(Llave1, this.transform.position, this.transform.rotation);
		}
		
	}
	
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.layer == 13){
			currentHealth -= dmg;
		}
	}
}