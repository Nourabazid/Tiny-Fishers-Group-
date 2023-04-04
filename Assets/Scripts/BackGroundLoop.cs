using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundLoop : MonoBehaviour
{
    public float backgroundSpeed=0;
    public Renderer backgroundrender;
    public GameObject player;

    private void Start()
    {
       //backgroundSpeed = player.GetComponent<Rigidbody2D>().velocity.x;
    }
    // Update is called once per frame
    void Update()
    {
        backgroundrender.material.mainTextureOffset += new Vector2(backgroundSpeed * Time.deltaTime, 0f);
    }
}
