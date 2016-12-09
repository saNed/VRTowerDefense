﻿using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class BuildManager : NetworkBehaviour {
    public static BuildManager instance;

	public GameObject standardTurretPrefab;
	public GameObject wallPrefab;
	public GameObject heavyTurretPrefab;
	PlayerStats playerStats;

	private TowerBlueprint turretToBuild;

	void Awake()
	{
		if (instance != null){
			Debug.LogError ("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}

	void Start() {
		playerStats = PlayerStats.instance;
	}

//	public GameObject GetTurretToBuild()
//	{
//		return turretToBuild;
//	}
	public bool canBuild {get {return  turretToBuild != null;} }

	public void SetTurretToBuild(TowerBlueprint turret)
	{
		turretToBuild = turret;
	}

	public void buildTurretOn(Node node) {
		if (PlayerStats.Gold < turretToBuild.cost) {
			Debug.Log ("Not enough money");
			return;
		}

		//PlayerStats.Gold -= turretToBuild.cost; 
		playerStats.addGold (-turretToBuild.cost);


		GameObject tower = (GameObject)Instantiate (turretToBuild.prefab, node.transform.position, Quaternion.identity);
		node.turret = tower;
        NetworkServer.Spawn(tower);

        Debug.Log ("Gold left: " + PlayerStats.Gold);
	}
}
