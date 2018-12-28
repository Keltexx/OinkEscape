using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int startingHealth = 100;            // The amount of health the enemy starts the game with.
    public int currentHealth = 100;                   // The current health the enemy has.
	public int dmg = 10;
	public Slider healthSlider;
	


    void Start (){
		healthSlider.value = startingHealth;
    }
	
	void Update(){
		if(currentHealth <= 0 ){
			healthSlider.value = 0;
			SceneManager.LoadScene ("GameOver");
		}
	}
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Enemigo"){
			currentHealth -= dmg;
		}else if(collision.gameObject.tag == "Boss"){
			currentHealth -= dmg + 20;
		}
		healthSlider.value = currentHealth;
		if(collision.gameObject.tag == "Llave"){
			SceneManager.LoadScene ("Scene02");
		}
	}
	
}