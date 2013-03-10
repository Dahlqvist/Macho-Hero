using UnityEngine;
using System.Collections;

public class Tracker : MonoBehaviour {

    private NavMeshAgent agent;
    public Transform player;
    //public string tag;
    //public GameObject player;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        //GameObject go = GameObject.FindGameObjectWithTag("Player");
        //player = go.transform;
    }

    private void Update()
    {
        agent.destination = player.position;
    }
}
