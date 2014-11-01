using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private bool forward = false;
	private bool backwards = false;
	private bool rotateRight = false;
	private bool rotateLeft = false;
	private float speed = 10f;
	// Use this for initialization
	void Start () {
		//Debug.Log ("asdsad");
	}
	
	// Update is called once per frame
	void Update () {
		CheckKeyboard ();
		Move ();

	}

	void Move() {
		if (forward) {
			//transform.position += new Vector3(0f, 0f, 10f * Time.deltaTime);
			transform.Translate (0f, 0f, speed * Time.deltaTime);
		}
		
		if (backwards) {
			transform.Translate (0f, 0f, -speed * Time.deltaTime);
		}
		
		if (rotateLeft) {
			transform.Rotate (0f, -10 * speed * Time.deltaTime, 0f);
		}
		
		if (rotateRight) {
			transform.Rotate (0f, 10 * speed * Time.deltaTime, 0f);
		}
	}

	void BindKeyAction (KeyCode key1, KeyCode key2, ref bool variable) {
		if (Input.GetKeyDown (key1) || Input.GetKeyDown (key2)) {
			variable = true;
		}
		else if (Input.GetKeyUp (key1) || Input.GetKeyUp (key2)) {
			variable = false;
		}
	}

	void CheckKeyboard() {
		BindKeyAction (KeyCode.W, KeyCode.UpArrow, ref forward);
		BindKeyAction (KeyCode.S, KeyCode.DownArrow, ref backwards);
		BindKeyAction (KeyCode.D, KeyCode.RightArrow, ref rotateRight);
		BindKeyAction (KeyCode.A, KeyCode.LeftArrow, ref rotateLeft);
	}
}
