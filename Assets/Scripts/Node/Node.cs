//https://www.youtube.com/watch?v=t7GuWvP_IEQ&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=6
using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

	public Color hoverColor;

	private Renderer rend;
	private Color startColor;
	private GameObject turret;

	BuildManager buildManager;

	void Start () {
		rend = GetComponent<Renderer> ();
		startColor = rend.material.color;
		buildManager = BuildManager.instance;
	}
		
	void OnMouseDown ()
	{
		if (buildManager.GetTurretToBuild () == null)
			return;
			
		if (turret != null) {
			Debug.Log ("Can't build there!");
			return;
		}

		Debug.Log ("Place turret at: " + this.gameObject.transform.parent.name);

		GameObject tower = buildManager.GetTurretToBuild ();
		turret = (GameObject)Instantiate (tower, transform.position, Quaternion.identity, this.transform.parent);
	}

	void OnMouseEnter ()
	{
		if (buildManager.GetTurretToBuild () == null)
			return;
		rend.material.color = hoverColor;
	}

	void OnMouseExit ()
	{
		rend.material.color = startColor;
	}
}
