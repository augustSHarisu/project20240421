using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GameObject g = other.gameObject.transform.root.gameObject;
        if (g.TryGetComponent<EnableRagDoll>(out EnableRagDoll item))
        {
            if(item.KillFlag == true) { return; }
            item.ExecuteKill();
            item.KillFlag = true;
        }
    }
}
