using UnityEngine;
using System.Collections;

public class TrooperCombat : MonoBehaviour {
	
	
	//public Transform Flame;
	public Transform explosion;
	public Transform trooper_shot;
	//private GameObject trooper;
	// Use this for initialization
	void Start () {
		//InvokeRepeating( "shoot",  Random.value, 3 + Random.value );
		InvokeRepeating( "shoot", .3f, 3 + Random.value * 3 - 2);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}
	
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.name == "Enemy(Clone)") 
		{
			other.gameObject.SetActive(false);
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
			Destroy(other);
		}
	}
	
	void shoot ()
	{
		if (gameObject.activeInHierarchy == true) 
		{
//			Debug.Log ("trooper trying to shoot");
			Instantiate (trooper_shot,gameObject.transform.position + new Vector3(0,1,0),Quaternion.Euler(90,0,0));
		}	
		
	}
}