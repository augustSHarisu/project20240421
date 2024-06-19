using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AI;

public class AIState : MonoBehaviour
{
    public Vector3 TargetPosition;
    private NavMeshAgent navMeshAgent;
    private void OnEnable()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    [Button("Set Destination", ButtonSizes.Medium)]
    private void SetDestination()
    {
        navMeshAgent.SetDestination(TargetPosition);
    }
    private void Update()
    {
        // Set Animation State
        float playerSpeed = navMeshAgent.velocity.magnitude;
        StateMachine.Running = playerSpeed > 0.1f;
        StateMachine.SetStateMachine_Run();
    }
}
