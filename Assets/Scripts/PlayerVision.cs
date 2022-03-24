using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVision : MonoBehaviour
{
    public float visionRange;
    public Camera cam;
    RaycastHit hitInfo;
    public PlayerEnemyKiller killer;

    // Update is called once per frame
    void Update()
    {
        if ((Physics.Raycast(transform.position, cam.transform.forward, out hitInfo, visionRange)) && hitInfo.transform.tag == "Enemy")
        {
            Debug.DrawRay(transform.position, cam.transform.forward, Color.green, 0.1f);
            Debug.Log(name + " has spotted the enemy!");
            killer.KillEnemy(hitInfo.transform.gameObject);
        } 
        if ((Physics.Raycast(transform.position, cam.transform.position, out hitInfo, visionRange)) && hitInfo.transform.tag != "Enemy")
        {
            Debug.DrawRay(transform.position, cam.transform.forward, Color.yellow, 0.1f);  
            //Debug.Log(name + " is seeing a " + hitInfo.transform.tag);
        } else {
            Debug.DrawRay(transform.position, cam.transform.forward, Color.red, 0.1f);
        }
    }
}
