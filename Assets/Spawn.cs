using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Enemy;
    public float waitingForNextSpawn = 3;
    public float theCountdown = 1;
    public void Update() {
        theCountdown -= Time.deltaTime;
          if(theCountdown <= 0)
          {
            //Debug.Log("SOMETHING JUST SPAWNED LOOK FOR IT");
            SpawnEnemy ();
            theCountdown = waitingForNextSpawn;
          }
    }
    void SpawnEnemy()
      {
        //Debug.Log("rise");
        Instantiate(Enemy, new Vector3(7,7.5f,0), Quaternion.identity);
      }
}

