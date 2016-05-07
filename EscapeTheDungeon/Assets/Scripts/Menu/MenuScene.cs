using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuScene : MonoBehaviour {

	public GameObject insPanel;
	public GameObject credPanel;
	void Start () 
	{
		insPanel.SetActive (false);
		credPanel.SetActive (false);
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetButton ("Jump")) {
			SceneManager.LoadScene("Nivel0");
		}

	}

	public void lookCredits () {
		credPanel.SetActive (true);
	}

	public void closeCredits () {
		credPanel.SetActive (false);
	}
	public void LookInstructions ()
	{
		insPanel.SetActive (true);
	}
	public void CloseIns ()
	{
		insPanel.SetActive (false);
	}
	public void StartGame () 
	{
		SceneManager.LoadScene ("Nivel0");
	}
	public void endGame () 
	{
		Application.Quit ();
	}
}
