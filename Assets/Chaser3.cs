using UnityEngine;
using System.Collections;

public class Chaser3 : MonoBehaviour {
	public Transform Aim;
	private float speed = 4f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (Aim.position);
		
		float dist = Vector3.Distance (transform.position, Aim.transform.position);
		if (dist > 1f) {
			transform.Translate (0f, 0f, speed * Time.deltaTime);
		}
	}
}
