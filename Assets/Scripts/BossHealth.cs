using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class BossHealth : MonoBehaviour
{
	
    public int startingHealth = 800;            // The amount of health the enemy starts the game with.
    public int currentHealth = 800;                   // The current health the enemy has.
	public int dmg = 10;
	public bool muerto = false;
	public GameObject Llave;
	
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
		Instantiate(Llave, this.transform.position, this.transform.rotation);
	}
	
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.layer == 13){
			currentHealth -= dmg;
		}
	}
}