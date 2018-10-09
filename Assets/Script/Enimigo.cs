using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enimigo : MonoBehaviour {

	float velo = 5 ;
	// Use this for initialization
	void Start () {

		Destroy (gameObject, 3.0f);

	}



	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.down *velo* Time.deltaTime);

	}
	void OnCollisionEnter (Collision c)
	{
		if (c.gameObject.tag == "Player" ) {
			SpaceShip.vida--;
			Destroy (gameObject);
			SpaceShip.Instace.PosicaoInicial();
		}
		else if (c.gameObject.tag == "Fundo" ) {
			SpaceShip.vida--;
			Destroy (gameObject);
			SpaceShip.Instace.PosicaoInicial();
		}

	}
}

