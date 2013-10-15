using UnityEngine;
using System.Collections;

public class EnemyCombat : MonoBehaviour {
	
	
	//public Transform Flame;
	public Transform explosion;
	public Transform enemy_shot;
	//public Vector3 enemy_shot_start;
	//private GameObject trooper;
	// Use this for initialization
	void Start () {
		//InvokeRepeating( "shoot", 3 + Random.value, 3 + Random.value );
		//InvokeRepeating( "shoot", .3f, 3);
		InvokeRepeating( "shoot", .3f, 3 + Random.value * 3 - 2);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}
	void OnTriggerEnter (Collider other) {
		//Debug.Log (other.gameObject.name);
		if (other.gameObject.name == "Trooper(Clone)") 
		{
			//Debug.Log("trooper collision");
			other.gameObject.SetActive(false);
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
			Destroy(other);
		}
		else if (other.gameObject.name == "player_dish)")
		{
			//Debug.Log("player dish collision");
			gameObject.SetActive(false);
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
			Destroy(gameObject);
		}
		else
		{
		}
	}
	void shoot ()
	{
		if (gameObject.activeInHierarchy == true) 
		{
			//Debug.Log ("firing enemy shot");
			Instantiate (enemy_shot,gameObject.transform.position + new Vector3(0,1,0),Quaternion.Euler(90,0,0));
		}	
		
	}
}