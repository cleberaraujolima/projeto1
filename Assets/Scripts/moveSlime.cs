using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveSlime : MonoBehaviour {

	public float speed;
	private float x;
	public static int morte = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		x = transform.position.x;
		x += speed * Time.deltaTime;

		transform.position = new Vector3 (x, transform.position.y, transform.position.z);

		if (x <= -8.9f) {
			Destroy (transform.gameObject);
			PlayerController.vidaPlayer -= 1;
			morte += 1;
		}
		if (morte >= 100) {
			morte = 0;
			SpawnController2.one = 5;
			SpawnController2.one2 = 5;
			SpawnController2.one3 = 5;
		}
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Player")) {
			if (PlayerController.vidaPlayer >= 0) {
				PlayerController.vidaPlayer -= 1;
			}
		}
	}
}
