/// https://www.youtube.com/watch?v=nHS83vVRBWE
using UnityEngine;
using System.Collections;

public abstract class BaseProjectile : MonoBehaviour {
	public float speed = 5.0f;

	public abstract void fireProjectile (GameObject launcher, GameObject target, int damage);
}
