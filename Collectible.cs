using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectible : MonoBehaviour
{
    

    public GameObject Key;
    public GameObject Cabinet;
    public GameObject BriefcaseCode;
    public GameObject DoorKey;
    
    public AudioClip mySound;
    public AudioSource mySource;
    public float myVolume = 1.0f;
    public Text message;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);

            Debug.Log("Player has entered pick up zone");

            mySource.PlayOneShot(mySound, myVolume);

            GameObject.FindGameObjectWithTag("Player").GetComponent<InventoryManagerEtc>().AddItemToList(gameObject);

        }
    }

}