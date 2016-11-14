using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	public Transform pointA;
	public Transform pointB;
	public float speed;

	void Update ()
	{
		transform.position = Vector3.Lerp (pointA.position, pointB.position, Mathf.Sin (Time.time * speed));

	}
}
