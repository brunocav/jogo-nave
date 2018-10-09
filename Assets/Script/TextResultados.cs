using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextResultados : MonoBehaviour {
	public Text  TxtPontos,TxtVidas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		TxtVidas.text = "Vidas :" + SpaceShip.vida.ToString ();
		TxtPontos.text = "Pontos :" + SpaceShip.pontos.ToString ();

	}
	public void voltarJogo(){
		SceneManager.LoadScene ("SampleScene", LoadSceneMode.Single);

	}
}
