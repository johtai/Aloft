using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{   
        public Transform firePoint; 
        public GameObject bulletprefab;
        public AudioSource moveSound;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {   
            
             Instantiate(bulletprefab, firePoint.position, Quaternion.identity);

            //Vector3 fr = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
             //Instantiate(bulletprefab, fr, Quaternion.identity);  
            //bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(5.0f, 0.0f); //Старый способ полёта пули
            moveSound.Play();


        }

    }
}
