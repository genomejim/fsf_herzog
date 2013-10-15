using UnityEngine;
using System.Collections;

public class ProbeCombat : MonoBehaviour {
	
	
	public Transform explosion;
	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}
	void OnTriggerEnter (Collider other) {
        //Debug.Log ("shots hitting " + other.gameObject.name);
		if (other.gameObject.name == "spaceShipLong(Clone)") 
		{
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
		}
		else if (other.gameObject.name == "player_dish")
		{
			gameObject.SetActive(false);
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
			Destroy(gameObject);
		}
		else
		{
		}
	}
}