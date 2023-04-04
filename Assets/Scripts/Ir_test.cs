using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ir_test : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private LineController line;

    private void Start()
    {
        line.SetUpLine(points);
    }
}
