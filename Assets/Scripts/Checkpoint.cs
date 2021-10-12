using UnityEngine;
using System.Collections;

public class Checkpoint : MonoBehaviour {
	
	void OnTriggerEnter(Collider collision) 
	{
		if ((collision.gameObject.tag == "Player") && (collision.gameObject.GetComponent<Health> () != null))
		{
			collision.gameObject.GetComponent<Health>().updateRespawn(collision.gameObject.transform.position, collision.gameObject.transform.rotation);
		}
	}
}
