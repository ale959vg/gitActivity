using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class ScoreSystem : MonoBehaviour
{
    //public float HP;

    public static event Action <float>updateUI = delegate { };

    
    void OnEnable()
    {
        GetComponent<Health>().HPlost += UpdateStats;

    }
    void OnDisable()
    {
        GetComponent<Health>().HPlost -= UpdateStats;
    }

    void UpdateStats(float HPreceive)
    {
       // HP = HPreceive;

        updateUI(HPreceive);
    }
}
