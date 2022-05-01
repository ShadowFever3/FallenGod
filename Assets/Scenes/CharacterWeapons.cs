using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterWeapons : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject Character, projectile1, projectile2, projectile3, projectile4, secretprojectile, melee1, melee2;
    GameObject c, projectile, melee;

    bool ready, right, left, inair;

    private GameObject[] getCount, getCount1;

    int count, count1, HP;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(ready == true)
            {
            if(projectile == projectile3)
            {
                getCount = GameObject.FindGameObjectsWithTag("BombWeapon");
                count = getCount.Length;
                if(count < 3){
                    if(right == true){
                c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.3f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }
            Destroy(c, 5f);
            }else{
                StartCoroutine(waiter());
                }
            }else{
            getCount = GameObject.FindGameObjectsWithTag("Ammo");
            count = getCount.Length;
            if(count < 25){
            if(right == true && inair == false)
            {
            c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true && inair == false)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }if(right == true && projectile != projectile4)
            {
            c = Instantiate(projectile, Character.transform.position+(transform.right*0.15f), Character.transform.rotation);
            c.GetComponent<Rigidbody2D>().velocity = transform.right * 5;
            }else if(left == true && projectile != projectile4)
            {
                c = Instantiate(projectile, Character.transform.position+(-transform.right*0.15f), Character.transform.rotation);
                c.GetComponent<Rigidbody2D>().velocity = -transform.right * 5;
            }
            Destroy(c, 4f);
            }else
            {
                StartCoroutine(waiter());
            }
            }
            }
        }

        IEnumerator waiter()
    {

        ready = false;

        yield return new WaitForSeconds(8);

        ready = true;
    }
    }
}
