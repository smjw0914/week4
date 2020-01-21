using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind2 : MonoBehaviour
{
     Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        AnimationUpdate();
    }

    void AnimationUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("open_wind2",true);
        }
    }
}
