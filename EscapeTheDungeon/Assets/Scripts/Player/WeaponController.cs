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
	public GameObject arco;
	public GameObject slingshot;
	public GameObject lanza;
	public Rigidbody lanzaPiedras;
	public Rigidbody lanzaFlecha;
	public Rigidbody lanzaLanza;

	// Use this for initialization
	void Start () {

		//Sonidos
		AudioSource[] audios = GetComponents<AudioSource>();
		cambioArma = audios[0];

		//Textos e Imágenes iniciales
		updateTxtWeapons();
		updateWeaponColor();

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("tab")) {
			cambioArma.Play();
			armaActual++;

			if (armaActual > 2) {
				armaActual = 0;
			}

			updateWeaponColor();
		} else if (Input.GetButton ("Fire1")){
			shootWeapon ();	
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
			slingshot.SetActive (true);
			lanza.SetActive (false);
			arco.SetActive (false);
			imgSlingshot.color = Color.white;
			imgLanzas.color = new Color(1f, 1f, 1f, .5f);
			imgFlechas.color = new Color(1f, 1f, 1f, .5f);
			break;
		case 1:
			slingshot.SetActive (false);
			lanza.SetActive (true);
			arco.SetActive (false);
			imgSlingshot.color = new Color(1f, 1f, 1f, .5f);
			imgLanzas.color = Color.white;
			imgFlechas.color = new Color(1f, 1f, 1f, .5f);
			break;
		case 2:
			slingshot.SetActive (false);
			lanza.SetActive (false);
			arco.SetActive (true);
			imgSlingshot.color = new Color(1f, 1f, 1f, .5f);
			imgLanzas.color = new Color(1f, 1f, 1f, .5f);
			imgFlechas.color = Color.white;
			break;

		}
	}

	void shootWeapon()
	{
		float speed = 20f;
		float tiempoDeVida = .5f;
		switch (armaActual) {
		case 0:
			if (GameObject.Find ("Pokeball(Clone)") == null) {
				Rigidbody clone = Instantiate (lanzaPiedras, transform.position, transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
				Destroy(clone.gameObject, tiempoDeVida);

			}
			break;
		case 1:
			if (GameObject.Find ("Pokeball(Clone)") == null) {
				Rigidbody clone = Instantiate (lanzaLanza, transform.position, transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
				Destroy (clone.gameObject, tiempoDeVida);
			}
			break;
		case 2:
			if (GameObject.Find ("Pokeball(Clone)") == null) {
				Rigidbody clone = Instantiate (lanzaFlecha, transform.position, transform.rotation) as Rigidbody;
				clone.velocity = transform.TransformDirection (new Vector3 (0, 0, speed));
				Destroy(clone.gameObject, tiempoDeVida);
			}
			break;
		}

	}

}
