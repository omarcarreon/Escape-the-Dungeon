#pragma strict

import UnityEngine.UI;

//Variables
var txt: UI.Text;

function Start () {
	txt.text = "";
}

function OnTriggerEnter(col : Collider){
	if(col.gameObject.name == "male_04"){
		txt.text = "Henry, por favor ayudame a recuperar a mi hija, entra en la mazmorra y trae a mi Elizabeth de vuelta. Ten en cuenta que adentro hay horrendas criaturas que son peligrosas, pero un valiente como tú podrá traer a mi hija de vuelta.";
	}
}

function OnTriggerExit(col: Collider){
	if(col.gameObject.name == "male_04"){
		txt.text = "";
	}
}