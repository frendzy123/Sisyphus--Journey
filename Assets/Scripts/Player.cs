using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	List<GameObject> children = new List<GameObject>();
	GameObject boulder;
	GameObject pushZone;
	public float speed = 0.01f;
	// Use this for initialization
	void Start () {
		foreach(Transform child in transform) {
			children.Add(child.gameObject);
		}

		 boulder = GameObject.Find("Boulder");
		 pushZone = GameObject.Find("Push Zone");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("d")) {
			gameObject.transform.position = new Vector3( gameObject.transform.position.x + speed,
														 gameObject.transform.position.y, 
														 gameObject.transform.position.z);
		}

		if(Input.GetKey("a")) {
			gameObject.transform.position = new Vector3( gameObject.transform.position.x - speed,
														 gameObject.transform.position.y, 
														 gameObject.transform.position.z);
		}

		if(Input.GetKeyDown("w")) {
			/*gameObject.transform.position = new Vector3( gameObject.transform.position.x - speed,
														 gameObject.transform.position.y, 
														 gameObject.transform.position.z);*/

			gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 300);

		}

		 Vector3 mousePos = Input.mousePosition;
         mousePos.z = 5.23f;
 
         Vector3 objectPos = Camera.main.WorldToScreenPoint (children[1].transform.position);
         mousePos.x = mousePos.x - objectPos.x;
         mousePos.y = mousePos.y - objectPos.y;
 
         float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
         children[1].transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
	}
}
