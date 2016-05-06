using UnityEngine;
using System.Collections;

public class lookAtMe : MonoBehaviour {

	public Transform target;

	// Use this for initialization
	void Start () {
		Vector3 targetPostition = new Vector3(target.position.x, this.transform.position.y, target.position.z ) ;
		transform.LookAt(targetPostition);
	}

	// Update is called once per frame
	void Update () {
		Vector3 targetPostition = new Vector3(target.position.x, this.transform.position.y, target.position.z ) ;
		transform.LookAt(targetPostition);
	}
}
