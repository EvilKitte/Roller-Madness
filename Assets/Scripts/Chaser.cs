using UnityEngine;
using System.Collections;

//[RequireComponent(typeof(CharacterController))]

public class Chaser : MonoBehaviour {
	
	public float speed = 20.0f;
	public float minDist = 1f;
	public Transform target;

	// Use this for initialization
	void Start () 
	{
		if (target == null) {

			if (GameObject.FindWithTag ("Player")!=null)
			{
				target = GameObject.FindWithTag ("Player").GetComponent<Transform>();
			}
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (target == null)
			return;

		transform.LookAt(target);

		float distance = Vector3.Distance(transform.position,target.position);

		if(distance > minDist)	
			transform.position += transform.forward * speed * Time.deltaTime;	
	}

	public void SetTarget(Transform newTarget)
	{
		target = newTarget;
	}

}
