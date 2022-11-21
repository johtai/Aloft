using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{   

       	//public GameObject player;
        public GameObject bulletprefab;

    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {   
            Vector3 fr = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
          GameObject bullet = Instantiate(bulletprefab, fr, Quaternion.identity);  
          bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(5.0f, 0.0f);     
        }
    }
}
