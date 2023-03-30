using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    private Timer timer;
    public float weight;
    public int value;
    public float speed;
    public float acceleration;
    public float Max_Speed;
    private Rigidbody2D move;
    public float DIR_X;
    private GameObject hook;
    public float hookstrength;
    private Vector2 fishdir;
    private bool ishooked;
    public ScoreManager theScoremanager;
    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<Rigidbody2D>();
        ishooked = false;
        hook = GameObject.FindWithTag("Hook");
        theScoremanager = FindObjectOfType<ScoreManager>();
        timer = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
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

        if(ishooked)
        {
            Hooked();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        if (collision.tag == "Hook")
        {
            move.velocity = new Vector2(0, 0);
            ishooked = true;
        }

        if (collision.tag == "Player")
        {
            Destroy(this.gameObject);
            theScoremanager.AddScore(value);
        }
    }

    void Hooked()
    {
        Vector2 ArttachedDirection = hook.transform.position - transform.position;
        GetComponent<Rigidbody2D>().AddForce(ArttachedDirection.normalized * hookstrength);
    }    
}
