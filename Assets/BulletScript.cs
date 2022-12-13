using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 5f;
    public float deactivate_Timer = 3f;
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    void Move(){

        Vector3 temp = transform.position;
        temp.y += speed * Time.deltaTime;
        transform.position = temp;
        transform.rotation = Quaternion.Euler(0,0,180);
    }
}
