using UnityEngine;
using System.Collections;
using UnityEngine.AI;


public class EnemyAttack : MonoBehaviour{
	NavMeshAgent agent;
	EnemyHealth enemigoVida;
	
	float dist;
	public float distanciaPerseguir = 15f;
	public float distanciaAtaque = 1f;
	public float tiempoAtaque = 2f;
	
	public bool perseguir = false;
	public float tiempoD = 5f;
	
	Transform player;
	PlayerHealth playerHealth;
	
	public int dmgEnemy = 10;
	
	void Awake(){
		agent = GetComponent<NavMeshAgent>();
		enemigoVida = GetComponent<EnemyHealth>();
		player = GameObject.FindGameObjectWithTag("Player").transform;
		playerHealth = player.GetComponent<PlayerHealth>();
	}
	
	void Start(){
		
	}
	
	void Update(){
			if(enemigoVida.currentHealth > 0){
				dist = Vector3.Distance (player.position, transform.position);
				if(dist<= distanciaPerseguir){
					perseguir = true;
					tiempoD = 5f;
				}else{
					tiempoD -= Time.deltaTime;
					if(tiempoD <= 0){
						tiempoD = 5f;
						perseguir = false;
					}
				}
				if(perseguir == true){
					agent.SetDestination(player.position);
					if(dist <= distanciaAtaque){
						tiempoAtaque -= Time.deltaTime;
						if(tiempoAtaque <= 0){
							playerHealth.currentHealth -= dmgEnemy;
							tiempoAtaque = 2f;
						}
					}
				}
		}
		
	}
}