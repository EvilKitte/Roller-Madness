using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {
	public float moveSpeed = 5f;
	public GameObject[] myWaypoints;
	private int myWaypointId = 0;
	
	
	void EnemyMovement() {
		if(myWaypoints.Length != 0) {
			if(Vector3.Distance(myWaypoints[myWaypointId].transform.position, transform.position) <= 0) {
				myWaypointId++;
			}
			
			if(myWaypointId >= myWaypoints.Length) {
				myWaypointId = 0;
			}
			
			transform.position = Vector3.MoveTowards(transform.position, myWaypoints[myWaypointId].transform.position, moveSpeed * Time.deltaTime);
		}
	}
	
	// Update is called once per frame
	void Update () {
		EnemyMovement();
	}
}