using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

	Color color;
	SpriteRenderer renderer;
	int day = 0;

	// Use this for initialization
	void Start () {
		renderer = gameObject.GetComponent<SpriteRenderer>();
		color = renderer.color;
	}
	
	// Update is called once per frame
	void Update () {
		if(day == 0) {
			if(color.r <= 0.6 && color.r - 0.005f >= 0) {
				color.r -= 0.0005f;
				renderer.color = color;
			}
			else if(color.g <= 1 && color.g - 0.005f >= 0) {
				color.g -= 0.0005f;
				renderer.color = color;
			}
			else if(color.b <= 1 && color.b - 0.005f >= 0) {
				color.b -= 0.0005f;
				renderer.color = color;
			}
			else {
				day = 1;
			}
		}
		else {
			if(color.b >= 0 && color.g + 0.005f <= 1) {
				color.b += 0.0005f;
				renderer.color = color;
			}
			else if(color.g >= 0 && color.g + 0.005f <= 1) {
				color.g += 0.0005f;
				renderer.color = color;
			}
			else if(color.r >= 0 && color.r + 0.005f <= 0.6) {
				color.r += 0.0005f;
				renderer.color = color;
			}
			else {
				day = 0;
			}
		}

	}
}
