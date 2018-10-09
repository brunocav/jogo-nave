using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SpaceShip : MonoBehaviour {
	public static SpaceShip Instace;
	public float velocidade;
	Vector3 posInicial;
	GameObject Jogador;
	public Vector3 LmE,LmD;
	public static int vida = 5;
	public static int pontos;
	// Use this for initialization

	void Awake () {
		Instace = this ;
	}
	void Start () {
		vida = 5;
		pontos = 0;
		posInicial = transform.position;
	}
	public void PosicaoInicial () {
		transform.position = posInicial;
	}
	
	// Update is called once per frame
	void Update () {
		MoverNave ();
		if (vida <= 0) {
			SceneManager.LoadScene ("Perdeu", LoadSceneMode.Single);
		}
	}
	void MoverNave(){
		float posX = Input.GetAxis ("Horizontal") * velocidade * Time.deltaTime;
		//float posY = Input.GetAxis ("Vertical")* velocidade * Time.deltaTime;

		transform.Translate (posX, 0.0f, 0.0f);

		

	}
	void OnCollisionEnter (Collision c)
	{
		if (c.gameObject.name == "limeteEsquerdo") {
			transform.position = LmD;
		} 
		else if (c.gameObject.name == "limeteDireito") {
			transform.position = LmE;
		} 

	}
}
