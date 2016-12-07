using UnityEngine;

public class Shop : MonoBehaviour {

	public TowerBlueprint standardTurret;
	public TowerBlueprint heavyTurret;
	public TowerBlueprint wall;

	BuildManager buildManager;

	void Start()
	{
		buildManager = BuildManager.instance; 
	}



	public void PurchaseStandardTurret()
	{
		Debug.Log ("Standard Turret Selected");
		buildManager.SetTurretToBuild (standardTurret);
	}

	public void PurchaseHeavyTurret()
	{
		Debug.Log ("Standard Turret Selected");
		buildManager.SetTurretToBuild (heavyTurret);
	}

	public void PurchaseWall()
	{
		Debug.Log ("Wall Selected");
		buildManager.SetTurretToBuild (wall);
	}

	public void Deselect()
	{
		Debug.Log ("Deselect");
		buildManager.SetTurretToBuild (null);

	}
}
