using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    float speed, jumpspeed;
    Rigidbody2D rb2d;
    void Start()
    {
        CharacterSettings.inair = false;
        CharacterSettings.left = false;
        CharacterSettings.right = true;
        rb2d = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * (1 * speed) * Time.deltaTime;
            CharacterSettings.right = true;
            CharacterSettings.left = false;
        }

        if(Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * (-1 * speed) * Time.deltaTime;
            CharacterSettings.right = false;
            CharacterSettings.left = true;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(CharacterSettings.inair == false){
            rb2d.AddForce((transform.up * jumpspeed), ForceMode2D.Impulse);
            CharacterSettings.inair = true;
            }else{

            }
        }
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            if(CharacterSettings.right == true)
            {
            GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(CharacterSettings.left == true)
            {
                GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }
        }   
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ShotgunAmmo")
        {

        }else{
            CharacterSettings.inair = false;
        }
    }
}
