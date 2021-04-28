using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L2S2 : MonoBehaviour {
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
            dialogueText.text = "There are a bunch of folders here. You can't make out what any of them are.";
			}

			if (primeInt ==2){
            dialogueText.text =  "They each have a labeled tab and some papers inside. Wonder if there's some way you can figure out what's in them...";
			}
			  
			
			if (primeInt == 3){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 4){
            dialogueText.text = "It's a computer. It feels so familiar to you, and you're pretty sure that you could use it if you really tried.";
			}
			
			if (primeInt == 5){
            dialogueText.text = "Problem is, you don't have a clue what the password could be. Or what you would even do once you're in there.";
			}
			
			if (primeInt == 6){
            dialogueText.text = "But you keep the existence of the computer in mind.";
			}
			  
			if (primeInt == 7){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 8){
            dialogueText.text = "It's a cool, metal box with a dial on it. You spin it and wiggle the door a couple of time, just for kicks.";
			}
			
			if (primeInt == 9){
            dialogueText.text = "What on earth does a doctor need a safe in their office for?";
			}
			  
			if (primeInt == 10){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 11){
            dialogueText.text = "There are some hooks with things hanging on them in this closet. You feel some various jackets, bags, and a little plastic card on a lanyard.";
			}
			
			if (primeInt == 12){
            dialogueText.text = "That could be handy if that's what you think it is..";
			}
			  
			if (primeInt == 13){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 14){
            dialogueText.text = "There are some hooks with things hanging on them in this closet. You feel some various jackets, bags, and a little plastic card on a lanyard.";
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