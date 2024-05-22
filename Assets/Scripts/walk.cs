using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {

    private float speed = 0;
    public float wSpeed;
    public float rSpeed;
    public float rotSpeed;
    static Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {   //walking
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = rSpeed;
            if (Input.GetKeyDown(KeyCode.W))
            {
                anim.CrossFade("Walking", 0.1f);
            }
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("IsWalking", true);
                anim.SetBool("IsIdeal", false);
            }
            else
            {
                anim.SetBool("IsWalking", false);
                anim.SetBool("IsIdeal", true);
            }
        }
        else if (Input.GetKey(KeyCode.W))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                anim.CrossFade("Walk", 0.1f);
            }
            if (Input.GetKey(KeyCode.W))
            {
                anim.SetBool("IsWalking", true);
                anim.SetBool("IsIdeal", false);
                speed = wSpeed;
            }
        }
        else
        {
            speed = wSpeed;
            anim.SetBool("IsWalking", false);
            anim.SetBool("IsIdeal", true);
        }
        
        var z = Input.GetAxis("Vertical") * speed;
        var y = Input.GetAxis("Horizontal") * rotSpeed;
        transform.Translate(0, 0, z);
        transform.Rotate(0, y, 0);
    }
}
