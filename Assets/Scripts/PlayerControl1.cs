using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl1 : MonoBehaviour
{
    Vector3 playerpositon;
    float PI = 3.141592f;
    void Start()
    {
        playerpositon = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerpositon.y = Mathf.Sin(1.5f*PI*Time.time)/4+ 2.21f;
        playerpositon.x = Mathf.Sin(0.5f * PI * Time.time) / 4 - 6.18f;
        transform.position = playerpositon;
    }

    void FixedUpdate()
    {
       
    }
}
