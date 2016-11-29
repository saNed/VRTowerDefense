 using UnityEngine;
using System.Collections;

public class NormalProjectile : BaseProjectile {
	Vector3 m_direction;
	bool m_fired;
	
	// Update is called once per frame
	void Update () {
		if (m_fired) {
			transform.position += m_direction * (speed * Time.deltaTime);
		}
	}

	public override void fireProjectile (GameObject launcher, GameObject target, int _damage) {
		damage = _damage;
		if (launcher && target) {
			m_direction = (target.transform.position - launcher.transform.position).normalized;
			m_fired = true;
		}
	}
}
