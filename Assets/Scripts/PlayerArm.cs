using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArm : MonoBehaviour {

	GameObject boulder;


	// Use this for initialization
	void Start () {
		boulder = GameObject.Find("Boulder");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerStay2D(Collider2D col) {
		if(col.gameObject == boulder) {
			Debug.Log(gameObject.transform.rotation);
			if(Input.GetMouseButtonDown(0)) {
				//boulder.GetComponent<Rigidbody2D>().AddForceAtPosition(pushZone.transform.position, new Vector3(1, 0, 0) * 100);
				if(gameObject.transform.rotation.z <= 0.3) {
					boulder.GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 0, 0) * 100);
				}	
				else if(gameObject.transform.rotation.z <= 0.6) {
					boulder.GetComponent<Rigidbody2D>().AddForce(new Vector3(1, 1, 0) * 100);
				}
				else if(gameObject.transform.rotation.z <= 1) {
					boulder.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, 1, 0) * 100);
				}
			}
		}
	}
}
