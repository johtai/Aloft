using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Enemy;

public class BullAnim : MonoBehaviour
{

  public float timeDestroy = 3f;
  public float speed = 3f;
  public Rigidbody2D rb;


    void Start()
    {   
        rb = GetComponent<Rigidbody2D>();
        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.y, diference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ);

        rb.velocity = diference * speed;
        Invoke("DestroyBullet", timeDestroy);

    }


  private void OnCollisionEnter2D(Collision2D collision) 
  {
    if(collision.gameObject.CompareTag("Enemy"))
    {

      Destroy(gameObject);//уничтожаем объект со скриптом
    }
  }

  void DestroyBullet()
  {
    Destroy(this.gameObject);
  }
}

