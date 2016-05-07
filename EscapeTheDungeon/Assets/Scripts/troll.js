#pragma strict

public var vida = 1000;
public var sonidoMePegan: AudioSource;

function Start () {
var aSources = GetComponents(AudioSource);
	sonidoMePegan = aSources[0];
}

function Update () {

	

}

function OnTriggerEnter(col : Collider){


	if(col.gameObject.name == "Flecha(Clone)"){
		vida -= 320;
		Destroy(col.gameObject);
		sonidoMePegan.Play();
	}
	if(col.gameObject.name == "stone(Clone)"){
		vida -= 200;
		Destroy(col.gameObject);
		sonidoMePegan.Play();
	}
	if(col.gameObject.name == "Lanza(Clone)"){
		vida -= 550;
		Destroy(col.gameObject);
		sonidoMePegan.Play();
	}
}

