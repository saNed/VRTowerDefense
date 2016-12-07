using UnityEngine;
using System.Collections;

public class VRPlayerShooting : MonoBehaviour {

    public GameObject projectile;
    public GameObject projectileSpawn;
	public int damage;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Fire1")) {
            Debug.Log("I FIRED!");
			GameObject proj = Instantiate(projectile, projectileSpawn.transform.position, Quaternion.Euler(projectileSpawn.transform.forward)) as GameObject;
			proj.GetComponent<BaseProjectile>().fireProjectile2(projectileSpawn, damage);
        }
	}

}
