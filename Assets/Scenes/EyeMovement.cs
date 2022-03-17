using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeMovement : MonoBehaviour
{
    [SerializeField]
    GameObject target, eye, projectile1;

    GameObject c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 targ = target.transform.position;
        targ.z = 0f;
        Vector3 objectPos = transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;
        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        if(Input.GetKeyDown(KeyCode.K))
        {
            c = Instantiate(projectile1, eye.transform.position + (transform.right * 0.1f), eye.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            Destroy(c, 3f);
        }  
    }
}
