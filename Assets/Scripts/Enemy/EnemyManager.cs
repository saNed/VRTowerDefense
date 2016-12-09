﻿//https://unity3d.com/learn/tutorials/projects/survival-shooter/more-enemies?playlist=17144using UnityEngine;using System.Collections;using UnityEngine.Networking;public class EnemyManager : NetworkBehaviour {	public GameObject[] enemies;	public float spawnTime = 3f;	public Transform[] spawnPoints;	void Start ()	{        if(isServer)    		InvokeRepeating ("Spawn", spawnTime, spawnTime);	}		void Spawn()	{		int spawnPointIndex = Random.Range (0, spawnPoints.Length);
        GameObject cur = (GameObject)Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPoints [spawnPointIndex].position, spawnPoints [spawnPointIndex].rotation);        NetworkServer.Spawn(cur);    }}