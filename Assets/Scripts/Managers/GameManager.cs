﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public InputManager iMan;

    void Start()
    {
        iMan.running = KeyCode.LeftShift;
        iMan.crouching = KeyCode.C;
        iMan.jump = KeyCode.Space;
        iMan.shooting = KeyCode.Mouse0;
        iMan.reloading = KeyCode.R;
    }
}
