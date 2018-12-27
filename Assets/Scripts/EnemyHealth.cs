using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour
{
    public int startingHealth = 100;            // The amount of health the enemy starts the game with.
    public int currentHealth = 100;                   // The current health the enemy has.
	public int dmg = 10;

    //bool isDead;                                // Whether the enemy is dead.
	
	void Start(){
	}
	
	void Update(){
		if(currentHealth <= 0 ){
			Destroy(gameObject);
		}
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.layer == 13){
			currentHealth -= dmg;
		}
	}
}