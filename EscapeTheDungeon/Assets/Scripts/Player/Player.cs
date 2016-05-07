using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour {


	//Sonidos
	public AudioSource corazon;
	public AudioSource mePegan;
	public AudioSource lePegoT;


	//Variables Personaje
	private const int MAX_VIDA = 5000;
	public int vida = MAX_VIDA;
	public Text txtVida;
	private int score = 0;
	public Text txtScore;
	public WeaponController weapons;

	public GameObject llave;

	// Use this for initialization
	void Start () {
	
		//Sonidos
		AudioSource[] audios = GetComponents<AudioSource>();
		corazon = audios [3];
		mePegan = audios [2];
		lePegoT = audios [2];

		//Llave
		llave.SetActive(false);

		//Textos
		txtVida.text = "Vida: " + ((vida * 100) / MAX_VIDA) + "%";
		txtScore.text = "";

	}
	
	// Update is called once per frame
	void Update () {

		if(!GameObject.Find ("Troll")){
			llave.SetActive(true);
		}

		if (vida <= 0) {
			SceneManager.LoadScene ("lose");
		}


	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.name == "Heart") {
			corazon.Play ();
			Destroy (col.gameObject);
			vida += 1000;
			if (vida > MAX_VIDA) {
				vida = MAX_VIDA;
			}
			txtVida.text = "Vida: " + ((vida * 100) / MAX_VIDA) + "%";
		} 
		else if (col.gameObject.name == "+Flechas") {
			weapons.flechas += 15;
			Destroy (col.gameObject);
			corazon.Play ();
		}
		else if (col.gameObject.name == "+Lanzas") {
			weapons.lanzas += 5;
			Destroy (col.gameObject);
			corazon.Play ();
		}
		else if (col.gameObject.name == "+Piedras") {
			weapons.piedras += 20;
			Destroy (col.gameObject);
			corazon.Play ();
		}
		else if (col.gameObject.name == "Llave") {
			corazon.Play ();
			SceneManager.LoadScene ("Win");
		}
		else if (col.gameObject.name == "CuboEntrada") {
			corazon.Play ();
			SceneManager.LoadScene ("Nivel1");
		}

		weapons.updateTxtWeapons ();
	}

	public void meAtacan(){

		if (mePegan.isPlaying == false) {
			mePegan.Play ();
		}
		vida -= 5;
		txtVida.text = "Vida: " + ((vida * 100) / MAX_VIDA) + "%";
	}
		
	public void lePego(){
		if (lePegoT.isPlaying == false) {
			lePegoT.Play ();
		}
	}

}
	