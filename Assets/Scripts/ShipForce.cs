using UnityEngine;
using System.Collections;

public class ShipForce : MonoBehaviour {

	public GameObject Ship;
	public float ShipClimbAngle;
	public float ShipAbsoluteLift;
	// Use this for initialization
	void Start () {
		ShipClimbAngle = -.001f;
		ShipAbsoluteLift = 19.35f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Ship = gameObject;
		//Debug.Log (ship.name);
		
			Ship.rigidbody.AddForce(0,ShipAbsoluteLift,0);
			Ship.rigidbody.AddRelativeForce(0,0,9);
			Ship.rigidbody.AddRelativeTorque(ShipClimbAngle,0,0);
			//Debug.Log ("adding Force");					
	}
}
