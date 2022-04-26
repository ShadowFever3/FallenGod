using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    [SerializeField]
    int speed;
    [SerializeField]
    int jump;
    [SerializeField]
    Animator animator;
    void Start()
    {

    }


    void Update()
    {
        //Movement
        if (Input.GetKey(KeyCode.D))
        {
            Satvar.right = true;
            Satvar.left = false;
            // Satvar.down = false;
            animator.SetFloat("Speed", 1);
           
            transform.position += Vector3.right * speed * Time.deltaTime;
            
            Debug.Log("Speed should be 1");
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            Satvar.right = false;
            Satvar.left = true;
           // Satvar.down = false;
            transform.position += -Vector3.right * speed * Time.deltaTime;
            animator.SetFloat("Speed", 1);
            
        }
        else
        {
            animator.SetFloat("Speed", 0);
        }




        //Jump

        if (Input.GetKey(KeyCode.Space))    
        {
            if (Satvar.jumping == true)
            {
                //Satvar.right = false;
               //Satvar.left = false;
               //Satvar.down = true;
                Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();

                rb.velocity = Vector2.up * jump;
                Satvar.amountjump=1;
                Debug.Log("Jump : "+ Satvar.amountjump);
                animator.SetBool("isJumping", true);
            }

        }

        if (Satvar.amountjump > 0)
        {
          
            Satvar.jumping = false;
            Debug.Log("Jumping : " + Satvar.jumping);
            animator.SetBool("isJumping", false);
        }

        




        //Dash
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (Satvar.dash == true)
            {
              
                if (Satvar.right == true)
                {

                    Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();

                    rb.velocity = transform.right * 3;

                }
                else if (Satvar.left == true)
                {
                    Rigidbody2D rb = this.gameObject.GetComponent<Rigidbody2D>();

                    rb.velocity = -transform.right * 3;

                }

            }
        }
    }
}