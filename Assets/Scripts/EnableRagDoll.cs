using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;  // can use classes in namespace

[ExecuteAlways]     // execute when 1. Play Mode and 2. when editing
public class EnableRagDoll : MonoBehaviour
// only class:[MonoBehavior] can be assigned to the Object
{
    public bool KillFlag = false;
    public void ExecuteKill() => SetKinematicOff();
    // Naming Conventions; variables starts with lowercase; methods starts with uppercase
    private Rigidbody[] rigidbodies;
    private void OnEnable() // Event function; execute when the box is clicked "on" (enabled)
    {
        Debug.Log(message:"EnableRagdoll On");
        rigidbodies = this.gameObject.GetComponentsInChildren<Rigidbody>();
    }
    
    [Button("Reset Kinematic On", ButtonSizes.Small)]
    private void SetKinematicOn()
    {
        for (int i = 0; i < rigidbodies.Length; i++)
        {
            rigidbodies[i].isKinematic = true;
        }
    }
    
    [Button("Reset Kinematic Off (Ragdoll)", ButtonSizes.Small)]
    private void SetKinematicOff()
    {
        for (int i = 0; i < rigidbodies.Length; i++)
        {
            rigidbodies[i].isKinematic = false;
        }

        KillFlag = false;
    }
    //
    // [Button("Switch On/Off Kinematic", ButtonSizes.Large)]
    // private void SwitchKinematic()
    // {
    //     for (int i = 0; i < rigidbodies.Length; i++)
    //     {
    //         rigidbodies[i].isKinematic = !rigidbodies[i].isKinematic;
    //     }
    // }
}
