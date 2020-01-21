using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nub : MonoBehaviour
{
    public float speed = 0.001f;
    public float jumpPower;
    public float rotateSpeed = 1;
    Rigidbody rigidbody;
    Animator animator;
    bool isJumping;
    float h;
    float v;
    Vector3 movement;

    float rotSpeed = 2.2f;


    void Awake()
    {
        isJumping = false;
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Jump") && !isJumping)
        {
            //isJumping = true;
            rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
        AnimationUpdate();


        float MouseX = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up * rotSpeed * MouseX);

        if (!(h == 0 && v == 0))
        {
            movement.Set(h, 0, v);
            //movement = movement.normalized * speed * Time.deltaTime;
            transform.Translate(0.5f*movement.normalized+Vector3.forward * speed * Time.deltaTime);
           // rigidbody.MovePosition(transform.position + movement);
        }

    }


    
    //void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.tag == "Floor")
    //        isJumping = false;
    //}
   void AnimationUpdate()
    {
        if(h ==0 && v == 0){
            animator.SetBool("Walking", false);
        }
        else
        {
            animator.SetBool("Walking", true);
        }
    }
}
