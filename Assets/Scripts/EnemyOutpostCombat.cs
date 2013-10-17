using UnityEngine;
using System.Collections;

public class EnemyOutpostCombat : MonoBehaviour {
	
	public int EnemyOutpostHealth;	
	public Transform Flame;
	public Transform explosion;
	// Use this for initialization
	void Start () {
		EnemyOutpostHealth = 50;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
	
	}
	void OnTriggerEnter (Collider other) {
		//Debug.Log ("other name " + other.name);
		//Debug.Log ("other tag " + other.gameObject.tag);
		if (other.gameObject.name == "Trooper(Clone)") 
		{
			other.gameObject.SetActive(false);
			EnemyOutpostHealth -= 1;
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
		}
		else if (other.gameObject.name == "spaceShipLong(Clone)")
		{
		//	Debug.Log ("space ship collision");
			other.gameObject.SetActive(false);
			EnemyOutpostHealth -= 5;
			//health.text = "dish health = " + EnemyDishHealth;
			Instantiate(explosion,other.gameObject.transform.position,Quaternion.identity);
			Instantiate(Flame,gameObject.transform.position,Quaternion.identity);
			
		}
		if (EnemyOutpostHealth <=0)
		{
			gameObject.SetActive(false);	
			Instantiate(Flame,gameObject.transform.position,Quaternion.identity);
			Destroy(gameObject);
		}
	}
}