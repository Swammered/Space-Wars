using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject Smoke;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Bullet"){
            Destroy(other.gameObject, 0.1f);
            Destroy(Instantiate(Smoke, other.transform.position, Quaternion.identity), .5f);
        }

    }
}
