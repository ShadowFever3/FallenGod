using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossChiron : MonoBehaviour
{
    float speed;
    [SerializeField]
    GameObject arrow;
    [SerializeField]
    Transform arrowPosition;
    [SerializeField]
    int arrowSpeed;
    [SerializeField]
    GameObject player;

    [SerializeField]
    Transform teleportTarget_TL, teleportTarget_TR, teleportTarget_ML, teleportTarget_MR, teleportTarget_BL, teleportTarget_BR;


    // Start is called before the first frame update
    void Start()
    {
        speed = arrowSpeed* Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Is it Left: " + StatVarChiron.isPlayerLeft);
        Debug.Log("Is it Right: " + StatVarChiron.isPlayerRight);
        //Shot arrow
        if (Input.GetKeyDown(KeyCode.P))
        {
            shotArrow();
        }

        float randTp = UnityEngine.Random.Range(0, 2000);
        //Debug.Log("Rand Value: " + randTp);
        //Teleport Chiron
        if (Input.GetKeyDown(KeyCode.T) || randTp == 1000f)
        {
            tpRand();
        }
    }

    private void tpRand()
    {
        float rand = 0.0f;
        if (StatVarChiron.isPlayerLeft)
        {
            rand = UnityEngine.Random.Range(3, 6);
        }
        if (StatVarChiron.isPlayerRight)
        {
            rand = UnityEngine.Random.Range(0, 3);
        }
        switch (rand)
        {
            case 0:
                gameObject.transform.position = teleportTarget_BL.transform.position;
                gameObject.transform.localScale = new Vector3(-1, 1, 0);
                break;
            case 1:
                gameObject.transform.position = teleportTarget_ML.transform.position;
                gameObject.transform.localScale = new Vector3(-1, 1, 0);
                break;
            case 2:
                gameObject.transform.position = teleportTarget_TL.transform.position;
                gameObject.transform.localScale = new Vector3(-1, 1, 0);
                break;
            case 3:
                gameObject.transform.position = teleportTarget_BR.transform.position;
                gameObject.transform.localScale = new Vector3(1, 1, 0);
                break;
            case 4:
                gameObject.transform.position = teleportTarget_MR.transform.position;
                gameObject.transform.localScale = new Vector3(1, 1, 0);
                break;
            case 5:
                gameObject.transform.position = teleportTarget_TR.transform.position;
                gameObject.transform.localScale = new Vector3(1, 1, 0);
                break;
        }
        
    }











    private void shotArrow()
    {
        //Spawn arrow
        GameObject newArrow = Instantiate(arrow, arrowPosition.position, arrowPosition.rotation);

        //Rotate arrow toward the player
        //Vector3 currentDirection = arrowPosition.forward;
        //Vector3 playerDirection = player.transform.position - arrowPosition.position;
        //arrowPosition.forward = Vector3.RotateTowards(currentDirection, playerDirection, speed * 100, 180.0f);

        //Shot to player
        Rigidbody2D rb2d = newArrow.GetComponent<Rigidbody2D>();
        rb2d.velocity = (player.transform.position - newArrow.transform.position).normalized * arrowSpeed;

        //Rotate the arrow toward the player

        Vector3 targ = player.transform.position;
        targ.z = 0f;

        Vector3 objectPos = newArrow.transform.position;
        targ.x = targ.x - objectPos.x;
        targ.y = targ.y - objectPos.y;

        float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
        newArrow.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));



        // *********************

        Destroy(newArrow, 3.0f);


    }
}
