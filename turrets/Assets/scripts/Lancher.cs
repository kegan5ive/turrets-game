﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lancher : MonoBehaviour 
{
    public string StartingScene = "";

    void Start() 
    {
        SceneManager.LoadScene(StartingScene);
    }
}
