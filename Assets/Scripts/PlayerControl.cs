using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Vector3 playerpositon;
    void Start()
    {
        playerpositon = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        playerpositon.y = Mathf.Sin(Time.time)+ 2.21f;
        transform.position = playerpositon;
    }

    void FixedUpdate()
    {
       
    }
}
