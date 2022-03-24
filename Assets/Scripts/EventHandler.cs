using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHandler : MonoBehaviour
{
    public delegate void EnemyEventHandler();
    public static event EnemyEventHandler OnEnemyDied;

    public static void EnemyDied() {
        Debug.Log("An enemy has despawned!");
        OnEnemyDied();
    }
}
