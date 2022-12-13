using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    private void Start(){

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Player"){
            Debug.Log("You Lose");
        }
        if(other.gameObject.tag == "Bullet"){
            Debug.Log("Kaboom");
            Destroy(other.gameObject, 0.1f);
        }
    }
}
