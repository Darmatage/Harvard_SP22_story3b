using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class NameTransfer : MonoBehaviour
{

    public string theName;
    public GameObject inputField;
    //public GameObject textDisplay;
    public GameHandler gameHandler;
    //public GameObject welcomeDisplay;

    void Start()
    {
        //welcomeDisplay.SetActive(false);
        theName = "YOU";
    }

    public void StoreName()
    {
        theName = inputField.GetComponentInChildren<Text>().text;
        //textDisplay.GetComponent<Text>().text = "Welcome, " + theName + ", to Sally's Latte.";
        //welcomeDisplay.SetActive(true);
        gameHandler.UpdateName(theName);
    }
}