﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsCounter : MonoBehaviour
{

    public int FPS;
    //You can hook up an input for this to toggle the fps counter on or off.
    bool toggleFPS = true;

    private void Update()
    {
        FPS = (int)(1 / Time.unscaledDeltaTime);
    }

    private void OnGUI()
    {
        if (!toggleFPS)
        {
            return;
        }

        GUI.Box(new Rect(10,10,50,25), FPS.ToString());

    }

}
