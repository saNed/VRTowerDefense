 using UnityEngine;
using System.Collections;

public class NormalProjectile : BaseProjectile {
	Vector3 m_direction;
	bool m_fired;
	bool player;

	// Update is called once per frame
	void Update () {
		if (m_fired) {
			if (player)
			{
			    transform.position += m_direction * (speed * 2.0f * Time.deltaTime);
			}
			 else
			{
				transform.position += m_direction * (speed * Time.deltaTime);
			}
		}
	}

	public override void fireProjectile (GameObject launcher, GameObject target, int _damage) {
		damage = _damage;
		if (launcher && target) {
			m_direction = (target.transform.position - launcher.transform.position).normalized;
			m_fired = true;
		}
	}

	public override void fireProjectile2(GameObject launcher, int _damage)
	{
		damage = _damage;
		if (launcher)
			{
			m_direction = (launcher.transform.forward).normalized;
			m_fired = true;
			player = true;
			}
		Destroy(this.gameObject, 1.5f);
	}
}
