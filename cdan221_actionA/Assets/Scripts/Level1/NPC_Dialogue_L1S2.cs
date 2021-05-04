using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L1S2 : MonoBehaviour {
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
            dialogueText.text = "Oh, hey. You came out of 3A, right? You’ve got some guts breaking the matron’s rules so quickly. Not that it's hard, but be careful with that in the future.";
			}

			if (primeInt ==2){
            dialogueText.text = "So? What are you in for?";
			}
			  
			if (primeInt == 3){
            dialogueText.text = "(.....)";
			}

			if (primeInt ==4){
            dialogueText.text = "I'm just kidding. You don’t have to tell me. I know some patients don’t like to talk about their incidents.";
			}
			
			if (primeInt == 5){
            dialogueText.text = "I personally don’t mind. It’s kind of funny, actually, but that’s just me. I imagine most people don’t like to hear you joke about being paralyzed. ";
			}
			  
			if (primeInt == 6){
            dialogueText.text = "I’m Lani, by the way. The annoying-voice girl in 3B is Savanna. In 3C, that’s Jack.";
			}
			
			if (primeInt == 7){
            dialogueText.text = "I've been here the longest out of all of us, so feel free too... confide in me. Or something.";
			}
			  
			if (primeInt == 8){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 9){
            dialogueText.text = "It's locked. Feels like there's a keypad on this door...";
			}
			
			if (primeInt == 10){
            dialogueText.text = "Surely there must be a way to get through.";
			}
			  
			if (primeInt == 11){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "This must be Lani's room...";
			}
			  
			if (primeInt == 21){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 30){
            dialogueText.text = "This is Jack's room. There's no reason to go in right now.";
			}
			  
			if (primeInt == 31){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 40){
            dialogueText.text = "This is Savanna's room. There's no reason to go in right now.";
			}
			  
			if (primeInt == 41){
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