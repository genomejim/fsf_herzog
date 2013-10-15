 /// <summary>
/// 
/// </summary>

using UnityEngine;
using System;
using System.Collections;
  
[RequireComponent(typeof(Animator))]  

//Name of class must be name of file as well


public class EnemyMovement : MonoBehaviour {

    protected Animator animator;
	
    public float speed = 8 + UnityEngine.Random.value;
    public float direction = 0;
    private Locomotion locomotion = null;
	public float direction_first_half;
	public float direction_second_half;
	private float direction_random = UnityEngine.Random.value * 20;
	// Use this for initialization
	void Start () 
	{
        animator = GetComponent<Animator>();
        locomotion = new Locomotion(animator);
		//direction_first_half = direction + direction_random;
		//direction_second_half = direction - direction_random;

	}
	
	
	void Update () 
	{
        if (animator)
		{
			//if (gameObject.transform.position.z < 0)
			//{
			//	direction = direction_first_half;
				
			//}
			//else
			//{
				
			//	direction = direction_second_half;
			//}
			locomotion.Do(speed * 6, direction);
		}		
	}
}
