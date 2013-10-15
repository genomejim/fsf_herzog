using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
	public Transform Enemy;
	private Vector3 EnemyStart;
	void Start () 
	{
		//EnemyStart.Set(0,0,38);
		InvokeRepeating( "spawn", 3, 1 );
	}
	
	void spawn ()
	{
//		Debug.Log ("spawning enemy");
		//Instantiate (Enemy,EnemyStart,Quaternion.Euler(0,180,0));
		Instantiate (Enemy,gameObject.transform.position,Quaternion.Euler(0,180 + Random.value * 10 -5 ,0));
	}
}