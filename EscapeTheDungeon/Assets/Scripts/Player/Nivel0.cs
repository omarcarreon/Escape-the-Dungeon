using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Nivel0 : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col){
	
		if (col.gameObject.name == "CuboEntrada") {
			SceneManager.LoadScene ("Nivel1");
		}

	}

}
