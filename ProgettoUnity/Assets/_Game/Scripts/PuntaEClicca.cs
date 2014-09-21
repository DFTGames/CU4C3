using UnityEngine;
using System.Collections;

public class PuntaEClicca : MonoBehaviour {

    protected NavMeshAgent agent;
    protected RaycastHit hit;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    void AttivitaMouse()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            agent.SetDestination(hit.point);
        }
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            AttivitaMouse();
        }
    }
}
