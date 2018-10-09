using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour {
	float velo = 5 ;
	// Use this for initialization
	void Start () {
	
		Destroy (gameObject, 3.0f);

	}


	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.up *velo* Time.deltaTime);
	
	}
	void OnCollisionEnter (Collision c)
	{
		if (c.gameObject.tag == "EnimigoN") {
			print ("colisao");

			Destroy (c.gameObject);
			Destroy (gameObject);
			SpaceShip.pontos++;
		}

	}
}
