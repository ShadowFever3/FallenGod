using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossShooting : MonoBehaviour
{
    [SerializeField]
    GameObject Boss;

    GameObject c;

    int BossHP;

    bool textp;

[SerializeField]
    Text d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14;
    // Start is called before the first frame update
    void Start()
    {
        BossHP = 750;

        d1.gameObject.SetActive(true);
        d2.gameObject.SetActive(false);
        d3.gameObject.SetActive(false);
        d4.gameObject.SetActive(false);
        d5.gameObject.SetActive(false);
        d6.gameObject.SetActive(false);
        d7.gameObject.SetActive(false);
        d8.gameObject.SetActive(false);
        d9.gameObject.SetActive(false);
        d10.gameObject.SetActive(false);
        d11.gameObject.SetActive(false);
        d12.gameObject.SetActive(false);
        d13.gameObject.SetActive(false);
        d14.gameObject.SetActive(false);
        textp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if(textp == true)
            {

            }else{
            textp = true;
        StartCoroutine(wait());
        }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch(collision.gameObject.tag){
            case "Ammo":
            BossHP -= 1;
        if(BossHP >= 1){
        }else{
            Destroy(Boss);
        }
            break;

            case "BombWeapon":
            BossHP -= 100;
        if(BossHP >= 1){
        }else{
            Destroy(Boss);
        }
            break;

            case "ShotgunAmmo":
            BossHP -= 5;
        if(BossHP >= 1){
        }else{
            Destroy(Boss);
        }
        break;

        case "Melee":
        BossHP -= 5;
        if(BossHP >= 1){
        }else{
            Destroy(Boss);
        }
        break;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "harm" || collision.gameObject.tag == "MeleeHarm" || collision.gameObject.tag == "Untagged")
        {

        }else{
        BossHP -= 2;
        if(BossHP >= 1){
        }else{
            Destroy(Boss);
        }
        }
    }

    IEnumerator wait()
    {
        Debug.Log("2");
        d1.gameObject.SetActive(false);
        d2.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("3");
        d2.gameObject.SetActive(false);
        d3.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("4");
        d3.gameObject.SetActive(false);
        d4.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("5");
        d4.gameObject.SetActive(false);
        d5.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("6");
        d5.gameObject.SetActive(false);
        d6.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("7");
        d6.gameObject.SetActive(false);
        d7.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("8");
        d7.gameObject.SetActive(false);
        d8.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("9");
        d8.gameObject.SetActive(false);
        d9.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("10");
        d9.gameObject.SetActive(false);
        d10.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("11");
        d10.gameObject.SetActive(false);
        d11.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("12");
        d11.gameObject.SetActive(false);
        d12.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("13");
        d12.gameObject.SetActive(false);
        d13.gameObject.SetActive(true);
        yield return new WaitForSeconds(6);
        Debug.Log("14");
        d13.gameObject.SetActive(false);
        d14.gameObject.SetActive(true);
    }
    }
