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
        string pNameTemp= gameHandler.GetName();
        playerName = pNameTemp.ToUpper();


        ArtChar1.SetActive(false);
		SallyHalfAwake.SetActive(false);
		DialogueDisplay.SetActive(false);
		Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
		
		ArtBG1.SetActive(true);
        nextButton.SetActive(true);
		
        
        
        
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
       
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1.SetActive(false);
            DialogueDisplay.SetActive(true);
            Char1name.text = playerName;
            Char1speech.text = "Wakey wakey, Sally";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            SallyHalfAwake.SetActive(true);
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Wuh..? What happened?";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "YOU";
            Char1speech.text = "I've been watching you dead asleep.HAHAHAA";
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
            Char2speech.text = "That is creepy!!!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "You";
            Char1speech.text = "What is going to get you out of bed?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Why do you think I can keep awake?";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "You";
            Char1speech.text = "How about a cup of coffee?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I will think about it...";
        }

        else if (primeInt == 10)
        {
            Char1name.text = "You";
            Char1speech.text = "How about a cup of your favorite coffee?";
            Char2name.text = "";
            Char2speech.text = "";
        }


        else if (primeInt == 11)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Hm... that's getting warmer.";
        }

        else if (primeInt == 12)
        {
            Char1name.text = "You";
            Char1speech.text = "How about a cup of almond lattee?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 13)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I like where this is going...";
        }

        else if (primeInt == 14)
        {
            Char1name.text = "You";
            Char1speech.text = "How about a cup of sugar free almond latte?";
            Char2name.text = "";
            Char2speech.text = "";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }





        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "You";
            Char1speech.text = "Let me check your kitchen...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "zzzZZZ";
        }
        else if (primeInt == 102)
        {
            Char1name.text = "You";
            Char1speech.text = "Sally, you ran out of COFFEEEEE";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 103)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Quit the yelling. The roof is not falling down.";
        }

        else if (primeInt == 104)
        {
            Char1name.text = "You";
            Char1speech.text = "Human kitchen has plenty of coffee. If you really want the coffee, we need to head there.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 105)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "That's the best idea you had ALLLLLL morning!";

            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Are you serious?!";
        }

        else if (primeInt == 201)
        {
            Char1name.text = "You";
            Char1speech.text = "What did I do now?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 202)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Did you gulf down all of the milk?!?";
        }

        else if (primeInt == 203)
        {
            Char1name.text = "You";
            Char1speech.text = "I don't touch that junk. I'm lactose intolerant, remember?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 204)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Well, if my stuff is junk, only the human kitchen has your P R E C I O U S milk";
        }

        else if (primeInt == 205)
        {
            Char1name.text = "You";
            Char1speech.text = "FINE, let's go there. I'm not scared.";
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