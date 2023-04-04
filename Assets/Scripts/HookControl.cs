using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookControl : MonoBehaviour
{
    public float Speed_Y;
    public float deceleration;
    public float accleration;
    public float Max_Speed;
    public GameObject player;
    private Rigidbody2D move;
    private float Dir_Y;
    private Vector2 HookDir;

    // Start is called before the first frame update
    void Start()
    {
        move = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Dir_Y = Input.GetAxisRaw("Vertical");
        HookDir = new Vector2(0, Dir_Y).normalized;

    }

    private void FixedUpdate()
    {
        move.AddForce(HookDir * accleration);
        Speed_Y = move.velocity.y;
        if (Mathf.Abs(move.velocity.y) > Max_Speed)
        {
            move.velocity = new Vector2(move.velocity.x, Mathf.Sign(move.velocity.y) * Max_Speed);//Recieve the moving spped in real time,limit the max speed.
        }

        if ((Dir_Y == 0) && (Speed_Y != 0))
        {
            move.AddForce(new Vector2(0, Mathf.Sign(move.velocity.y) * (-deceleration)));
            /*I realized that if the Acceleration and deceleration don't match ,
             * which means that after a delta time the velovity can't be decrease to 0,
             * the velocity will bouns around 0, making it feel like floating.*/
        }

    }
}

