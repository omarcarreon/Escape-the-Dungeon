using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class winScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {


	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButton ("tab")) {
			SceneManager.LoadScene("Main Menu");
		}
		else if (Input.GetButton ("Jump")) {
			SceneManager.LoadScene("Nivel0");
		}
	
	}
	public void StartGame () 
	{
		SceneManager.LoadScene ("Nivel0");
	}
	public void LoadMenu() {
		SceneManager.LoadScene("Main Menu");
	}
	public void endGame () 
	{
		Application.Quit ();
	}
}

