using UnityEngine;
using System.Collections;

public class SpawnTrooper : MonoBehaviour {
	public Transform Trooper;
	//private Vector3 UnitStart;
//	private Vector3 UnitStart2;
	// Use this for initialization
	void Start () {
//		UnitStart.Set (Random.value,0,-38);
//		UnitStart2.Set (Random.value,0,-38);
		InvokeRepeating( "spawn", 3, 3 );
	}
	
	// Update is called once per frame
	void Update () {

		//if (Input.GetKeyDown(KeyCode.Space))
		//{	
		//	Instantiate(Unit,UnitStart,Quaternion.identity);
		//}
	}
	void spawn ()
	{
		Instantiate (Trooper,gameObject.transform.position,Quaternion.Euler(0, Random.value * 10 - 5 ,0));
//		Instantiate (Unit,UnitStart2,Quaternion.identity);
		
	}

}