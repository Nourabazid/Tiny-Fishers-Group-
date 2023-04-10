using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionPage : MonoBehaviour
{
    public Transform CameraPos;
    private int pagenum;
    
    // Start is called before the first frame update
    void Start()
    {
        pagenum = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(pagenum>3)
        {
            pagenum = 1; 
        }
    }

    public void pagemove()
    {
        pagenum++;
    }

    private void page()
    {
        if(pagenum==1)
        {
            CameraPos.transform.position = new Vector3(0, 10.48f, -10.0f);
        }

       else if (pagenum == 2)
        {
            CameraPos.transform.position = new Vector3(0, 0, -10.0f);
        }

        else if (pagenum == 3)
        {
            CameraPos.transform.position = new Vector3(0, -10.32f, -10.0f);
        }
    }
}
