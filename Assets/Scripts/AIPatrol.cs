using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIPatrol : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;
    int waypointIndex;
    Vector3 target;
    public float delayTime = 2f; // The amount of time to delay in seconds

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        waypointIndex = 0;
        UpdateDestination();
    }

    void Update()
    {
        if (agent.remainingDistance < 1f && !agent.pathPending)
        {
            IterateWaypointIndex();
            UpdateDestination();
        }
    }

    void UpdateDestination()
    {
        target = waypoints[waypointIndex].position;
        agent.SetDestination(target);
    }

    void IterateWaypointIndex()
    {
        waypointIndex++;
        if (waypointIndex >= waypoints.Length)
        {
            waypointIndex = 0;
        }
    }
}