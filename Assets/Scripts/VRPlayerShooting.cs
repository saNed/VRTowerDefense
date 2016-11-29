using UnityEngine;
using System.Collections;

public class VRPlayerShooting : MonoBehaviour {

    public GameObject projectile;
    public GameObject projectileSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")) {
            Debug.Log("I FIRED!");
            Instantiate(projectile, projectileSpawn.transform.position, Quaternion.Euler(projectileSpawn.transform.forward));
        }
	}

}
