using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            // Do the killing
            Debug.Log(name + " is gonna do some killing.");
        }
    }
}
