using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseClick5 : MonoBehaviour {

	public UnityEngine.UI.Text txtPontos3;
	public UnityEngine.UI.Text txtRecorde2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		txtPontos3.text = PlayerPrefs.GetInt ("pontuacao").ToString ();
		txtRecorde2.text = PlayerPrefs.GetInt ("recorde").ToString ();
		if (PlayerAttack.pontuacao > PlayerPrefs.GetInt("recorde")) {
			PlayerPrefs.SetInt ("recorde", PlayerAttack.pontuacao);
		}
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex * 0);
		}
	}
}
