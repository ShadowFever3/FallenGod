using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    [SerializeField]
    GameObject projectile1;
    [SerializeField]
    GameObject projectile2;
    [SerializeField]
    GameObject projectile3;
    void Start()
    {
        
    }

 
    void Update()
    {

        if (Satvar.magic == projectile1)
        {
            if (Satvar.mana == true)
            {
             if (Satvar.right == true) {
                if (Input.GetMouseButtonDown(1))
                {
            GameObject spawn = Instantiate(Satvar.magic, transform.position + new Vector3(0.8f, 0), transform.rotation);
            spawn.GetComponent<Rigidbody2D>().velocity = transform.right * 10;
            Destroy(spawn, 3f);
                        ManaBar.manabar.UseStamina(15);

                    }
        }
            }

            if (Satvar.mana == true)
            {
                if (Satvar.left == true) {
                if (Input.GetMouseButtonDown(1))
                {
            GameObject spawn = Instantiate(Satvar.magic, transform.position + new Vector3(-0.8f, 0), transform.rotation);
            spawn.GetComponent<Rigidbody2D>().velocity = -transform.right * 10;
            Destroy(spawn, 3f);
                    ManaBar.manabar.UseStamina(15);
                }
            
        }
            }
            /*
              if (Satvar.down==true)
              {
                  if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.S))
                  {
                      GameObject spawn = Instantiate(Satvar.projectile, transform.position + new Vector3(0, -0.6f), transform.rotation);
                      spawn.GetComponent<Rigidbody2D>().velocity = -transform.up * 10;
                      Destroy(spawn, 3f);
                  }

              }
            */

        }



        if (Satvar.melee == projectile2){
            if (Satvar.right == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject spawn = Instantiate(Satvar.melee, transform.position + new Vector3(0.8f, 0), transform.rotation);
                    spawn.GetComponent<Rigidbody2D>().velocity = transform.right * 3;
                    Destroy(spawn, 3f);
                }
            }

            if (Satvar.left == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject spawn = Instantiate(Satvar.melee, transform.position + new Vector3(-0.8f, 0), transform.rotation);
                    spawn.GetComponent<Rigidbody2D>().velocity = -transform.right * 3;
                    Destroy(spawn, 3f);
                }

            }
            /*
            if (Satvar.down == true)
            {
                if (Input.GetMouseButtonDown(0) && Input.GetKey(KeyCode.S))
                {
                    GameObject spawn = Instantiate(Satvar.projectile, transform.position + new Vector3(0f, -0.6f), transform.rotation);
                    spawn.GetComponent<Rigidbody2D>().velocity = -transform.up * 10;
                    Destroy(spawn, 3f);
                }


            }
            */

        }
        if (Satvar.melee == projectile3)
        {
            if (Satvar.right == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject spawn = Instantiate(Satvar.melee, transform.position + new Vector3(0.8f, 0), transform.rotation);
                    spawn.GetComponent<Rigidbody2D>().velocity = transform.right * 2;
                    Destroy(spawn, 3f);
                }
            }


            if (Satvar.left == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    GameObject spawn = Instantiate(Satvar.melee, transform.position + new Vector3(-0.8f, 0), transform.rotation);
                    spawn.GetComponent<Rigidbody2D>().velocity = -transform.right * 2;
                    Destroy(spawn, 3f);
                }

            }
        }
}
   
}



