﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour 
{
    public string SceneToLoad = "";
    public float Delay = 0;

    private double ElapsedTime = 0;

    void Start()

    {
        StartCoroutine(delayThenLoadScene());
    }

    IEnumerator delayThenLoadScene()

    {
        yield return new WaitForSeconds(Delay);
        SceneManager.LoadScene(SceneToLoad);
    }
   
}