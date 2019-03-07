using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GullSpawner : MonoBehaviour {

	float t,t2,tSpawn,tSpawn2;
	public static GullSpawner gullSpawner;
	public GameObject GullPrefab;
	public GameObject EaglePrefab;
	public float vel;

	// Use this for initialization
	void Start () {
		vel = -8f;
		tSpawn = 4.5f;
		tSpawn2 = 8f;
	}

	public float getVel(){
		return vel;
	}

	// Update is called once per frame
	void Update () {
		t += Time.deltaTime;
		t2 += Time.deltaTime;

		if (t >= tSpawn) {
			t = 0;
			vel -= 0.3f;
			tSpawn -= 0.001f; 
			float x = 11f;
			float y = Random.Range (1.5f, 8f);
			Vector3 pos = new Vector3 (x,y,0);
			Quaternion rot = new Quaternion();
			Instantiate(GullPrefab, pos, rot);
		}

		if (t2 >= tSpawn2) {
			t2 = 0;
			tSpawn2 -= 0.002f; 
			float x2 = -11f;
			float y2 = Random.Range (1.5f, 8f);
			Vector3 pos2 = new Vector3 (x2,y2,0);
			Quaternion rot2 = new Quaternion();
			Instantiate(EaglePrefab, pos2, rot2);
		}
	}
	//void OnBecameInvisible(){}
}
