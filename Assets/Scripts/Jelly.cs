using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jelly : Enemy
{
    public GameObject zap;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Hook")
        {
           
                Instantiate(zap, transform.position, transform.rotation);
                new WaitForSeconds(5);
                Destroy(zap.gameObject);

        }
    }
    }
