using UnityEngine;
using System.Collections;

public class BuildManager : MonoBehaviour {

	public static BuildManager instance;
	public GameObject standardTurretPrefab;
	public GameObject wallPrefab;

	private GameObject turretToBuild;

	void Awake()
	{
		if (instance != null){
			Debug.LogError ("More than one BuildManager in scene!");
			return;
		}
		instance = this;
	}

	public GameObject GetTurretToBuild()
	{
		return turretToBuild;
	}

	public void SetTurretToBuild(GameObject turret)
	{
		turretToBuild = turret;
	}
}
