using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Blowup : MonoBehaviour
{
    public void OnMouseButton()
    {
        SceneManager.LoadScene("CreditsBad");
        Debug.Log("ButtonPressed");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
