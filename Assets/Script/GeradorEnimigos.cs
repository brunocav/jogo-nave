using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorEnimigos : MonoBehaviour {
	public GameObject enimigos;
	public float LimiteEsquerdo,LimiteDireito,Intervalo;

	// Use this for initialization
	void Start () {
		StartCoroutine (GerarEnimigos (Intervalo));

	}
	
	// Update is called once per frame
	void Update () {
	}
	IEnumerator GerarEnimigos(float t){
		Vector3 p = new Vector3(Random.Range(LimiteEsquerdo,LimiteDireito),5.0f,0.0f);
		Instantiate (enimigos, p,enimigos.transform.rotation);
		yield return new WaitForSeconds (t);

		StartCoroutine (GerarEnimigos (Intervalo));

	}
}
