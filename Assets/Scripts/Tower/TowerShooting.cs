﻿///https://www.youtube.com/watch?v=Z8LxY8H4uY4
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TowerShooting : MonoBehaviour {
	public float fireRate;
	public int damage;
	public float fieldOfVew;
	public bool beam;
	public GameObject projectile;
	public List<GameObject> projectileSpawns;

	List<GameObject> m_lastProjectiles = new List<GameObject>();
	float m_fireTimer = 0.0f;
	GameObject m_target;

	// Update is called once per frame
	void Update () {
		if (!m_target)
			return;

		if (beam && m_lastProjectiles.Count <= 0) {
			float angle = Quaternion.Angle (transform.rotation, Quaternion.LookRotation (m_target.transform.position - transform.position));

			if (angle < fieldOfVew) {
				SpawnProjectiles ();
			}
		} else if (beam && m_lastProjectiles.Count > 0) {
			float angle = Quaternion.Angle (transform.rotation, Quaternion.LookRotation (m_target.transform.position - transform.position));

			if (angle < fieldOfVew) {
				while (m_lastProjectiles.Count > 0) {
					Destroy (m_lastProjectiles [0]);
					m_lastProjectiles.RemoveAt (0);
				}
			}
		} else {
			m_fireTimer += Time.deltaTime;

			if (m_fireTimer >= fireRate) {
				float angle = Quaternion.Angle (transform.rotation, Quaternion.LookRotation (m_target.transform.position - transform.position));

				if (angle < fieldOfVew) {
					SpawnProjectiles ();
					m_fireTimer = 0.0f;
				}
			}
		}
	}

	void SpawnProjectiles () {
		if (!projectile) {
			return;
		}
		m_lastProjectiles.Clear ();
		for (int i = 0; i < projectileSpawns.Count; i++) {
			if (projectileSpawns [i]) {
				GameObject proj = Instantiate (projectile, projectileSpawns[i].transform.position, Quaternion.Euler(projectileSpawns[i].transform.forward)) as GameObject; 
				proj.GetComponent<BaseProjectile> ().fireProjectile (projectileSpawns[i], m_target, damage);

				m_lastProjectiles.Add (proj);
			}
		}

	}

	public void SetTarget (GameObject target) {
		m_target = target;
	}
}
