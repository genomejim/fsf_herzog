using UnityEngine;
using System.Collections;

public class SpawnProbe : MonoBehaviour {
	public Transform Probe;
	private Vector3 start;	
	private bool ProbeIsLaunchable = false;
	// Use this for initialization
	void Start () {
//		start.Set (0,6,34);
		InvokeRepeating( "MakeProbeLaunchable", 3 + Random.value, 4 + Random.value );
	}
	
	// Update is called once per frame
	void Update () {
		if (ProbeIsLaunchable)
		{	
			Debug.Log ("attempting to launch probe");
			//Instantiate(Probe,start,Quaternion.Euler(0,0,0));
			Instantiate(Probe,gameObject.transform.position + new Vector3(0,6,0),Quaternion.Euler(0,0,0));
			ProbeIsLaunchable = false;
		}
	}
	void MakeProbeLaunchable () 
	{
		ProbeIsLaunchable = true;
	}
}
