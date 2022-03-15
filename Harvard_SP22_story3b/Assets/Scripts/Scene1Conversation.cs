using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Conversation : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public string playerName;
  
    public GameHandler gameHandler; 
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    //public Text Char3name;
    //public Text Char3speech;
    public GameObject DialogueDisplay;
    public GameObject ArtChar1;
    public GameObject SallyHalfAwake;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    //public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameHandler gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;
   
    void Start()
    {         // initial visibility settings
        // Get player name
       

        ArtChar1.SetActive(false);
		SallyHalfAwake.SetActive(false);
		DialogueDisplay.SetActive(false);
		Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
		
		ArtBG1.SetActive(true);
        nextButton.SetActive(true);
		 string pNameTemp= gameHandler.GetName();
        playerName = pNameTemp.ToUpper();

        
        
        
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    //Story Units:
    public void talking()
    {         // main story function. Players hit next to progress to next int
       Char1name.text=playerName;
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1.SetActive(false);
            DialogueDisplay.SetActive(true);
            //Char1name.text = playerName;
            Char1speech.text = "zzzZZZZ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            SallyHalfAwake.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Wake up, wake up!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = playerName;
            Char1speech.text = "Wuh..? What happened?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            SallyHalfAwake.SetActive(false);
            ArtChar1.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I've been watching you dead asleep. ";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = playerName;
            Char1speech.text = "Why would you do that?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I am waiting for the moment to wake you up!";
        }
        else if (primeInt == 8)
        {
            Char1name.text = playerName;
            Char1speech.text = "Find something better to do! ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "What is going to get you out of bed?";
        }

        else if (primeInt == 10)
        {
            Char1name.text = playerName;
            Char1speech.text = "Why do you think I can keep awake?";
            Char2name.text = "";
            Char2speech.text = "";
        }


        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "How about a cup of coffee?";
        }

        else if (primeInt == 12)
        {
            Char1name.text = playerName;
            Char1speech.text = "I will think about it...";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "How about a cup of your favorite coffee?";
        }

        else if (primeInt == 14)
        {
            Char1name.text = playerName;
            Char1speech.text = "Hm... that's getting warmer.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 15)
        {
            Char1name.text = playerName;
            Char1speech.text = "I like where this is going...";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 16)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "How about a cup of sugar free almond latte?";

            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }



        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = playerName;
            Char1speech.text = "Sally, you better find coffee before I get out of bed.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I?m on it!";
        }
        else if (primeInt == 102)
        {
            Char1name.text = playerName;
            Char1speech.text = "What is taking so long?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 103)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I can?t find any coffee!";
        }

        else if (primeInt == 104)
        {
            Char1name.text = playerName;
            Char1speech.text = "Sally, I can't keep my eyes open...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 105)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "No. You are coming with me. ";
        }

        else if (primeInt == 106)
        {
            Char1name.text = playerName;
            Char1speech.text = "Why?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 107)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "We are getting coffee in the human kitchen!";
        }

        else if (primeInt == 108)
        {
            Char1name.text = playerName;
            Char1speech.text = "I'd rather sleep.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 109)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I saw the chef putting in a new patch of coffee yesterday! ";
        }

        else if (primeInt == 110)
        {
            Char1name.text = playerName;
            Char1speech.text = "Oh, Oh! Why didn?t you say that earlier?";
            Char2name.text = "";
            Char2speech.text = "";

            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = playerName;
            Char1speech.text = "Sally, you better find milk before I get out of bed.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Are you serious?!";
        }

        else if (primeInt == 202)
        {
            Char1name.text = playerName;
            Char1speech.text = "You are yelling, Sally. I?m still in bed.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Where is the leftover milk?!?";
        }

        else if (primeInt == 204)
        {
            Char1name.text = playerName;
            Char1speech.text = "My eardrum...the roof is not falling down.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 205)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "You need to tell me when something is running out. ";
        }

        else if (primeInt == 206)
        {
            Char1name.text = playerName;
            Char1speech.text = "That is definitely NOT me!  I'm lactose intolerant, remember?";
            Char2name.text = "";
            Char2speech.text = "";
        }


        else if (primeInt == 207)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Oh, that is right.";
        }

        else if (primeInt == 208)
        {
            Char1name.text = playerName;
            Char1speech.text = "Sally, I need an apology. ";
            Char2name.text = "";
            Char2speech.text = "";
        }


        else if (primeInt == 209)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Fine, sorry! Only the human kitchen has your lactose free milk. ";
        }

        else if (primeInt == 210)
        {
            Char1name.text = playerName ;
            Char1speech.text = "Let?s go then. I?m not scared. ";
            Char2name.text = "";
            Char2speech.text = "";
        
        nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("Scene2");
    }

}   