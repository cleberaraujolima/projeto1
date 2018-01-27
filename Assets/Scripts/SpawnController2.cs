using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController2 : MonoBehaviour {

	public GameObject boss1PreFab;
	public GameObject boss2PreFab;
	public GameObject boss3PreFab;
	public static int one = 5;
	public static int one2 = 5;
	public static int one3 = 5;
	//private float currentTime2;
	private float y2 = -3.14f;
	private float y3 = -1.20f;
	private float y4 = 1.4f;
	private bool nasce = false;
	private bool nasce2 = false;
	private bool nasce3 = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (moveSlime.morte == 25 && one >= 4) {
			nasce = true;
			if (nasce == true) {
				GameObject tempPreFab5 = Instantiate (boss1PreFab) as GameObject;
				tempPreFab5.transform.position = new Vector3 (transform.position.x, y2, tempPreFab5.transform.position.z);
				nasce = false;
				one = 0;
			}
		}
		if (moveSlime.morte == 50 && one2 >= 4) {
			nasce2 = true;
			if (nasce2 == true) {
				GameObject tempPreFab6 = Instantiate (boss2PreFab) as GameObject;
				tempPreFab6.transform.position = new Vector3 (transform.position.x, y3, tempPreFab6.transform.position.z);
				nasce2 = false;
				one2 = 0;
			}
		}
		if (moveSlime.morte == 75 && one3 >= 4) {
			nasce3 = true;
			if (nasce3 == true) {
				GameObject tempPreFab7 = Instantiate (boss3PreFab) as GameObject;
				tempPreFab7.transform.position = new Vector3 (transform.position.x, y4, tempPreFab7.transform.position.z);
				nasce3 = false;
				one3 = 0;
			}
		}
	}
}
