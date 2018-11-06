using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.transform.position.x >= 8.8) {
			gameObject.transform.position = new Vector3(-8, gameObject.transform.position.y, gameObject.transform.position.z);
		}
	}
}
