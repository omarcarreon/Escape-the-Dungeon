using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WeaponController : MonoBehaviour {


	//Sonidos
	public AudioSource cambioArma;


	//Variables de Armas
	int piedras = 20;
	int lanzas = 10;
	int flechas = 10;
	private int armaActual = 0;

	//Outlets de armas
	public Text txtSlingshot;
	public Text txtLanzas;
	public Text txtFlechas;
	public Image imgSlingshot;
	public Image imgLanzas;
	public Image imgFlechas;

	// Use this for initialization
	void Start () {

		//Sonidos
		AudioSource[] audios = GetComponents<AudioSource>();
		cambioArma = audios [2];


		//Textos e Imágenes iniciales
		updateTxtWeapons();
		updateWeaponColor();

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("tab")) {
			print ("tab key was pressed");
			armaActual++;

			if (armaActual > 2) {
				armaActual = 0;
			}

			updateWeaponColor();
		}
	}

	void updateTxtWeapons(){
		txtSlingshot.text = "" + piedras;
		txtLanzas.text = "" + lanzas;
		txtFlechas.text = "" + flechas;
	}


	void updateWeaponColor(){

		switch (armaActual) {
		case 0:
			imgSlingshot.color = Color.white;
			imgLanzas.color = new Color(1f, 1f, 1f, .5f);
			imgFlechas.color = new Color(1f, 1f, 1f, .5f);
			break;
		case 1:
			imgSlingshot.color = new Color(1f, 1f, 1f, .5f);
			imgLanzas.color = Color.white;
			imgFlechas.color = new Color(1f, 1f, 1f, .5f);
			break;
		case 2:
			imgSlingshot.color = new Color(1f, 1f, 1f, .5f);
			imgLanzas.color = new Color(1f, 1f, 1f, .5f);
			imgFlechas.color = Color.white;
			break;

		}
	}

}
