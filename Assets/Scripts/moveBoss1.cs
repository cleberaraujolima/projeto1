using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBoss1 : MonoBehaviour {

	public float speed;
	private float x;
	public static int vidaBoss1;
	public static int especial;

	// Use this for initialization
	void Start () {
		vidaBoss1 = 3; //50
	}
	
	// Update is called once per frame
	void Update () {
		x = transform.position.x;
		x += speed * Time.deltaTime;

		transform.position = new Vector3 (x, transform.position.y, transform.position.z);

		if (x <= -9.75f) {
			Destroy (transform.gameObject);
			PlayerController.vidaPlayer = 0;
		}
		if (vidaBoss1 <= 0) {
			PlayerAttack.pontuacao += 100;
			Destroy (transform.gameObject);
			if (especial < 4) {
				especial += 1;
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
