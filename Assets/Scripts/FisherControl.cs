using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FisherControl : MonoBehaviour
{
    public float Speed;
    public float deceleration;
    public float accleration;
    public float Max_Speed;
    private Rigidbody2D move;
    private Vector2 PlayerDir;
    private float Dir_X;
    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Dir_X = Input.GetAxisRaw("Horizontal");
        PlayerDir = new Vector2(Dir_X,0).normalized;
    }

    void FixedUpdate()
    {
        move.AddForce(new Vector2(PlayerDir.x,0) * accleration);
        Speed = move.velocity.x;
        if (Mathf.Abs(move.velocity.x) > Max_Speed )
        {
            move.velocity = new Vector2(Mathf.Sign(move.velocity.x) * Max_Speed,0);//Recieve the moving spped in real time,limit the max speed.
        }

        if ((Dir_X == 0) && (Speed != 0))
        {
            move.AddForce(new Vector2(Mathf.Sign(move.velocity.x) * (-deceleration),0));
            /*I realized that if the Acceleration and deceleration don't match ,
             * which means that after a delta time the velovity can't be decrease to 0,
             * the velocity will bouns around 0, making it feel like floating.*/
        }
    }
}
