using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour
{
    public static float HP;


    void OnEnable()
    {
        ScoreSystem.updateUI += UpdateText;
    }
    void OnDisable()
    {
        ScoreSystem.updateUI -= UpdateText;
    }


    void UpdateText(float HPui)
    {
         GetComponent<Text>().text = "Health:" + HPui;  
    }
}
