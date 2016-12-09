using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class HomingPath : MonoBehaviour {

    EnemyHealth enemyHealth;
    private Rigidbody rbody;
    public GameObject[] targets;
    // public Transform goal;


    void Awake()
    {
        enemyHealth = GetComponent<EnemyHealth>();
        rbody = GetComponent<Rigidbody>();
    }

    void Start() {

        for (int i = 0; i < targets.Length; i++) {
            targets[i] = GameObject.Find("Tower" + (i + 1));
        }


        // goal = GameObject.Find("Goal").transform;
        int targetIndex = Random.Range(0, targets.Length);
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        agent.destination = targets[targetIndex].transform.position;
        //agent.destination = goal.position;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Pillar") {
            Destroy(gameObject);
            return;
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
