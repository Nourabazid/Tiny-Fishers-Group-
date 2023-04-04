using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer linerender;
    private Transform[] points;

    private void Awake()
    {
        linerender = GetComponent<LineRenderer>();
    }

    public void SetUpLine(Transform[] points)
    {
        linerender.positionCount = points.Length;
        this.points = points;
    }
    private void Update()
    {
        for(int i=0;i<points.Length;i++)
        {
            linerender.SetPosition(i, points[i].position);
        }
    }
}
