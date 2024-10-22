using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RandomPointSphere : MonoBehaviour
{
    [SerializeField] private float rad;

    private NavMeshAgent agent;

    private Vector3 destination;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        destination = transform.position;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) GetPoint();
        agent.SetDestination(destination);
    }
    private void GetPoint()
    {
        //cojo punto aleatorio dentro de una esfera fija
        Vector3 randomPoint = transform.position + (Random.insideUnitSphere * rad);
        //calculo el punto más cercano a ese randomPoint pero que pertenezca al NavMesh
        NavMeshHit hit;
        NavMesh.SamplePosition(randomPoint, out hit, 50, 1);
        destination = hit.position;
    }
}
