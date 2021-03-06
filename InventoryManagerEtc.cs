using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManagerEtc : MonoBehaviour
{
    //computer screen, bomb puzzle, and guide book activation
    public GameObject CompText;
    public GameObject Bombpuzzle;
    public GameObject Guidebook;
    public GameObject Distraction;

    //msg system
    public Text message;
    void UpdateMessage()
    {
        if (DoorKey.activeInHierarchy == false)
        {
            message.text = "Player has collected the door key.";
        }

        if (BriefcaseCode.activeInHierarchy == false)
        {
            message.text = "Player has collected a code.";
        }


    }




    //Audio
    public AudioClip mySound;
    public AudioSource mySource;
    public float myVolume = 1.0f;

    //inventory and keys for locked things
    public List<GameObject> Inventory = new List<GameObject>();
    int sizeOfList;
    public GameObject DoorKey;
    public GameObject Door;
    public GameObject BriefcaseCode;
    public void AddItemToList(GameObject ItemToAdd)
    {
        Inventory.Add(ItemToAdd);
    }

    private void OnTriggerEnter(Collider other)
    {
        // for the locked door
        if (other.gameObject.name == "LockedDoor" && (Inventory.Contains(DoorKey)))
        {
            Door.transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }
        else
        {
            Debug.Log("The door is locked!");

            message.text = "The door is locked!";
        }

        // for the bomb
        if (other.gameObject.name == "Bomb" && (Inventory.Contains(BriefcaseCode)))
        {
            Bombpuzzle.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            message.text = "You need a code to access the case...";
        }

        //for the guide book
        if (other.gameObject.name == "GuideObj")
        {
            Guidebook.SetActive(true);
        }

        //distraction
        if (other.gameObject.name == "DistractingBook")
        {
            Distraction.SetActive(true);
        }

        if (other.gameObject.name == "Distracting Object")
        {
            message.text = "Distraction!";
        }

        
    }

    private void OnTriggerExit(Collider other)
    {
        // for the locked door
        if (other.gameObject.name == "LockedDoor" && (Inventory.Contains(DoorKey)))
        {
            Door.transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else
        {

            message.text = "";
        }

        // for the bomb
        if (other.gameObject.name == "Bomb" && (Inventory.Contains(BriefcaseCode)))
        {
            Bombpuzzle.SetActive(false);
        }
        else
        {
            message.text = "You need a code to access the case...";
        }

        //for the guide book
        if (other.gameObject.name == "GuideObj")
        {
            Guidebook.SetActive(false);
        }

        //distraction
        if (other.gameObject.name == "DistractingBook")
        {
            Distraction.SetActive(false);
        }

    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        UpdateMessage();
        

        if (Inventory.Count == 3)
        {
            CompText.SetActive(true);
        }


    }
}
