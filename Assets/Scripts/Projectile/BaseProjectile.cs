/// https://www.youtube.com/watch?v=nHS83vVRBWE
using UnityEngine;
using System.Collections;

public abstract class BaseProjectile : MonoBehaviour {
	public float speed = 5.0f;
	public int damage = 5;

	public abstract void fireProjectile (GameObject launcher, GameObject target, int _damage);

	public abstract void fireProjectile2 (GameObject launcher, int _damage);

	public void OnCollisionEnter (Collision coll)
	{
		if(coll.gameObject.tag == "Enemy")
			coll.gameObject.GetComponent <EnemyHealth> ().TakeDamage(damage);
			Destroy (gameObject);
	}
}
