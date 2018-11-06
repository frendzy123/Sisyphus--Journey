using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour {

	public GameObject player;
	public GameObject boulder;
	private Vector3 offset;
	private Camera mainCamera;
	private bool cameraChange = false;
	private int zoomIn = 0;
	private int zoomOut = 0;
	private int wait = 0;


	// Use this for initialization
	void Start () {
		mainCamera = gameObject.GetComponent<Camera>();
		offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if(boulder.transform.position.x >= 8.5) {
			cameraChange = true;
		}
	}

	void FixedUpdate() {
		if(cameraChange) {
			if(zoomOut < 850) {
				zoomOut++;
				mainCamera.orthographicSize += 0.01f;
			}
			else if(wait < 100) {
				wait++;
			}
			else if (zoomIn < 850) {
				zoomIn++;
				mainCamera.orthographicSize -= 0.01f;
			}
			else {
				cameraChange = false;
				wait = 0;
			}
		}
	}

	void LateUpdate() {
		transform.position = player.transform.position + offset;
	}
}
