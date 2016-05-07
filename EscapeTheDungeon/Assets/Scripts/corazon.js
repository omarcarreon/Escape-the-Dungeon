#pragma strict

internal var source: AudioSource;

function Start () {
	//var aSources = GetComponents(AudioSource);
	//source = aSources[1];
}

function Update () {

}

function OnTriggerEnter(col : Collider){

	if(col.gameObject.name == "JugadorCam"){
		//source.Play();
	}
}