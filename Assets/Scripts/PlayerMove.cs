using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	public Rigidbody2D playerRigidbody;
	public Animator Anime;
	public bool attack;
	public bool jump;
	public float speed;
	private float x;
	public float jumpTemp;
	public float timeTemp;
	public float timePulo;
	public static int vidaPlayer;
	public int forceJump;
	private int layer;
	private int i;
	private bool sobe;
	private Collider2D C2d; 

	//Verifica o chao
	public Transform GroundCheck;
	public bool Grounded;
	public LayerMask whatIsGround;

	// Use this for initialization
	void Start () {
		C2d = GetComponent<Collider2D> ();
		playerRigidbody = GetComponent<Rigidbody2D> ();
		vidaPlayer = 10;
		layer = 2;
		i = 80;
		sobe = false;
	}


	
	// Update is called once per frame
	void Update () {
		Debug.Log (layer);

		if (Input.GetButton ("Right")) {
			x += speed * Time.deltaTime;
			transform.position = new Vector3(x, transform.position.y, transform.position.z);
		}
		if (Input.GetButton ("Left")) {
			x -= speed * Time.deltaTime;
			transform.position = new Vector3 (x, transform.position.y, transform.position.z);
		}
		if (i >= 80) {
			if (Input.GetButton ("Up") && Grounded && layer != 0) {
				playerRigidbody.AddForce (new Vector2 (0, forceJump));
				Grounded = false;
				C2d.isTrigger = true;
				layer--;
				sobe = true;
				i = 0;

			}
			if (Input.GetButton ("Down") && Grounded && layer != 2) {
				playerRigidbody.AddForce (new Vector2 (0, -forceJump));
				Grounded = false;
				C2d.isTrigger = true;
				layer++;
				sobe = false;
				i = 30;
		
			}
		}

		if (sobe == true) {
			if ((layer * -2) < transform.position.y) {
				C2d.isTrigger = false;
			}
		} else if (sobe == false) {
			if ((layer * -2) > transform.position.y) {
				C2d.isTrigger = false;
			}
		}

		Grounded = Physics2D.OverlapCircle (GroundCheck.position, 0.2f, whatIsGround);

		Anime.SetBool ("jump", !Grounded);
		i++;
		//if (i > 80)
		//	i = 80;
	}
}