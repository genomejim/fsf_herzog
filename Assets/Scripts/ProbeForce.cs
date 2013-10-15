using UnityEngine;
using System.Collections;

public class ProbeForce : MonoBehaviour {

	public GameObject Probe;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Probe = gameObject;
		//Debug.Log (ship.name);
		
			Probe.rigidbody.AddForce(0,9.6f,0);
			Probe.rigidbody.AddRelativeForce(0,0,-9);
			Probe.rigidbody.AddRelativeTorque(-.004f,0,0);
			//Debug.Log ("adding Force");					
	}
}
