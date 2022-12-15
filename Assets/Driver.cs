using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveAmount = 5f;
    [SerializeField] private GameObject Bullet;
    [SerializeField] private Transform attack_Point;
    void Update()
    {
        float moveSpeed = Input.GetAxis("Horizontal") * moveAmount * Time.deltaTime;
        transform.Translate(-moveSpeed,0,0);
        Attack();
    }
    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Enemy"){
            Debug.Log("die");
            //Death
            //create animation
        } 
    }
    void Attack(){
        if(Input.GetKeyDown(KeyCode.Space)){
            var newBullet = Instantiate(Bullet,transform.position, Quaternion.identity);
            newBullet.SetActive(true);
        }
    }
}
