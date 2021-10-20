using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputSystemKeyboard : MonoBehaviour
{

    public float hor { get; private set; }
    public float ver { get; private set; }

    public event Action lClick = delegate { };

   

    public event Action Space = delegate { };

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
        ver = Input.GetAxisRaw("Vertical");

        if (Input.GetButtonDown("Fire1")) lClick();
        
        if (Input.GetKeyDown("space")) Space();

    }
}
