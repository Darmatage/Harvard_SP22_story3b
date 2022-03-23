using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class EndScene1 : MonoBehaviour
{
    public GameObject ImageBG;
    public GameObject ImageChar1;
    public Text TextTitle;
    public Text TextExplain;

    public GameObject ButtonQuit;
    public Text ButtonQuitText;
    public GameHandler gameHandler;

    //public GameObject MusicManager;
    public AudioSource MusicManager;

    void Start()
    {         // initial visibility settings
        
        ImageBG.SetActive(true);
        ImageChar1.SetActive(true);
        ButtonQuit.SetActive(true);
       

    }
}
