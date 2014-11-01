using UnityEngine;
using System.Collections;

public class chaser1 : MonoBehaviour {
	public Transform AimPlayer;
	private float speed = 8f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (AimPlayer.position);

		float dist = Vector3.Distance (transform.position, AimPlayer.transform.position);
		if (dist > 1f) {
			transform.Translate (0f, 0f, speed * Time.deltaTime);
		}

	}
}
