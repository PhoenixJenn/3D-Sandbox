using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule") {
            Debug.Log("Player Detected - ATTACK!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Player Safe, resume patrol");
    }
}
