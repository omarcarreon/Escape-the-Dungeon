#pragma strict

internal var source: AudioSource;

function Start () {
	var aSources = GetComponents(AudioSource);
	source = aSources[0];
}

function Update () {

}

function OnTriggerEnter(col : Collider){

	if(col.gameObject.name == "Jugador"){
		Debug.Log("Colission");
		source.Play();
	}
}