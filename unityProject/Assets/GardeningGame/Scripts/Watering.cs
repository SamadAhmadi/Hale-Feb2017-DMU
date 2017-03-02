using UnityEngine;
using System.Collections;

public class Watering : MonoBehaviour {

	//Empty game object to hold the particle system
	[SerializeField]
	private GameObject watering;

	[SerializeField]
	private float updateParticles = 5.0f;

	[SerializeField]
	private float updateRate = 2.0f;

	private ParticleSystem ps;


	// Use this for initialization
	void Start () {

		//Watering game object that can be referenced
		watering = GameObject.Find ("Watering");
		ps = watering.GetComponent<ParticleSystem>();

		//Disable the emssion of the particles at the start
		var em = ps.emission; 
		em.enabled = false;
		em.rate = updateParticles;
	}
	
	void Update (){ 
		
		if (transform.localRotation.z > -0.45f){
			// Rotate the object around its local z axis by 1 degree per second
			transform.Rotate(0, 0, Time.deltaTime - 1.0f);
		}

		if (transform.localRotation.z <= -0.35f) {
			Debug.Log ("Pour water");
			var em = ps.emission; 
			em.enabled = true;
			
			//Increase the speed of the Particle System based on the rotation
			updateParticles = updateParticles + updateRate;
			em.rate = updateParticles;

		}


	}
}
