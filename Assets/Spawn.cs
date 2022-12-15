using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Enemy;
    public float waitingForNextSpawn = 3;
    public float theCountdown = 1;
    public int counter = 0;
    public void Update() {
        theCountdown -= Time.deltaTime;
          if(theCountdown <= 0 && counter < 11)
          {
            SpawnEnemy ();
            theCountdown = waitingForNextSpawn;
          }
    }
    void SpawnEnemy()
      {
        var newEnemy = Instantiate(Enemy, new Vector3(7,7.5f,0), Quaternion.identity);
        newEnemy.SetActive(true);
        counter += 1;
      }
}

