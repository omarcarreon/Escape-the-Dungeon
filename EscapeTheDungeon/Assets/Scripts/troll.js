#pragma strict

public var vida = 1000;

function Start () {

}

function Update () {

	

}

function OnTriggerEnter(col : Collider){

	if(col.gameObject.name == "Flecha(Clone)"){
		vida -= 120;
	}
	if(col.gameObject.name == "stone(Clone)"){
		vida -= 100;

	}
	if(col.gameObject.name == "Lanza(Clone)"){
		vida -= 150;

	}
}

