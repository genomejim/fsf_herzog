using UnityEngine;
using System.Collections;

public class SpawnEnemyOutpost : MonoBehaviour {
	public Transform EnemyOutpost;
	private Vector3 OutpostStartPos;
	//private bool PlaceBaseLeft;
	public int EnemyOutpostCount;
	void Start () {
		
		OutpostStartPos.Set (15,0,20);
		EnemyOutpostCount = 0;
		InvokeRepeating( "spawn", 20, 20 );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void spawn ()
	{
		if (EnemyOutpostCount < 2)
		{
			Debug.Log ("In Enemy Outpost Spawn");
			//spawn ();
			//OutpostStartPos.Set (OutpostStartPos.x - 15 , 0 , OutpostStartPos.z );
			EnemyOutpostCount++;
			Instantiate (EnemyOutpost,OutpostStartPos,Quaternion.Euler(0,0,0));
			OutpostStartPos.Set (OutpostStartPos.x - 30 , 0 , OutpostStartPos.z );	
		}
	}

}