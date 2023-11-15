using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Unit : SelectObject
{
    public NavMeshAgent navMeshAgent;
    public override void WhenClickOnGround(Vector3 point)
    {
        base.WhenClickOnGround(point);
        navMeshAgent.SetDestination(point);
    }
}
