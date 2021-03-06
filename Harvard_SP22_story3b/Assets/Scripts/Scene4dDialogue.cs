using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4dDialogue : MonoBehaviour {
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
		 public GameObject sallydissatisfied;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject ButtonScene3a;
        public GameObject ButtonScene3b;
        public GameObject nextButton;
       public GameHandler gameHandler;
	    public string playerName;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		nextButton.SetActive(true);
		ArtChar1.SetActive(false);
		smilingmouse.SetActive(false);
		sallydissatisfied.SetActive(false);
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
                Char1speech.text = "There???s nothing like freshly baked cake!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                smilingmouse.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SALLY";
                Char2speech.text = "Mmmm???there???s nothing like freshly baked strawberry shortcake!";
				//nextButton.SetActive(false);
              // allowSpace = false;
				//Choice1a.SetActive(true); // function Choice1aFunct()
               // Choice1b.SetActive(true); // function Choice1bFunct()
                //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4){
			   // ArtChar1.SetActive(true);
			    smilingmouse.SetActive(false);
                DialogueDisplay.SetActive(true);
                Char1name.text = playerName;
                Char1speech.text = "The Chef might have just pulled it out of the oven.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt ==5){
                smilingmouse.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SALLY";
                Char2speech.text = "Yeah, it does look like it is cooling down. Hold up...I smell something...";
				nextButton.SetActive(false);
               allowSpace = false;
				Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
		}
		
       
      
	  else if (primeInt == 104){
				DialogueDisplay.SetActive(true); 
				Choice1a.SetActive(false); // function Choice1aFunct()
                Choice1b.SetActive(false);
				ButtonScene3a.SetActive(false);
	           ButtonScene3b.SetActive(false);
			  smilingmouse.SetActive(true);
			   ArtChar1.SetActive(false);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Let???s grab a bite of the cake!";
	  }
	  else if (primeInt == 105){
               smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Let's not risk it...";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 106){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Why not? ";
	  }
	  else if (primeInt == 107){
               ArtChar1.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "The cake is hot anyway. I say we go make a latte THEN come back for cake.";
               Char2name.text = "";
               Char2speech.text = "";
	  }
      else if (primeInt == 108){
               sallydissatisfied.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "I say we get cake.";
			   //ButtonScene3a.SetActive(true);
	          // ButtonScene3b.SetActive(true);
              // nextButton.SetActive(false);
              // allowSpace = false;
              // DialogueDisplay.SetActive(false);
       }
	else if (primeInt == 109){
               sallydissatisfied.SetActive(false);
			   smilingmouse.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Grrr...";
               Char2name.text = "";
               Char2speech.text = "";
			   
	          
	  }
	   else if (primeInt == 110){
		   
			   //Choice1b.SetActive(true);
		   
	           ButtonScene3b.SetActive(true);
               nextButton.SetActive(false);
               allowSpace = false;
              DialogueDisplay.SetActive(false);
	  }
     	  
	  
	  
	  else if (primeInt == 203){
               DialogueDisplay.SetActive(true);
			   smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Wow...isn't that a first.";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 204){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Hmph...Your nose might have died and gone to mouse heaven.";
	  }
	  else if (primeInt == 205){
               ArtChar1.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Excuse me?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
      else if (primeInt == 206){
		  ArtChar1.SetActive(true);
               Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Can't you smell cheese?";
			  
       }
	else if (primeInt == 207){
               ArtChar1.SetActive(false);
			   smilingmouse.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Ahem...ahem...oh yes...cheese...";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	   else if (primeInt == 208){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "It's coming from under that table.";
	   }
	   else if (primeInt == 209){
               ArtChar1.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Didn???t your mother ever warn you about eating food off the floor?";
               Char2name.text = "";
               Char2speech.text = "";
			  // ButtonScene3a.SetActive(true);
	          // ButtonScene3b.SetActive(true);
              // nextButton.SetActive(false);
              // allowSpace = false;
              //DialogueDisplay.SetActive(false);
	   }
			    else if (primeInt == 210){
               smilingmouse.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Mama used to say, 'All cheese, is good cheese.'";
	   } 
		else if (primeInt == 211){
               smilingmouse.SetActive(false);
			   Char1name.text = playerName;
               Char1speech.text = "Fresh cake vs cheese under the table...Really?";
               Char2name.text = "";
               Char2speech.text = "";
			  
	   }	
else if (primeInt == 212){
              // smilingmouse.SetActive(false);
			  // Char1name.text = playerName;
             //  Char1speech.text = "Fresh cake vs cheese under the table...Really?";
            //   Char2name.text = "";
            //   Char2speech.text = "";
			  // if(GameHandler.playerStat==1)
			  // {
			//	   Choice1a.SetActive(true);
			 //  }
			   
			   ButtonScene3a.SetActive(true);
	           ButtonScene3b.SetActive(true);
               nextButton.SetActive(false);
               allowSpace = false;
              DialogueDisplay.SetActive(false);	   
	   }
     
}
//FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
       public void Choice1aFunct(){
               DialogueDisplay.SetActive(true);	   
			  // GameHandler.playerStat =GameHandler.playerStat+1;
			   smilingmouse.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "YOU";
               Char2speech.text = "The Chef looks distracted.";
               primeInt = 103;
               Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }
       public void Choice1bFunct(){
               //GameHandler.playerStat +=1;
			   DialogueDisplay.SetActive(true);	
			   smilingmouse.SetActive(false);
			   ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "SALLY";
               Char2speech.text = "I change my mind...";
               primeInt = 202;
              Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }

        public void SceneChange1(){
			    SceneManager.LoadScene("Scene5b");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4c");
}
}