///https://www.youtube.com/watch?v=Lu6B0B1vxQ4
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TowerAI : MonoBehaviour {
	public enum AiStates{NEAREST, FURTHEST, WEAKEST, STRONGEST};

	public AiStates aiState = AiStates.NEAREST;

	TowerTracking m_tracker;
	TowerShooting m_shooter;
	RangeChecker m_range;

	// Use this for initialization
	void Start () {
		m_tracker = GetComponent<TowerTracking> ();
		m_shooter = GetComponent<TowerShooting> ();
		m_range = GetComponent<RangeChecker> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (!m_tracker || !m_shooter || !m_range)
			return;

		switch (aiState)
		{
		case AiStates.NEAREST:
			TargetNearest ();
			break;
		case AiStates.FURTHEST:
			TargetFurthest ();
			break;
		case AiStates.WEAKEST:

			break;
		case AiStates.STRONGEST:

			break;
		}
	}

	void TargetNearest() {
		List<GameObject> validTargets = m_range.GetValidTargets ();

		GameObject curTarget = null;
		float closestDist = 0.0f;

		for (int i = 0; i < validTargets.Count; i++) {
			float dist = Vector3.Distance (transform.position, validTargets[i].transform.position);

			if (!curTarget || dist < closestDist) {
				curTarget = validTargets[i];
				closestDist = dist;
			}
		}

		m_tracker.SetTarget (curTarget);
		m_shooter.SetTarget (curTarget);
	}

	void TargetFurthest() {
		List<GameObject> validTargets = m_range.GetValidTargets ();

		GameObject curTarget = null;
		float furthestDist = 0.0f;

		for (int i = 0; i < validTargets.Count; i++) {
			float dist = Vector3.Distance (transform.position, validTargets[i].transform.position);

			if (!curTarget || dist > furthestDist) {
				curTarget = validTargets[i];
				furthestDist = dist;
			}
		}

		m_tracker.SetTarget (curTarget);
		m_shooter.SetTarget (curTarget);
	}
}
