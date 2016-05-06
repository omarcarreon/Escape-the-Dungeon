var target : Transform; //drag player here in inspector
var Distance;
var chaseDistance : float = 3.0f;
var closeStopDistance : float = 0.65f;
 
 
var agent: NavMeshAgent; //drag navmesh enemy here in inspector
 
function Start(){
 
}
 
 
function Update()
{
 
     Distance = Vector3.Distance(target.position, transform.position);
     //Debug.Log(Distance);

     //Atacar
     if (Distance < closeStopDistance){
         agent.Stop();
         if (!this.GetComponent.<Animation>().IsPlaying("attack2")){
         	this.GetComponent.<Animation>().Play("attack2");
         }
     }
     //estoy caminando
     else if (Distance < chaseDistance){
     	if (!this.GetComponent.<Animation>().IsPlaying("walk")){
         	this.GetComponent.<Animation>().Play("walk");
         }
 		agent.Resume();
 		agent.speed = 1.0f;
        agent.SetDestination(target.position);

     }
     else{

     	if(this.GetComponent.<troll>().vida <= 0){
     		if (!this.GetComponent.<Animation>().IsPlaying("die")){
         		this.GetComponent.<Animation>().Play("die");
         		Destroy(this.gameObject, 2);
         	}
     	}
     	else{
     		if (!this.GetComponent.<Animation>().IsPlaying("idle")){
         		this.GetComponent.<Animation>().Play("idle");
         	}
         }
     }


         
 
}