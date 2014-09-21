using UnityEngine;
using System.Collections;

public class Insegui : MonoBehaviour {

    private NavMeshAgent agent;
    private Transform giocatoreT;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        giocatoreT = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    void Update()
    {
        agent.SetDestination(giocatoreT.position);
    }
}
