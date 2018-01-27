using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tela : MonoBehaviour {
	public UnityEngine.UI.Text txtPontuacao1;
	public UnityEngine.UI.Text txtPontuacao2;
	public UnityEngine.UI.Image imgVida;
	public UnityEngine.UI.Text txtVida;
	public UnityEngine.UI.Text txtClique;
	public UnityEngine.UI.Text txtRecorde1;
	public UnityEngine.UI.Text txtRecorde2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerController.vidaPlayer > 0) {
			txtPontuacao1.enabled = false;
			txtPontuacao2.enabled = false;
			txtRecorde1.enabled = false;
			txtRecorde2.enabled = false;
			txtClique.enabled = false;
			imgVida.enabled = true;
			txtVida.enabled = true;
		} else if (PlayerController.vidaPlayer <= 0) {
			txtPontuacao1.enabled = true;
			txtPontuacao2.enabled = true;
			txtRecorde1.enabled = true;
			txtRecorde2.enabled = true;
			txtClique.enabled = true;
			imgVida.enabled = false;
			txtVida.enabled = false;
		}
	}
}
