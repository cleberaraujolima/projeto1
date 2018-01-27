using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnController : MonoBehaviour {

	public GameObject slimePreFab;
	public GameObject slimePreFab2;
	public GameObject slimePreFab3;
	public GameObject slimePreFab4;
	public float rateSpawn;
	public float currentTime;
	private float y;
	public Transform fundo01;
	public Transform fundo02;
	public Transform fundo03;
	public Transform fundo04;
	private float x1 = 0.01f;
	private float y1 = 0.005f;
	private float z1 = 2;
	private float z2 = 4;

	// Use this for initialization
	void Start () {
		currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
		currentTime += Time.deltaTime;
		if (currentTime >= rateSpawn && moveSlime.morte < 25) {
			currentTime = 0;
			y = Random.Range (-4, 2);
			GameObject tempPreFab = Instantiate (slimePreFab) as GameObject;
			tempPreFab.transform.position = new Vector3 (transform.position.x, y, tempPreFab.transform.position.z);
			fundo01.transform.position = new Vector3 (x1, y1, z1);
		}
		if (currentTime >= rateSpawn && moveSlime.morte < 50) {
			currentTime = 0;
			y = Random.Range (-4, 2);
			GameObject tempPreFab2 = Instantiate (slimePreFab2) as GameObject;
			tempPreFab2.transform.position = new Vector3 (transform.position.x, y, tempPreFab2.transform.position.z);
			fundo02.transform.position = new Vector3 (x1, y1, z1);
			fundo01.transform.position = new Vector3 (x1, y1, z2);
		}
		if (currentTime >= rateSpawn && moveSlime.morte < 75) {
			currentTime = 0;
			y = Random.Range (-4, 2);
			GameObject tempPreFab3 = Instantiate (slimePreFab3) as GameObject;
			tempPreFab3.transform.position = new Vector3 (transform.position.x, y, tempPreFab3.transform.position.z);
			fundo03.transform.position = new Vector3 (x1, y1, z1);
			fundo02.transform.position = new Vector3 (x1, y1, z2);
		}
		if (currentTime >= rateSpawn && moveSlime.morte < 100) {
			currentTime = 0;
			y = Random.Range (-4, 2);
			GameObject tempPreFab4 = Instantiate (slimePreFab4) as GameObject;
			tempPreFab4.transform.position = new Vector3 (transform.position.x, y, tempPreFab4.transform.position.z);
			fundo04.transform.position = new Vector3 (x1, y1, z1);
			fundo03.transform.position = new Vector3 (x1, y1, z2);
		}
	}
}
