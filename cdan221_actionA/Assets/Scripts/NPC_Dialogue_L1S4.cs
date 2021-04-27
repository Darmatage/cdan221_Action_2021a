using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L1S4 : MonoBehaviour {
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
            dialogueText.text = "Hey, new kid. Already out of your room without a supervisor?";
			}

			if (primeInt ==2){
            dialogueText.text = "...Ema, huh? Well Ema, don't get too cocky just because you walked out an unlocked door. Let's see you get off the floor next.";
			}
			  
			if (primeInt == 3){
            dialogueText.text = "Speakin of, I’ve been wondering when they were gonna fill that room again. You’re lucky you can’t see the state of the place.";
			}

			if (primeInt ==4){
            dialogueText.text = "If there’s one thing Aaron did well, it’s leaving messes that are impossible to clean.";
			}
			
			if (primeInt == 5){
            dialogueText.text = "Listen, if you like breaking rules, keep this in mind; You have the advantage here. You can't judge this place by it's looks, right? So they can't fool you.";
			}
			  
			if (primeInt == 6){
            dialogueText.text = "Ah. Um... Ha, anyway... Nice to meet you.";
			}
			
			if (primeInt == 7){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 8){
            dialogueText.text = "Do you dare give the metal door of this vent a little tug?";
			}
			
			if (primeInt == 9){
            dialogueText.text = "...Oh my stars! Could it be? The panel's loose! Will you finally crawl in that dusty little maze?";
			}
			
			if (primeInt == 10){
            dialogueText.text = "No, absolutely not. You can feel around in there for good measure, though. Feels like more scratches!";
			}
			  
			if (primeInt == 11){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 12){
            dialogueText.text = "Still no light.";
			}
			  
			if (primeInt == 13){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 14){
            dialogueText.text = "Still no dice on getting that panel off. Do you really want to crawl in there?";
			}
			  
			if (primeInt == 15){
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