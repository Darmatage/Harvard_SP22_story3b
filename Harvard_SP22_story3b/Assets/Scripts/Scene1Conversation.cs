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
    public GameObject SallyWakingUp;
    public GameObject SallyHalfAwake;
    public GameObject SallyHalfAwakeCoffee;
    public GameObject SallyWink;
    public GameObject SallyShouting;
    public GameObject SallyHappy;
    public GameObject SallyDissatisfied;
    public GameObject SallyPuzzled;
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
       

        SallyWakingUp.SetActive(false);
		SallyHalfAwake.SetActive(false);
        SallyHalfAwakeCoffee.SetActive(false);
        SallyWink.SetActive(false);
        SallyShouting.SetActive(false);
        SallyHappy.SetActive(false);
        SallyDissatisfied.SetActive(false);
        SallyPuzzled.SetActive(false);
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
            SallyWakingUp.SetActive(true);
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyWink.SetActive(false);
            SallyShouting.SetActive(false);
            SallyHappy.SetActive(false);

            DialogueDisplay.SetActive(true);

            //Char1name.text = playerName;
            Char1speech.text = "zzzZZZZ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            SallyWakingUp.SetActive(false);
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(true);

            DialogueDisplay.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Wake up, wake up!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyHalfAwake.SetActive(true);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "Wuh..? What happened?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(true);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I've been watching you dead asleep. ";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            SallyWink.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyHalfAwake.SetActive(true);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHappy.SetActive(false);


            Char1name.text = playerName;
            Char1speech.text = "Why would you do that?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {

            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyHalfAwake.SetActive(false);
            SallyWink.SetActive(true);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHappy.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I am waiting for the moment to wake you up!";
        }
        else if (primeInt == 8)
        {
            SallyWink.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyHalfAwake.SetActive(true);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHappy.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "You know you could have better use of your time. ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 9)
        {
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyHalfAwake.SetActive(false);
            SallyWink.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHappy.SetActive(true);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Well, I'd like to invite you to get out of bed.";
        }

        else if (primeInt == 10)
        {
            SallyHappy.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyHalfAwake.SetActive(true);
            SallyWink.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "I cannot keep awake, Sally.";
            Char2name.text = "";
            Char2speech.text = "";
        }


        else if (primeInt == 11)
        {

            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyHalfAwake.SetActive(false);
            SallyWink.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHappy.SetActive(true);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "How about a cup of coffee?";
        }

        else if (primeInt == 12)
        {
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHappy.SetActive(false);
            SallyHalfAwake.SetActive(true);

            Char1name.text = playerName;
            Char1speech.text = "I will think about it...";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 13)
        {
            SallyHalfAwake.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHappy.SetActive(true);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "How about a cup of your favorite coffee?";
        }

        else if (primeInt == 14)
        {
            SallyHalfAwake.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(true);

            Char1name.text = playerName;
            Char1speech.text = "Hm... that's getting warmer.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 15)
        {
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHalfAwake.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(true);


            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "How about a cup of almond latte?";
        }

        else if (primeInt == 16)
        {
            SallyHalfAwakeCoffee.SetActive(true);
            SallyHalfAwake.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "I like where this is going...";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 17)
        {
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHalfAwake.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(true);

            Char1name.text ="";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "How about a cup of sugar free almond latte?";
        }
        else if (primeInt == 18)
        {
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHalfAwake.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "Sally, would you find coffee or milik before I get out of bed? ";
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
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHalfAwake.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I am on it!";
        }
        else if (primeInt == 101)
        {
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHalfAwake.SetActive(true);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "Any luck?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 103)
        {
            SallyHalfAwakeCoffee.SetActive(false);
            SallyHalfAwake.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I cannot find any coffee!";
        }

        else if (primeInt == 104)
        {
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(true);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyHalfAwake.SetActive(true);

            Char1name.text = playerName;
            Char1speech.text = "Sally, I cannot keep my eyes open...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 105)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
          
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "You are coming with me nonetheless. ";
        }

        else if (primeInt == 106)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(true);

            Char1name.text = playerName;
            Char1speech.text = "Why?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 107)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "We are getting coffee in the human kitchen!";
        }

        else if (primeInt == 108)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(true);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "I would rather sleep.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 109)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I saw the chef putting in a new patch of coffee yesterday! ";
        }

        else if (primeInt == 110)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(true);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "Oh, Oh! You could have said that earlier!";
            Char2name.text = "";
            Char2speech.text = "";

            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(true);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "Sally, you better find milk before I get out of bed.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 201)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "I'm on it!";
        }

        else if (primeInt == 202)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(true);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "You are yelling, Sally. I am still in bed.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 203)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Where is the leftover milk?!?";
        }

        else if (primeInt == 204)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(true);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "My eardrum...the roof is not falling down.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 205)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(true);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(true);
            SallyPuzzled.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "You need to tell me when something is running out. ";
        }

        else if (primeInt == 206)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(true);

            Char1name.text = playerName;
            Char1speech.text = "That is definitely NOT me!  I'm lactose intolerant, remember?";
            Char2name.text = "";
            Char2speech.text = "";
        }


        else if (primeInt == 207)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(true);
            SallyPuzzled.SetActive(false);

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Oh, that is right.";
        }

        else if (primeInt == 208)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(true);
            SallyHappy.SetActive(false);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = playerName;
            Char1speech.text = "Sally, I need an apology. ";
            Char2name.text = "";
            Char2speech.text = "";
        }


        else if (primeInt == 209)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(true);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Sally";
            Char2speech.text = "Fine, sorry! Only the human kitchen has your lactose free milk. ";
        }

        else if (primeInt == 210)
        {
            SallyHalfAwake.SetActive(false);
            SallyHalfAwakeCoffee.SetActive(false);
            SallyShouting.SetActive(false);
            SallyWakingUp.SetActive(false);
            SallyWink.SetActive(false);
            SallyHappy.SetActive(true);
            SallyDissatisfied.SetActive(false);
            SallyPuzzled.SetActive(false);

            Char1name.text = playerName ;
            Char1speech.text = "Let us go then. I am not scared. ";
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