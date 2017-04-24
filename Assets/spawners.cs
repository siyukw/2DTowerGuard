﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawners : MonoBehaviour {

	public GameObject[] enemies;
	public GameObject[] spawnerArray;
	public Vector3 spawnValues;
	public float spawnWait;
	public float spawnMostWait;
	public float spawnLeastWait;
	public int startWait;

	int randEnemy;
	int randSpawner;

	void Start () {
		StartCoroutine (Spawner());
	}


	void Update () {
		spawnWait = Random.Range (spawnLeastWait, spawnMostWait);
	}

	IEnumerator Spawner(){
		yield return new WaitForSeconds (startWait);

		while (true) {
			randEnemy = Random.Range (0, 3);
			randSpawner = Random.Range (0, 5);
			//Vector3 spawnPosition = GameObject.FindGameObjectWithTag("Respawn").transform.position;
			Vector3 spawnPosition = spawnerArray[randSpawner].transform.position;
			Instantiate (enemies[randEnemy], spawnPosition, gameObject.transform.rotation);
			yield return new WaitForSeconds (spawnWait);
		}
	}
}