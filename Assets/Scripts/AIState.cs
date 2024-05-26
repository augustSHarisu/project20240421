using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AI;

public class AIState : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private void OnEnable()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 发射一条射线从鼠标点击的屏幕位置
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // 如果射线击中了地面，将角色移动到击中的位置
                navMeshAgent.SetDestination(hit.point);
            }
        }
        
        float playerSpeed = navMeshAgent.velocity.magnitude;
        StateMachine.Running = playerSpeed > 0.1f;
        StateMachine.SetStateMachine();
    }
}
