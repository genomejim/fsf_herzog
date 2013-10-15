using UnityEngine;
using System.Collections;

public class EnemyShotMovement : MonoBehaviour {
	
	public GameObject enemy_shot;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		enemy_shot = gameObject;
		    enemy_shot.rigidbody.MovePosition(enemy_shot.transform.position + new Vector3(0,0,-1));		
	}
}