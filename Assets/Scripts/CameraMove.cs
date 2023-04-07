using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private int pagenum=1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pagenum>3)
        { pagenum = 1; }
        pagemove();
    }

    public void pagemove()
    {
        pagenum++;
    }

    private void page()
    {
        if(pagenum==1)
        {
            transform.position = new Vector3(0, 10.48f, -10);
        }

        if (pagenum == 2)
        {
            transform.position = new Vector3(0, 10.48f, -10);
        }

        if (pagenum == 3)
        {
            transform.position = new Vector3(0, 10.48f, -10);
        }
    }
}
