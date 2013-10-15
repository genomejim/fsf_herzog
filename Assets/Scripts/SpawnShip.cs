using UnityEngine;
using System.Collections;

public class SpawnShip : MonoBehaviour {
	public Transform spaceShipLong;
	//private Vector3 start;	
	private bool ShipIsLaunchable = false;
	// Use this for initialization
	void Start () {
		//start.Set (0,5,-35);
		InvokeRepeating( "MakeShipLaunchable", 3 + Random.value, 4 + Random.value );
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown(KeyCode.E) && ShipIsLaunchable)
		if (ShipIsLaunchable)
		{	
				//Instantiate(spaceShipLong,start,Quaternion.identity);
			Instantiate(spaceShipLong,gameObject.transform.position,Quaternion.identity);
			ShipIsLaunchable = false;
		}
	}
	void MakeShipLaunchable () 
	{
		ShipIsLaunchable = true;
	}
}
