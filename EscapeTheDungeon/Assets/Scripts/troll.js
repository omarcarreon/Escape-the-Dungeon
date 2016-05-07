#pragma strict

public var vida = 1000;

function Start () {

}

function Update () {

	

}

function OnTriggerEnter(col : Collider){

	if(col.gameObject.name == "Flecha(Clone)"){
		vida -= 320;
		Destroy(col.gameObject);
	}
	if(col.gameObject.name == "stone(Clone)"){
		vida -= 200;
		Destroy(col.gameObject);
	}
	if(col.gameObject.name == "Lanza(Clone)"){
		vida -= 550;
		Destroy(col.gameObject);
	}
}

