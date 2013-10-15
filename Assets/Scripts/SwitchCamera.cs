using UnityEngine;
using System.Collections;

public class SwitchCamera : MonoBehaviour {
	public Camera cam1;
	public Camera cam2;
	public Camera cam3;
	// Use this for initialization
	void Start () {
		cam1.enabled = true;
		cam2.enabled = false;
		cam3.enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.C))
		{
			Debug.Log ("detected camera key");
			if (cam1.enabled) 
			{
				cam1.enabled = false;
				cam2.enabled = true;
				cam3.enabled = false;
			}
			else if (cam2.enabled)			{
				cam2.enabled = false;
				cam3.enabled = true;
				cam1.enabled = false;
			}
			else 
			{
				cam3.enabled = false;
				cam2.enabled = false;
				cam1.enabled = true;
			}
		}
	}
}
