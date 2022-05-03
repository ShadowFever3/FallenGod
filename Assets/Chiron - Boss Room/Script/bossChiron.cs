using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossChiron : MonoBehaviour
{
    //Arrow parameter
    [SerializeField]
    GameObject arrow;
    [SerializeField]
    Transform arrowPosition;
    [SerializeField]
    int arrowSpeed;
    [SerializeField]
    float arrowTimer = 1.5f, tripleShotTimer = 2.0f;


    //Player parameter
    [SerializeField]
    GameObject player;

    //Player Location parameter
    [SerializeField]
    Transform teleportTarget_TL,
        teleportTarget_TR,
        teleportTarget_ML,
        teleportTarget_MR,
        teleportTarget_BL,
        teleportTarget_BR;

    bool arrowMoveLeft = false;
    bool arrowMoveRight = false;

    //Phase Parameter
    [SerializeField]
    bool phase1,
        phase2,
        final;

    [SerializeField]
    Animator anim;
    void Start()
    {
        //Set boss to 300 Health
        StatVarChiron.chironHealth = 500;
        StatVarChiron.isChironLeft = true;
        
    }



    void Update()
    {
        //***************************************************
        //                     PHASE ZERO
        //***************************************************

        if (StatVarChiron.chironHealth <= 500 && StatVarChiron.chironHealth > 250)
        {
            phase1 = true;
            phase2 = false;
            final = false;
        }
        if (StatVarChiron.chironHealth <= 250 && StatVarChiron.chironHealth > 0)
        {
            phase1 = false;
            phase2 = true;
            final = false;
        }
        if (StatVarChiron.chironHealth == 0)
        {
            phase1 = false;
            phase2 = false;
            final = true;
        }



        //***************************************************
        //                     PHASE ONE
        //***************************************************

        //Initializing phase one
        if (phase1 == false && phase2 == false)
        {
            phase1 = true;
        }

        if (phase1 == true)
        {
            if (arrowTimer > 0)
            {
                arrowTimer -= Time.deltaTime;
            }
            else
            {
                anim.SetTrigger("popUp");
                shotArrow(true);
                arrowTimer = 2;

            }
        }


        //***************************************************
        //                     PHASE TWO
        //***************************************************

        if (phase2 == true)
        {
            float randTp = UnityEngine.Random.Range(0, 2000);
            if (randTp == 1000)
            {
                tpRand();
            }
            if (tripleShotTimer > 0)
            {

                tripleShotTimer -= Time.deltaTime;
            }
            else
            {
                anim.SetTrigger("popUp");
                tripleShot();
                tripleShotTimer = 2;
            }
        }
        //***************************************************
        //                       FINAL
        //***************************************************
        if (final == true)
        {
            finalPhase();
        }
        //***************************************************
        //                       DEBUG
        //***************************************************
        if (Input.GetKeyDown(KeyCode.F1))
        {
            anim.SetTrigger("popUp");
            shotArrow(true);
        }
        else
        {

        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            tpRand();
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            anim.SetTrigger("popUp");
            tripleShot();
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            StatVarChiron.chironHealth -= 250;
        }


        if (arrowMoveLeft == true)
        {
            GameObject[] arrow = GameObject.FindGameObjectsWithTag("Arrow");
            foreach (GameObject arrow2 in arrow)
            {
                arrow2.transform.Translate(Vector2.left * Time.deltaTime * arrowSpeed);
            }
        }
        else
        {
            GameObject[] arrow = GameObject.FindGameObjectsWithTag("Arrow");
            foreach (GameObject arrow2 in arrow)
            {
                arrow2.transform.Translate(Vector2.right * Time.deltaTime * arrowSpeed);
            }
        }
        

    }

    private void finalPhase()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Ending");
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









    public void tripleShot()
    {
        GameObject arrowUp = Instantiate(arrow, arrowPosition.position, Quaternion.Euler(new Vector3(0, 0, 10)));
        GameObject arrowMid = Instantiate(arrow, arrowPosition.position, Quaternion.Euler(new Vector3(0, 0, 0)));
        GameObject arrowDown = Instantiate(arrow, arrowPosition.position, Quaternion.Euler(new Vector3(0, 0, -10)));

        Rigidbody2D rb2d = arrowMid.GetComponent<Rigidbody2D>();
        rb2d.velocity = (player.transform.position - arrowMid.transform.position).normalized * arrowSpeed;


        arrowUp.gameObject.tag = "Arrow";
        arrowMid.gameObject.tag = "Arrow";
        arrowDown.gameObject.tag = "Arrow";
        if (StatVarChiron.isChironLeft == true)
        {
            arrowUp.gameObject.transform.localScale = new Vector3(-4, 4, 1);
            arrowMid.gameObject.transform.localScale = new Vector3(-4, 4, 1);
            arrowDown.gameObject.transform.localScale = new Vector3(-4, 4, 1);
        }
        else
        {
            arrowUp.gameObject.transform.localScale = new Vector3(4, 4, 1);
            arrowMid.gameObject.transform.localScale = new Vector3(4, 4, 1);
            arrowDown.gameObject.transform.localScale = new Vector3(4, 4, 1);
        }

        //Ignore for arrow Up
        Physics2D.IgnoreCollision(arrowUp.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(arrowUp.GetComponent<Collider2D>(), arrowMid.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(arrowUp.GetComponent<Collider2D>(), arrowDown.GetComponent<Collider2D>());

        //Ignore for arrow Middle
        Physics2D.IgnoreCollision(arrowMid.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(arrowMid.GetComponent<Collider2D>(), arrowUp.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(arrowMid.GetComponent<Collider2D>(), arrowDown.GetComponent<Collider2D>());

        //Ignore for arrow Down
        Physics2D.IgnoreCollision(arrowDown.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(arrowDown.GetComponent<Collider2D>(), arrowMid.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(arrowDown.GetComponent<Collider2D>(), arrowUp.GetComponent<Collider2D>());

        Destroy(arrowUp, 3);
        Destroy(arrowMid, 3);
        Destroy(arrowDown, 3);

        if (StatVarChiron.isChironRight)
        {
            arrowMoveLeft = true;
            arrowMoveRight = false;
        }
        else
        {
            arrowMoveLeft = false;
            arrowMoveRight = true;
        }
        Debug.Log("Move Right? " + arrowMoveRight);
        Debug.Log("Move Left? " + arrowMoveLeft);
    }

    private void shotArrow(bool doRotate)
    {

        //Spawn arrow
        GameObject newArrow = Instantiate(arrow, arrowPosition.position, arrowPosition.rotation);
        //Ignore collision between arrow and Chiron 
        Physics2D.IgnoreCollision(newArrow.GetComponent<Collider2D>(), GetComponent<Collider2D>());




        //Shot to player
        Rigidbody2D rb2d = newArrow.GetComponent<Rigidbody2D>();
        rb2d.velocity = (player.transform.position - newArrow.transform.position).normalized * arrowSpeed;

        //Rotate the arrow toward the player
        if (doRotate == true)
        {
            Vector3 targ = player.transform.position;
            targ.z = 0f;

            Vector3 objectPos = newArrow.transform.position;
            targ.x = targ.x - objectPos.x;
            targ.y = targ.y - objectPos.y;

            float angle = Mathf.Atan2(targ.y, targ.x) * Mathf.Rad2Deg;
            newArrow.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            newArrow.transform.localScale = new Vector3(-4, 4);
        }
        // *********************

        Destroy(newArrow, 3.0f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Debug.Log(collision.gameObject.name);
            StatVarChiron.chironHealth -= 10;
            Debug.Log(StatVarChiron.chironHealth);
        }
    }
}