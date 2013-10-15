using UnityEngine;
using System.Collections;

public class TrooperShotCombat : MonoBehaviour {
	
	
	//public Transform Flame;
	public Transform explosion;
	//public Transform enemy_shot;
	//public Vector3 enemy_shot_start;
	//private GameObject trooper;
	// Use this for initialization
	void Start () {
	//InvokeRepeating( "shoot", 3, 3 );
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}
	void OnTriggerEnter (Collider other) {
        //Debug.Log ("shots hitting " + other.gameObject.name);
		if (other.gameObject.name == "Enemy(Clone)") 
		{
			//Debug.Log("trooper collision");
			//Debug.Log ("shots hitting " + other.gameObject.name);
			other.gameObject.SetActive(false);
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
			Destroy(other);
			gameObject.SetActive(false);
			Destroy(gameObject);
		}
		else if (other.gameObject.name == "enemy_dish")
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
			if (other.gameObject.name != "Trooper(Clone)")
			{
				Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
				gameObject.SetActive(false);
				Destroy(gameObject);
			}
		}
	}
	
}