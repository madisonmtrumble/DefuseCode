using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Defuse : MonoBehaviour
{
    public void OnMouseButton()
    {
        SceneManager.LoadScene("CreditsGood");
        Debug.Log("Button Pressed");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnTriggerEnter(Collider other)
    {
        
    }
}
