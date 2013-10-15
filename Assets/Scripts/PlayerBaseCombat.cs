using UnityEngine;
using System.Collections;

public class PlayerBaseCombat : MonoBehaviour {
	
	
	public Transform explosion;
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}
	void OnTriggerEnter (Collider other) {
		//Debug.Log (other.gameObject.name);
		if (other.gameObject.name == "Enemy(Clone)") 
		{
//			Debug.Log("trooper collision");
			other.gameObject.SetActive(false);
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
			Destroy(other);
		}		
	}
}