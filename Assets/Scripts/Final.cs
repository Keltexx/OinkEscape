using UnityEngine;
using UnityEngine.SceneManagement;

public class Final : MonoBehaviour {

    public float speed = 4f;            // The speed that the player will move at.

    Vector3 movement;                   // The vector to store the direction of the player's movement.
    Animator anim;                      // Reference to the animator component.
    Rigidbody playerRigidbody;         // Reference to the player's rigidbody.
    int floorMask;                      // A layer mask so that a ray can be cast just at gameobjects on the floor layer.
	DisparoPlayer PlayerDispara;
	
    void Awake()
    {
        // Create a layer mask for the floor layer.
        floorMask = LayerMask.GetMask("Floor");

        // Set up references.
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
		PlayerDispara = GetComponentInChildren<DisparoPlayer>();
    }


    void FixedUpdate()
    {
        // Move the player around the scene.
        Move(5, 5);

        // Animate the player.
        Animating(5, 5);
		PlayerDispara.Disparar = false;
    }

    void Move(float h, float v)
    {
        // Set the movement vector based on the axis input.
        movement.Set(h, 0f, v);

        // Normalise the movement vector and make it proportional to the speed per second.
        movement = movement.normalized * speed * Time.deltaTime;

        // Move the player to it's current position plus the movement.
        playerRigidbody.MovePosition(transform.position + movement);
    }

    void Animating(float h, float v)
    {
        // Create a boolean that is true if either of the input axes is non-zero.
        bool walking = h != 0f || v != 0f;
        // Tell the animator whether or not the player is walking.
        anim.SetBool("IsWalking", walking);
    }
	
	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Fin"){
			SceneManager.LoadScene ("Menu");
		}
	}
}
