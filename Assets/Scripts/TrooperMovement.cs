 /// <summary>
/// 
/// </summary>

using UnityEngine;
using System;
using System.Collections;
  
[RequireComponent(typeof(Animator))]  

//Name of class must be name of file as well


public class TrooperMovement : MonoBehaviour {

    protected Animator animator;
	
	public float speed = 8;
    public float direction = 0;
	private Locomotion locomotion = null;

	// Use this for initialization
	void Start () 
	{
        animator = GetComponent<Animator>();
        locomotion = new Locomotion(animator);
	}
	
	
	void Update () 
	{
        if (animator)
		{
			locomotion.Do(speed * 6, direction);
		}		
	}
}
