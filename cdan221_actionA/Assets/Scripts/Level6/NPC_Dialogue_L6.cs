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
            dialogueText.text = "The others should be here instead of you. Regardless of your feelings, at the end of the day, you're a stranger.";
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
            dialogueText.text = "Haha.";
			}
			  
			if (primeInt == 22){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 30){
            dialogueText.text = "It's a stuffed rabbit. It's fur is so soft... After the day you've had, you can't stop yourself from giving it a squeeze."; 
			}
			  
			if (primeInt == 31){
            dialogueText.text = "It's not as squishy as you thought. There's something... hard inside?";
			}
			
			if (primeInt == 32){
            dialogueText.text = "And its back has a noticeable scar of crude sewing, strings every which way. Rather than a normal seam, it's as if someone had cut it open.";
			}
			
			if (primeInt == 33){
            dialogueText.text = "You should probably tear apart this soft little fellow and get at his insides. Sorry.";
			}
			  
			if (primeInt == 34){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 50){
            dialogueText.text = "There are so many flowers here. It seems typical for a hospital room of someone well-beloved.";
			}
			
			if (primeInt == 51){
            dialogueText.text = "Of course, you know that this boy *is* beloved. But friends and family don't visit patients at this hospital. And his friends upstairs think he's dead.";
			}
			
			if (primeInt == 52){
            dialogueText.text = "So... Who put these here?";
			}
			
			if (primeInt == 53){
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