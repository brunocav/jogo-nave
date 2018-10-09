using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {
	public GameObject projetil,arma;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Jump")){
			StartCoroutine (Atirar ());
		}
	}
	IEnumerator Atirar(){
		yield return new WaitForSeconds (0.1f);
		Instantiate (projetil, transform.position, Quaternion.identity);
	}
}
