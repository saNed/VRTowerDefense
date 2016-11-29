using UnityEngine;

public class Shop : MonoBehaviour {

	BuildManager buildManager;

	void Start()
	{
		buildManager = BuildManager.instance; 
	}

	public void PurchaseStandardTurret()
	{
		Debug.Log ("Standard Turret Selected");
		buildManager.SetTurretToBuild (buildManager.standardTurretPrefab);
	}

	public void PurchaseWall()
	{
		Debug.Log ("Wall Selected");
		buildManager.SetTurretToBuild (buildManager.wallPrefab);
	}

	public void Deselect()
	{
		Debug.Log ("Deselect");
		buildManager.SetTurretToBuild (null);

	}
}
