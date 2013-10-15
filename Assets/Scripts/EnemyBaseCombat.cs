using UnityEngine;
using System.Collections;

public class EnemyBaseCombat : MonoBehaviour {
	
	public int EnemyDishHealth;
	public GUIText health;	
//	private GameObject enemy_dish;
	public Transform Flame;
	public Transform explosion;
	// Use this for initialization
	void Start () {
		EnemyDishHealth = 100;
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
			EnemyDishHealth = EnemyDishHealth -1;
			health.text = "dish health = " + EnemyDishHealth;
			Instantiate(explosion,gameObject.transform.position,Quaternion.identity);
		}
		else if (other.gameObject.name == "spaceShipLong(Clone)")
		{
		//	Debug.Log ("space ship collision");
			other.gameObject.SetActive(false);
			EnemyDishHealth = EnemyDishHealth - 5;
			health.text = "dish health = " + EnemyDishHealth;
			Instantiate(explosion,other.gameObject.transform.position,Quaternion.identity);
			Instantiate(Flame,gameObject.transform.position,Quaternion.identity);
			
		}
		if (EnemyDishHealth <=0)
		{
			gameObject.SetActive(false);	
			Instantiate(Flame,gameObject.transform.position,Quaternion.identity);
			Destroy(gameObject);
		}
	}
}