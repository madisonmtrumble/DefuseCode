﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditLoad : MonoBehaviour
{
    public void OnMouseButton()
    {
        SceneManager.LoadScene("CreditsGood");
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}