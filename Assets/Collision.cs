using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collision : MonoBehaviour
{
    
    public GameObject Explosion;
    private void  OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if(other.gameObject.tag == "Bullet"){
            Destroy(Instantiate(Explosion, this.transform.position, Quaternion.identity), .5f);
            Destroy(other.gameObject);
        }
    }
}
