using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour
{
    public float SplashRange = 1;
    [SerializeField]
    GameObject explosion, projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "player")
        {

        }else if(collision.gameObject.tag == "harm")
            {
                Destroy(projectile);
            Instantiate(explosion, projectile.GetComponent<Rigidbody2D>().position, transform.rotation);
            }{
        Destroy(gameObject, 7f);
        }
    }
}
