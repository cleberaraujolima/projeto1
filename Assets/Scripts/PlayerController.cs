using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public Animator Anime;
	public bool attack;
	public float speed;
	private float x;
	private float y;
	private float z1 = 1;
	private float z2 = 0;
	private float z3 = 3;
	private float x1 = -0.03f;
	private float y1 = 0.05f;
	private float y2 = 10;
	public float attackTemp;
	public float timeTemp;
	public Transform gameover;
	public Transform pot1;
	public Transform pot2;
	public Transform pot3;
	public static int vidaPlayer;
	public UnityEngine.UI.Text txtRecorde;
	public UnityEngine.UI.Text txtVidaBoss1;
	public UnityEngine.UI.Text txtVidaBoss2;
	public UnityEngine.UI.Text txtVidaBoss3;
	public UnityEngine.UI.Text txtVida;

	// Use this for initialization
	void Start () {
		vidaPlayer = 10;
		PlayerAttack.pontuacao = 0;
		PlayerPrefs.SetInt ("pontuacao", PlayerAttack.pontuacao);
	}
	
	// Update is called once per frame
	void Update () {

		txtVidaBoss1.text = moveBoss1.vidaBoss1.ToString ();
		txtVidaBoss2.text = moveBoss2.vidaBoss2.ToString ();
		txtVidaBoss3.text = moveBoss3.vidaBoss3.ToString ();
		txtVida.text = vidaPlayer.ToString();
		PlayerPrefs.SetInt ("pontuacao", PlayerAttack.pontuacao);

		x = transform.position.x;
		y = transform.position.y;

		if (Input.GetButton ("Right") && x <= 7) {
			x += speed * Time.deltaTime;
			transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		}
		if (Input.GetButton ("Left") && x >= -7.80f) {
			x -= speed * Time.deltaTime;
			transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		}
		if (Input.GetButton ("Up") && y <= 2.60f) {
			y += speed * Time.deltaTime;
			transform.position = new Vector3 (transform.position.x, y, transform.position.z);
		}
		if (Input.GetButton ("Down") && y >= -4.24f) {
			y -= speed * Time.deltaTime;
			transform.position = new Vector3 (transform.position.x, y, transform.position.z);
		}
		if (Input.GetButtonDown ("Attack")) {
			attack = true;
			timeTemp = 0;
		}
		if (attack == true) {
			timeTemp += Time.deltaTime;
			if (timeTemp >= attackTemp) {
				attack = false;
			}
		}
		if (moveBoss1.especial == 1) {
			pot1.transform.position = new Vector3 (pot1.transform.position.x, pot1.transform.position.y, z2);
		} else if (moveBoss1.especial == 2) {
			pot2.transform.position = new Vector3 (pot2.transform.position.x, pot2.transform.position.y, z2);
			pot1.transform.position = new Vector3 (pot1.transform.position.x, pot1.transform.position.y, z3);
		} else if (moveBoss1.especial == 3) {
			pot3.transform.position = new Vector3 (pot3.transform.position.x, pot3.transform.position.y, z2);
			pot2.transform.position = new Vector3 (pot2.transform.position.x, pot2.transform.position.y, z3);
		}
		if (moveBoss1.especial > 3) {
			moveBoss1.especial = 3;
		}
		if (vidaPlayer > 0 && moveBoss1.especial == 3 && Input.GetButtonDown ("Especial")) {
			if (SceneManager.GetActiveScene ().buildIndex == 2) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 4);
			} else if (SceneManager.GetActiveScene ().buildIndex == 4) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 2);
			} else if (SceneManager.GetActiveScene ().buildIndex == 5) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			}
		}
		if (vidaPlayer <= 0) {
			gameover.transform.position = new Vector3 (x1, y1, z1);
			transform.position = new Vector3 (transform.position.x, y2, transform.position.z);
			txtRecorde.text = PlayerPrefs.GetInt ("recorde").ToString ();
			if (PlayerAttack.pontuacao > PlayerPrefs.GetInt("recorde")) {
				PlayerPrefs.SetInt ("recorde", PlayerAttack.pontuacao);
			}
			if (Input.GetMouseButtonDown (0)) {
				Destroy (transform.gameObject);
				moveSlime.morte = 0;
				SpawnController2.one = 5;
				SpawnController2.one2 = 5;
				SpawnController2.one3 = 5;
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0);
			}
		}
	
		Anime.SetBool ("attack", attack);
	}
}
