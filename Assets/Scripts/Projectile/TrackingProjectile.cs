using UnityEngine;
using System.Collections;

public class TrackingProjectile : BaseProjectile {
	GameObject m_target;

	// Update is called once per frame
	void Update () {
		if (m_target) {
			transform.position = Vector3.MoveTowards (transform.position, m_target.transform.position, speed * Time.deltaTime);
		} else
			Destroy (gameObject);
	}

	public override void fireProjectile (GameObject launcher, GameObject target, int _damage) {
		damage = _damage;
		if (target) {
			m_target = target;
		}
	}

	public override void fireProjectile2(GameObject launcher, int _damage) {
		Debug.LogError("Exception: Puny Human function not found!");
	}
}
