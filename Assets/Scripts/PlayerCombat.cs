using UnityEngine;
using System.Collections;

public class PlayerCombat : MonoBehaviour {
	
	
	//public Transform Flame;
	public Transform explosion;
	//private GameObject trooper;
	// Use this for initialization
	void Start () {
	
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
}