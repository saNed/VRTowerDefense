using UnityEngine;
using System.Collections;

public class BeamProjectile : BaseProjectile {
	GameObject m_launcher;
	public float beamLength = 10f;

	// Update is called once per frame
	void Update () {
		if (m_launcher) {
			GetComponent<LineRenderer> ().SetPosition (0, m_launcher.transform.position);
			GetComponent<LineRenderer> ().SetPosition (1, m_launcher.transform.position + (m_launcher.transform.forward * beamLength));
		}
	}

	public override void fireProjectile (GameObject launcher, GameObject target, int _damage) {
		damage = _damage;
		if (launcher) {
			m_launcher = launcher;
			transform.SetParent (m_launcher.transform);
		}
	}
}
