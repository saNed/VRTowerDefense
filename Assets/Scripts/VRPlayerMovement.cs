using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System;

class VRMessage : MessageBase
{
    public Quaternion rot;
}

public class VRPlayerMovement : NetworkBehaviour {

    public Vector3[] positions;
    public Vector3[] rotations;
    public int index;

	// Use this for initialization
	void Start () {
        positions = new Vector3[4];
        positions[3] = new Vector3(-7.0f, 3.0f, 7.0f);
        positions[0] = new Vector3(-7.0f, 3.0f, -7.0f);
        positions[1] = new Vector3(7.0f, 3.0f, -7.0f);
        positions[2] = new Vector3(7.0f, 3.0f, 7.0f);

        rotations = new Vector3[4];
        rotations[0] = new Vector3(0.0f, 45.0f, 0.0f);
        rotations[1] = new Vector3(0.0f, 315.0f, 0.0f);
        rotations[2] = new Vector3(0.0f, 225.0f, 0.0f);
        rotations[3] = new Vector3(0.0f, 135.0f, 0.0f);

        //this.gameObject.transform.position = positions[0];

    }

    const short msgID = 777;
	// Update is called once per frame
	void Update () {
        if (isServer)
        {
            return;
        }
        if (Input.GetButtonDown("LeftMovement"))
        {
            Debug.Log("I MOVED LEFT!");

            if (index == 0)
            {
                index = 3;
                transform.position = positions[index];
                transform.rotation = Quaternion.Euler(rotations[index]);
            }
            else {
                --index;
                transform.position = positions[index];
                transform.rotation = Quaternion.Euler(rotations[index]);
            }
        }

        if (Input.GetButtonDown("RightMovement"))
        {
            Debug.Log("I MOVED RIGHT!");

            if (index == 3)
            {
                index = 0;
                transform.position = positions[index];
                transform.rotation = Quaternion.Euler(rotations[index]);
            }
            else {
                ++index;
                transform.position = positions[index];
                transform.rotation = Quaternion.Euler(rotations[index]);
            }
        }
    }
}
