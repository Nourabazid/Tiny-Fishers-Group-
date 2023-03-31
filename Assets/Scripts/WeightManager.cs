using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeightManager : MonoBehaviour
{
    public float Totalweight=0;
    public float Max_Weight = 16;
    public Image WeightIcon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BarFiller();
    }

    void BarFiller()
    {
        WeightIcon.fillAmount = Totalweight/Max_Weight;
    }

   public void AddWeight(float toAdd)
    {
        Totalweight += toAdd;
    }

    public void Reset()
    {
        Totalweight = 0;
    }
}
