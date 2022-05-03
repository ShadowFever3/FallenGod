using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieWeapons : MonoBehaviour
{
    [SerializeField]
    GameObject player, projectile1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
     

            Vector3 targ = player.transform.position;
            targ.z = 0f;
            Vector3 objectPos = transform.position;
            targ.x = targ.x - objectPos.x;
            targ.y = targ.y - objectPos.y;
            float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                GameObject spawn = Instantiate(projectile1, transform.position + new Vector3(0, 0), transform.rotation);
                spawn.GetComponent<Rigidbody2D>().velocity = transform.right * 10;
                Destroy(spawn, 3f);

            }
        }
}
  
