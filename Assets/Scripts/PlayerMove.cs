using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public Rigidbody2D playerRigidbody;
	public Animator Anime;
	public bool attack;
	public float speed;
	private float x;
	public float attackTemp;
	public float timeTemp;
	public float timePulo;
	public static int vidaPlayer;
	public int forceJump;
	private int layer;
	private bool sobe;
	private Collider2D C2d; 

	//Verifica o chao
	public Transform GroundCheck;
	public bool Grounded;
	public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
		C2d = GetComponent<Collider2D> ();
		vidaPlayer = 10;
		layer = 2;
		sobe = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Right")) {
			x += speed * Time.deltaTime;
			transform.position = new Vector3(x, transform.position.y, transform.position.z);
		}
		if (Input.GetButton ("Left")) {
			x -= speed * Time.deltaTime;
			transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		}
		if (Input.GetButtonDown ("Up") && Grounded && layer != 0) {
			playerRigidbody.AddForce(new Vector2(0, forceJump));
			Grounded = false;
			C2d.isTrigger = true;
			layer--;
			sobe = true;

		}
		if (Input.GetButtonDown ("Down") && Grounded && layer != 2) {
			playerRigidbody.AddForce(new Vector2(0, -forceJump));
			Grounded = false;
			C2d.isTrigger = true;
			layer++;
			sobe = false;

		}

		Grounded = Physics2D.OverlapCircle (GroundCheck.position, 0.2f, whatIsGround);

		Anime.SetBool ("jump", !Grounded);

		if (sobe == false) {
			if ((layer * -2) > transform.position.y) {
				C2d.isTrigger = false;
			} else {
				if ((layer * -2) < transform.position.y) {
					C2d.isTrigger = false;
		}
	}
}
