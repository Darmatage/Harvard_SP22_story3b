using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5bDialogue : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       // public Text Char3name;
       // public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
		 public GameObject sallyshouting;
		 public GameObject sallydissatisfied;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject ButtonScene3a;
        public GameObject ButtonScene3b;
		public GameObject ButtonScene3c;
        public GameObject nextButton;
       public GameHandler gameHandler;
	   //public GameObject MusicManager;
       public AudioSource MusicManager;
        private bool allowSpace = true;
		

void Start(){         // initial visibility settings
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		nextButton.SetActive(true);
		ArtChar1.SetActive(false);
		sallyshouting.SetActive(false);
		sallydissatisfied.SetActive(false);
		ButtonScene3a.SetActive(false);
        ButtonScene3b.SetActive(false);
		ButtonScene3c.SetActive(false);
        DialogueDisplay.SetActive(false);
		ArtBG1.SetActive(true);
        	
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
				//GameHandler.playerStat=false;
        }
        else if (primeInt == 2){
			   // ArtChar1.SetActive(true);
			   GameHandler.playerStat=false;
                DialogueDisplay.SetActive(true);
				Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(5f);
                Char1name.text = "YOU";
                Char1speech.text = "SALLY WATCH OUT! CHEF BEHIND YOU!";
                Char2name.text = "";
                Char2speech.text = "";
				
        }
       else if (primeInt ==3){
                Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(5f);
				sallyshouting.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SALLY";
                Char2speech.text = "JUMP INSIDE THE CAKE!!!";
				//nextButton.SetActive(false);
              // allowSpace = false;
				//Choice1a.SetActive(true); // function Choice1aFunct()
               // Choice1b.SetActive(true); // function Choice1bFunct()
                //gameHandler.AddPlayerStat(1);
        }
		else if (primeInt == 4){
			   // ArtChar1.SetActive(true);
			    Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
				sallyshouting.SetActive(false);
                DialogueDisplay.SetActive(true);
                MusicManager.Play();
				Char1name.text = "YOU";
                Char1speech.text = "Eww!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt ==5){
                Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
				ArtChar1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "SALLY";
                Char2speech.text = "I think you  meant 'phew'!?";
				nextButton.SetActive(false);
               allowSpace = false;
				Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
		}
		       
      
	  else if (primeInt == 104){
				Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
				DialogueDisplay.SetActive(true); 
				Choice1a.SetActive(false); // function Choice1aFunct()
                Choice1b.SetActive(false);
				ButtonScene3a.SetActive(false);
	           ButtonScene3b.SetActive(false);
			  sallyshouting.SetActive(true);
			   ArtChar1.SetActive(false);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "I told you to get the cheese...";
	  }
	  else if (primeInt == 105){
               Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
			   sallyshouting.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "NO! You SAID to get cake!";
               Char2name.text = "";
               Char2speech.text = "";
	  }
	  else if (primeInt == 106){
               Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
			   ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Whatever!";
	  }
	  else if (primeInt == 107){
               Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
			   ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "Now what do we do?";
               Char2name.text = "";
               Char2speech.text = "";
	  }
      else if (primeInt == 108){
		  Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
               sallydissatisfied.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Are you seriously asking me what we do inside a CAKE?";
			   //ButtonScene3a.SetActive(true);
	          // ButtonScene3b.SetActive(true);
              // nextButton.SetActive(false);
              // allowSpace = false;
              // DialogueDisplay.SetActive(false);
       }
	else if (primeInt == 109){
		Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
               sallydissatisfied.SetActive(false);
			   sallyshouting.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "I’m not so eager on eating something I’ve jumped into. Let’s just go to the pantry.";
               Char2name.text = "";
               Char2speech.text = "";
			   
	          
	  }
	   else if (primeInt == 110){
		   Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
			   //Choice1b.SetActive(true);
		   sallydissatisfied.SetActive(true);
			   sallyshouting.SetActive(false);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "I really don’t have any brain power left …maybe after I try some of this cake?";
	          
	  }
     	  else if (primeInt == 111){
			   ButtonScene3a.SetActive(true);
			   ButtonScene3b.SetActive(true);
			   ButtonScene3c.SetActive(true);
               nextButton.SetActive(false);
               allowSpace = false;
	  DialogueDisplay.SetActive(false);
		  }
	  
	  else if (primeInt == 203){
		  Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
               DialogueDisplay.SetActive(true);
			   sallyshouting.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Yeah! At least the Chef wouldn’t have spotted us.";
			   primeInt = 106;
	  }
	  /*else if (primeInt == 204){
               ArtChar1.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Hmph...Your nose might have died and gone to mouse heaven.";
	  }
	  else if (primeInt == 205){
               ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
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
			   sallyshouting.SetActive(false);
			   Char1name.text = "YOU";
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
			   Char1name.text = "YOU";
               Char1speech.text = "Didn’t your mother ever warn you about eating food off the floor?";
               Char2name.text = "";
               Char2speech.text = "";
			  // ButtonScene3a.SetActive(true);
	          // ButtonScene3b.SetActive(true);
              // nextButton.SetActive(false);
              // allowSpace = false;
              //DialogueDisplay.SetActive(false);
	   }
			    else if (primeInt == 210){
               sallyshouting.SetActive(true);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "Sally";
               Char2speech.text = "Mama used to say, 'All cheese, is good cheese.'";
	   } 
		else if (primeInt == 211){
               sallyshouting.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "Fresh cake vs cheese under the table...Really?";
               Char2name.text = "";
               Char2speech.text = "";
			  
	   }	
else if (primeInt == 212){
              // sallyshouting.SetActive(false);
			  // Char1name.text = "YOU";
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
	   }*/
     
}
//FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
       public void Choice1aFunct(){
		   Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
               DialogueDisplay.SetActive(true);	   
			   //GameHandler.playerStat =GameHandler.playerStat+1;
			   sallyshouting.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "";
               Char1speech.text = "";
               Char2name.text = "YOU";
               Char2speech.text = "NOW look what you’ve done! We are hiding inside a CAKE!";
               primeInt = 103;
               Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }
       public void Choice1bFunct(){
		   Char1speech.gameObject.GetComponentInParent<Shaker>().ChangeShake(0f);
               //GameHandler.playerStat +=1;
			   DialogueDisplay.SetActive(true);	
			   sallyshouting.SetActive(false);
			   ArtChar1.SetActive(false);
			   Char1name.text = "YOU";
               Char1speech.text = "My bad, Sally. I should have listened to you and gotten the cheese.";
               Char2name.text = "";
               Char2speech.text = "";
               primeInt = 202;
              Choice1a.SetActive(false);
               Choice1b.SetActive(false);
               nextButton.SetActive(true);
               allowSpace = true;
       }

        public void SceneChange1(){
			    SceneManager.LoadScene("EndScene3");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene3a");
}
		public void SceneChange3(){
                SceneManager.LoadScene("Scene4c");
		}
}