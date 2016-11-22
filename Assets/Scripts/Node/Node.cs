using UnityEngine;
using System.Collections;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public GameObject tower;

	private Renderer rend;
	private Color startColor;
	private GameObject turret;

	void Start () {
		rend = GetComponent<Renderer> ();
		startColor = rend.material.color;
	}

	void OnMouseEnter ()
	{
		rend.material.color = hoverColor;
	}

	void OnMouseDown ()
	{
		if (turret != null) {
			Debug.Log ("Can't build there!");
			return;
		}
		Instantiate (tower, transform.position, Quaternion.identity, this.transform.parent);
	}

	void OnMouseExit ()
	{
		rend.material.color = startColor;
	}
}
