using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnemyKiller : MonoBehaviour
{
    public void KillEnemy(GameObject enemy) 
    {  
        EventHandler.EnemyDied();
        Destroy(enemy);
        Debug.Log("Attempting to destroy " + enemy.name);
    }
}
