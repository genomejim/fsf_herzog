using UnityEngine;
using System.Collections;

public class ShipForce : MonoBehaviour {

	public GameObject ship;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		ship = gameObject;
		//Debug.Log (ship.name);
		
			ship.rigidbody.AddForce(0,19.85f,0);
			ship.rigidbody.AddRelativeForce(0,0,9);
			ship.rigidbody.AddRelativeTorque(-.005f,0,0);
			//Debug.Log ("adding Force");					
	}
}
