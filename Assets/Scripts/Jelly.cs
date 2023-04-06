using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jelly : Enemy
{
    public GameObject Zap;
    private HealthMeter healthmeter;
    private ScoreManager theScoremanager;
    private Rigidbody2D move;

    private GameObject hook;
    private Vector2 fishdir;
    private bool ishooked;

    private bool canDamage = true;
    private bool Damaging;
    private float damageTime = 0.5f;
    private float DamageCooldown = 1f;
    private AudioSource Elec;

    private void Start()
    {
        move = GetComponent<Rigidbody2D>();
        hook = GameObject.FindWithTag("Hook");
        ishooked = false;
        theScoremanager = FindObjectOfType<ScoreManager>();
        healthmeter = FindObjectOfType<HealthMeter>();
        Elec = GetComponent<AudioSource>();
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
            ishooked = true;

            StartCoroutine(Damage());


        }

        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
    }

    private IEnumerator Damage()
    {
        canDamage = false;
        Damaging = true;//Damaging

        theScoremanager.AddScore(value);
        healthmeter.Increase(value);
        Elec.Play();
        Instantiate(Zap, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(damageTime);
        Damaging = false;
        yield return new WaitForSeconds(DamageCooldown);
        canDamage = true;
    }
}
