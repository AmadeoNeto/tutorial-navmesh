using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToTarget : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform target;

    void FixedUpdate()
    {
        agent.SetDestination(target.position);
    }
}
