using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2Dialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       // public Text Char3name;
       // public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
		 public GameObject smilingmouse;
		 public GameObject mouseback;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject ButtonScene3a;
        public GameObject ButtonScene3b;
        public GameObject nextButton;
       public GameHandler gameHandler;
	    public string playerName;
      // public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		nextButton.SetActive(true);
		ArtChar1.SetActive(false);
		smilingmouse.SetActive(false);
		mouseback.SetActive(false);
		ButtonScene3a.SetActive(false);
        ButtonScene3b.SetActive(false);
		
        DialogueDisplay.SetActive(false);
		ArtBG1.SetActive(true);
		 string pNameTemp = gameHandler.GetName();
       playerName = pNameTemp.ToUpper();
        
        
		
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
			   // ArtChar1.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = playerName;
                Char1speech.text = "I know the pantry has coffee???";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                mouseback.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Sally";
                Char2speech.text = "Do you smell that?";
				nextButton.SetActive(false);
               allowSpace = false;
				Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
                //gameHandler.AddPlayerStat(1);
        }
       /*else if (primeInt == 4){
                ArtChar1.SetActive(false);
				Char1name.text = playerName;
                Char1speech.text = "Let's get coffee!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                ArtChar1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MOUSE";
                Char2speech.text = "Oooooh! Is that strawberry shortcake?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                ArtChar1.SetActive(false);
				Char1name.text = playerName;
                Char1speech.text = "Let's not get too greedy here!";
                Char2name.text = "";
               Char2speech.text = "";
        }
       else if (primeInt ==7){
                ArtChar1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "MOUSE";
               Char2speech.text = "That cake will go so well with my coffee...";
				
        }
       else if (primeInt == 8){
              ArtChar1.SetActive(false);
			  Char1name.text = "";
              Char1speech.text = "";
                Char2name.text = "";
              Char2speech.text = "";
                 //Turn off "Next" button, turn on "scene" buttons
			nextButton.SetActive(false);
               allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
		*/
		
// ENCOUNTER AFTER CHOICE #1
      else if (primeInt == 100){
               mouseback.SetActive(false);
			   ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Sniff...sniff...";
       }
	   else if (primeInt == 101){
               ArtChar1.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Sniff...";
               Char2name.text = "";
               Char2speech.text = "";
       }
      else if (primeInt == 102){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "It smells sweet";
	  }
	  else if (primeInt == 103){
               smilingmouse.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "It does...";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 104){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "I know that sweeeet smell anywhere...";
	  }
	  else if (primeInt == 105){
               smilingmouse.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Sniff..sniff...is that...";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 106){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "YOU and Sally";
               Char2speech.text = "STRAWBERRY SHORTACKE!";
	  }
	  else if (primeInt == 107){
               ArtChar1.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "What about the coffee in the pantry?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
      else if (primeInt == 108){
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "";
               Char2speech.text = "";
			   ButtonScene3a.SetActive(true);
	           ButtonScene3b.SetActive(true);
               nextButton.SetActive(false);
               allowSpace = false;
               DialogueDisplay.SetActive(false);
       }

      else if (primeInt == 200){
		  mouseback.SetActive(false);
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Sniff...sniff...";
	  }
	  else if (primeInt == 201){
               smilingmouse.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "NOW what is it, Sally?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 202){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "I know that sweeeet smell anywhere...";
	  }
	  else if (primeInt == 203){
               smilingmouse.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Sniff..sniff...is that...";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 204){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "YOU and Sally";
               Char2speech.text = "STRAWBERRY SHORTACKE!";
	  }
	  else if (primeInt == 205){
              ArtChar1.SetActive(true);
			  Char1name.text = "";
              Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Well, why can't we get some cake then head to the PANTRY?";
       }
	   
	         else if (primeInt == 206){
               ArtChar1.SetActive(false);
			   Char1name.text = playerName;
              Char1speech.text = "I don't know...I have a bad feeling about it...";
               Char2name.text = "";
               Char2speech.text = "";
       }
	    else if (primeInt == 207){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
              Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Just imagine...the cake melts in your mouth...with the first sip of some warm latte";
       }
      else if (primeInt == 208){
               Char1name.text = playerName;
               Char1speech.text = "Hmmm...";
              Char2name.text = "";
               Char2speech.text = "";
               nextButton.SetActive(false);
               allowSpace = false;
              ButtonScene3a.SetActive(true);
			ButtonScene3b.SetActive(true);
			//DialogueDisplay.SetActive(false);
        }
     }

//FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
       public void Choice1aFunct(){
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "I do smell something...";
               Char2name.text = "";
               Char2speech.text = "";
               primeInt = 99;
               Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }
       public void Choice1bFunct(){
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Why can't we just get to the PANTRY?";
               Char2name.text = "";
               Char2speech.text = "";
               primeInt = 199;
              Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }

        public void SceneChange1(){
			    SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3b");
        }
}