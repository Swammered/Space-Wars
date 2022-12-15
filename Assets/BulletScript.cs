using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 5f;
    void Update()
    {
        Move();
        DestroyBullet();
    }
    void Move(){
        Vector3 temp = transform.position;
        temp.y += speed * Time.deltaTime;
        transform.position = temp;
        transform.rotation = Quaternion.Euler(0,0,180);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Enemy"){
            Debug.Log("Kaboom");
            Destroy(other.gameObject, 0.1f);
        }
    }
    void DestroyBullet(){
        Destroy(gameObject, 5f);
        Debug.Log("he dead");
    }
}
