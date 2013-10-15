using UnityEngine;
using System.Collections;

public class TrooperShotMovement : MonoBehaviour {
	
	public GameObject trooper_shot;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		trooper_shot = gameObject;		
		    trooper_shot.rigidbody.MovePosition(trooper_shot.transform.position + new Vector3(0,0,1));							
	}
}