using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    [SerializeField]
    Animator anim;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D) && Satvar.jumping == true)
        {
            anim.SetBool("GoingRight", true);
            gameObject.transform.localScale = new Vector3(4, 4, 1);
        }
        else
        {
            anim.SetBool("GoingRight", false);
        }
        if (Input.GetKey(KeyCode.A) && Satvar.jumping == true)
        {
            anim.SetBool("GoingRight", true);
            gameObject.transform.localScale = new Vector3(-4, 4, 1);
        }
    }
}
