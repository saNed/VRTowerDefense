 //https://www.youtube.com/watch?v=t7GuWvP_IEQ&list=PLPV2KyIb3jR4u5jX8za5iU1cqnQPmbzG0&index=6
using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

	public Color hoverColor;
//	Vector3 positionOffset;

	private Renderer rend;
	private Color startColor;

	public GameObject turret;

	BuildManager buildManager;

	void Start () {
		rend = GetComponent<Renderer> ();
		startColor = rend.material.color;
		buildManager = BuildManager.instance;
	}

//	public Vector3 getPosition () {
//		return transform.position;
////		+ positionOffset;
//	}
		
	void OnMouseDown ()
	{
		if (!buildManager.canBuild)
			return;
			
		if (turret != null) {
			Debug.Log ("Can't build there!");
			return;
		}

		Debug.Log ("Place turret at: " + this.gameObject.transform.parent.name);

		buildManager.buildTurretOn (this);

	}

	void OnMouseEnter ()
	{
		if (!buildManager.canBuild)
			return;
		rend.material.color = hoverColor;
	}

	void OnMouseExit ()
	{
		rend.material.color = startColor;
	}
}
