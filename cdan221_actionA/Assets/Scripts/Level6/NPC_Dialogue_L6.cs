using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L6 : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;

       void Start () {
              dialogueBox.SetActive(false);
			  dialogueText.gameObject.SetActive(false);
              //anim.SetBool("Chat", false)
			  
       }

       void Update () {
			
			
			if (Input.GetButtonDown("Talk") && playerInRange){ //can change teh key to
                   if (dialogueBox.activeInHierarchy){
                        //dialogueBox.SetActive(false);
                        //anim.SetBool("Chat", false);

                   } else {
                        dialogueText.gameObject.SetActive(true);
						dialogueText.text = "";
                        dialogueBox.SetActive(true);
                        //anim.SetBool("Chat", true);
                   }
				   
            }
			
			
			if (Input.GetButtonDown("Talk")){
				NPCdialogue();
			}
			
       }

       public void NPCdialogue (){
			if (primeInt == 0){
				primeInt += startPoint;
			} else {
				primeInt +=1;
			}

			if (primeInt == 1){
            dialogueText.text = "You hear breathing. There's nobody else it could be."; 
			}

			if (primeInt ==2){
            dialogueText.text = "Maybe you would be like this too if you were less lucky.";
			}
			  
			if (primeInt == 3){
            dialogueText.text = "'I'm the in the same boat as you were. Thank you for all the help.' That's the kind of thing you should be saying right now, but...";
			}

			if (primeInt ==4){
            dialogueText.text = "...It's too unfair.";
			}
			
			if (primeInt == 5){
            dialogueText.text = "The others should be here instead of you. Even though you've been picking up the pieces of what he left behind, at the end of the day, you're a stranger.";
			}
			  
			if (primeInt == 6){
            dialogueText.text = "No, you don't have time to feel guilty about that sort of thing. It's good that you're here.";
			}
			
			if (primeInt == 7){
            dialogueText.text = "It's nice to finally meet eachother.";
			}
			  
			if (primeInt == 8){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "It's light out."; 
			}
			
			if (primeInt == 21){
            dialogueText.text = "........Haha!";
			}
			  
			if (primeInt == 22){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 30){
            dialogueText.text = "You--!! You're okay?! I mean, um. Of course you're okay! I wasn't worried at all."; //Jack Game Over
			}
			  
			if (primeInt == 31){
            dialogueText.text = "Man, I can't believe you got yourself! Listen, if you hear doctors, just run away from there! Got it?!";
			}
			  
			if (primeInt == 32){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 50){
            dialogueText.text = "You... you got my file? How'd you pull that off?";
			}
			
			if (primeInt == 51){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
		}

       private void OnTriggerEnter2D(Collider2D other){
             if (other.gameObject.tag == "Player") {
                   playerInRange = true;
                   primeInt = 0;
				   Debug.Log("Hit Space to talk");
                  }
             }
                        
       private void OnTriggerExit2D(Collider2D other){
             if (other.gameObject.tag == "Player") {
                   playerInRange = false;
                   dialogueBox.SetActive(false);
				   dialogueText.gameObject.SetActive(false);
                   //Debug.Log("Player left range");
             }
       }
}