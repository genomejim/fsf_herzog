using UnityEngine;
using System.Collections;

public class SpawnBase : MonoBehaviour {
	public Transform Base;
	private Vector3 BaseStartPos;
	//private bool PlaceBaseLeft;
	public int PlayerOutpostCount;
	void Start () {
		
		BaseStartPos.Set (15,0,-60);
		PlayerOutpostCount = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space) && PlayerOutpostCount < 2)
		{	
			Debug.Log ("In Base Spawn");
			spawn ();
			BaseStartPos.Set (BaseStartPos.x - 30 , 0 , BaseStartPos.z );
			PlayerOutpostCount++;
		}
	}
	void spawn ()
	{
		Instantiate (Base,BaseStartPos,Quaternion.Euler(0,180,0));		
	}

}