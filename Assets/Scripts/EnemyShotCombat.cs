using UnityEngine;
using System.Collections;

public class EnemyShotCombat : MonoBehaviour {
	
	
	public Transform explosion;
	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}
	void OnTriggerEnter (Collider other) {
        //Debug.Log ("shots hitting " + other.gameObject.name);
		if (other.gameObject.name == "Trooper(Clone)") 
		{
			//Debug.Log("trooper collision");
			//Debug.Log ("shots hitting " + other.gameObject.name);
			other.gameObject.SetActive(false);
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
			Destroy(other);
			gameObject.SetActive(false);
			Destroy(gameObject);
		}
		else if (other.gameObject.name == "player_dish")
		{
			//Debug.Log("player dish collision");
			//Debug.Log ("shots hitting " + other.gameObject.name);
			gameObject.SetActive(false);
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
			Destroy(gameObject);
		}
		else
		{
			//Debug.Log ("shots hitting in else case " + other.gameObject.name);
			if (other.gameObject.name != "Enemy(Clone)")
			{
				Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
				gameObject.SetActive(false);
				Destroy(gameObject);
			}
		}
	}
	
}