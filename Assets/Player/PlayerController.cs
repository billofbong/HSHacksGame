using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float playerSpeed = 1;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		transform.Translate(movement * Time.deltaTime * playerSpeed);

		if(Input.GetAxisRaw("Horizontal") == -1) {
			transform.localScale = new Vector2(-1, 1);
		}
		if(Input.GetAxisRaw("Horizontal") == 1) {
			transform.localScale = new Vector2(1, 1);
		}
	}
}
