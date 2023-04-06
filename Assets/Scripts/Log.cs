using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    private Timer timer;
    private ScoreManager theScoremanager;
    private WeightManager theWeightmanager;
    private HealthMeter healthmeter;

    AudioSource fishcatch;

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

    // Start is called before the first frame update
    void Start()
    {
        theScoremanager = FindObjectOfType<ScoreManager>();
        timer = FindObjectOfType<Timer>();
        theWeightmanager = FindObjectOfType<WeightManager>();
        healthmeter = FindObjectOfType<HealthMeter>();
        move = GetComponent<Rigidbody2D>();
        ishooked = false;
        hook = GameObject.FindWithTag("Hook");

        fishcatch = GetComponent<AudioSource>();
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

        if (ishooked)
        {
            Hooked();
        }

        if (theWeightmanager.Totalweight > theWeightmanager.Max_Weight)
        {
            ishooked = false;
            theWeightmanager.Totalweight = 0;
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
            theWeightmanager.AddWeight(weight);
        }

        if (collision.tag == "Player")
        {
            StartCoroutine(Catched());
        }
    }

    void Hooked()
    {
        Vector2 ArttachedDirection = hook.transform.position - transform.position;
        GetComponent<Rigidbody2D>().AddForce(ArttachedDirection.normalized * hookstrength);
    }

    private IEnumerator Catched()
    {
        theScoremanager.AddScore(value);
        theWeightmanager.Reset();
        yield return new WaitForSeconds(0.5f);
        Destroy(this.gameObject);
    }
}
