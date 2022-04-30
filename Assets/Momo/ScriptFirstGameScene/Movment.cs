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
    Animator anim;
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
            transform.position += Vector3.right * speed * Time.deltaTime;

        } if (Input.GetKey(KeyCode.A))
        {
            Satvar.right = false;
            Satvar.left = true;
           // Satvar.down = false;
            transform.position += -Vector3.right * speed * Time.deltaTime;
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
                anim.SetBool("Jump", true);
            }
            else
            {
                anim.SetBool("Jump", false);
            }

        }

        if (Satvar.amountjump > 0)
        {
          
            Satvar.jumping = false;
            Debug.Log("Jumping : " + Satvar.jumping);
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