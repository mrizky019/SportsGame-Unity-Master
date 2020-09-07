using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalRimTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        GoalNetTrigger netTrigger = GetComponentInChildren<GoalNetTrigger>();
        netTrigger.ExpectCollider(other);
    }
}

