using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BasicMovement : MonoBehaviour
{
    public float Speed = 10f;
    public Animator animator;
    public VectorValue pos;
    private Rigidbody2D _rb;


    void Start() 
    {
        _rb = GetComponent<Rigidbody2D>(); 
    }


    void FixedUpdate()
    {
        MovementLogic();
    }

 private void MovementLogic()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Magnitude", movement.magnitude);
        _rb.AddForce(movement * Speed);
        //transform.position = transform.position + movement * Time.deltaTime;
    }



}