using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	EnemyHealth enemyHealth;
	private Rigidbody rbody;
	public float speed;
	public Vector3 movement;
	private float lastMove = -1f;

	void Awake ()
	{
		enemyHealth = GetComponent <EnemyHealth> ();
		rbody = GetComponent <Rigidbody> ();
	}


	void FixedUpdate ()
	{
		if (Time.time - lastMove > 1) {
			movement = new Vector3 (Random.Range (-1f, 1f), 0, Random.Range (-1f, 1f));
			lastMove = Time.time;
		}
		rbody.velocity = movement * speed;

	}
}
