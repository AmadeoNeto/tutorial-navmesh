using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentMovmentation : MonoBehaviour
{
    public NavMeshAgent agent;
    public Vector3 destination;

    void FixedUpdate()
    {
        agent.SetDestination(destination);
    }
}