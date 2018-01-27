using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBoss2 : MonoBehaviour {

	public float speed;
	private float x;
	public static int vidaBoss2;

	// Use this for initialization
	void Start () {
		vidaBoss2 = 3; //35
	}
	
	// Update is called once per frame
	void Update () {
		x = transform.position.x;
		x += speed * Time.deltaTime;

		transform.position = new Vector3 (x, transform.position.y, transform.position.z);

		if (x <= -9.48f) {
			Destroy (transform.gameObject);
			PlayerController.vidaPlayer = 0;
		}
		if (vidaBoss2 <= 0) {
			PlayerAttack.pontuacao += 100;
			Destroy (transform.gameObject);
			if (moveBoss1.especial < 4) {
				moveBoss1.especial += 1;
			}
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
