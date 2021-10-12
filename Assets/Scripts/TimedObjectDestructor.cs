using UnityEngine;
using System.Collections;

public class TimedObjectDestructor : MonoBehaviour {

	public float timeOut = 1.0f;
	public bool detachChildren = false;

	// Use this for initialization
	void Awake () {
		Invoke ("DestroyNow", timeOut);
	}
	
	void Update () {
	
	}
	
	void DestroyNow ()
	{
		if (detachChildren) {
			transform.DetachChildren ();
		}
		DestroyObject (gameObject);
	}
}
