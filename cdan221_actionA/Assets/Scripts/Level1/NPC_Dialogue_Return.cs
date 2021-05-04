using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_Return : MonoBehaviour {
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
            dialogueText.text = "Hey, you alright? I heard you got caught sneaking around."; //Lani Game Over
			}

			if (primeInt ==2){
            dialogueText.text = "I tried to warn you. They really don't want us out of our rooms without supervision.";
			}
			  
			if (primeInt == 3){
            dialogueText.text = "They're probably going to go easy on you because you're new, but... they might not go so easy on you in the future.";
			}

			if (primeInt ==4){
            dialogueText.text = "Especially if the matron finds you.";
			}
			
			if (primeInt == 5){
            dialogueText.text = "I know this isn't what you want to hear, but all this is a bad idea. You should quit while you're ahead.";
			}
			  
			if (primeInt == 6){
            dialogueText.text = "It's not that bad here, right? We have eachother, and... we're safe. Safer than we were outside.";
			}
			
			if (primeInt == 7){
            dialogueText.text = "...Just be careful, okay?";
			}
			  
			if (primeInt == 8){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "Ema! It's so great to see you again! I wasn't sure if you were ever gonna come back to us."; //Sav Game Over
			}
			
			if (primeInt == 21){
            dialogueText.text = "";
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