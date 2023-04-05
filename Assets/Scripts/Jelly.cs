using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jelly : Enemy
{
    public GameObject zap;

    private Timer timer;
    private ScoreManager theScoremanager;
    private Rigidbody2D move;

    private GameObject hook;
    private Vector2 fishdir;
    private bool ishooked;
    private void Start()
    {
        move = GetComponent<Rigidbody2D>();
        hook = GameObject.FindWithTag("Hook");
        ishooked = false;
        theScoremanager = FindObjectOfType<ScoreManager>();
        timer = FindObjectOfType<Timer>();
    }

    void Update()
    {
        fishdir = new Vector2(DIR_X, 0).normalized;
    }

    private void FixedUpdate()
    {
        move.AddForce(new Vector2(fishdir.x, 0) * acceleration);
        speed = move.velocity.x;
        if (Mathf.Abs(move.velocity.x) > Max_Speed)
        {
            move.velocity = new Vector2(Mathf.Sign(move.velocity.x) * Max_Speed, 0);//Recieve the moving spped in real time,limit the max speed.
        }//Keep the fish moving
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Hook")
        {
           
                Instantiate(zap, transform.position, transform.rotation);
                theScoremanager.AddScore(value);

        }

        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }
}
