using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {
	public static int pontuacao;
	public UnityEngine.UI.Text txtPontos;
	public UnityEngine.UI.Text txtPontos2;
	public AudioSource audio;
	public AudioClip soundHit;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		txtPontos.text = PlayerPrefs.GetInt ("pontuacao").ToString ();
		txtPontos2.text = PlayerPrefs.GetInt ("pontuacao").ToString ();
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("Slime")) {
			audio.PlayOneShot (soundHit);
			pontuacao += 10;
			moveSlime.morte += 1;
			Destroy (other.gameObject);
		}
		if (other.gameObject.CompareTag ("Boss1")) {
			if (moveBoss1.vidaBoss1 >= 0) {
				moveBoss1.vidaBoss1 -= 1;
				audio.PlayOneShot (soundHit);
			}
		}
		if (other.gameObject.CompareTag ("Boss2")) {
			if (moveBoss2.vidaBoss2 >= 0) {
				moveBoss2.vidaBoss2 -= 1;
				audio.PlayOneShot (soundHit);
			}
		}
		if (other.gameObject.CompareTag ("Boss3")) {
			if (moveBoss3.vidaBoss3 >= 0) {
				moveBoss3.vidaBoss3 -= 1;
				audio.PlayOneShot (soundHit);
			}
		}
	}
}
