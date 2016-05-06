using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour {

	private const int MAX_VIDA = 5000;
	public int vida = MAX_VIDA;
	public Text txtVida;
	private int score = 0;
	public Text txtScore;

	// Use this for initialization
	void Start () {
	
		txtVida.text = "Vida: " + ((vida * 100) / MAX_VIDA) + "%";
		txtScore.text = "Puntos: " + score;

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){

		if(col.gameObject.name == "Heart"){
			Destroy(col.gameObject);
			vida += 250;
			if (vida > MAX_VIDA) {
				vida = MAX_VIDA;
			}
			txtVida.text = "Vida: " + ((vida * 100) / MAX_VIDA) + "%";
		}



	}
}

/*
 * using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MsgSaliendoJuego : MonoBehaviour {

	public Text mensaje;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void onTriggerEnter(Collider col){
	
		if (col.gameObject.name == "RigidBodyFPSController") {
			mensaje.text = "Estás saliendo del área de juego";
	
		}
	}

	void onTriggerExit(Collider col){

		if (col.gameObject.name == "RigidBodyFPSController") {
			mensaje.text = "";

		}
	}
}

 * */