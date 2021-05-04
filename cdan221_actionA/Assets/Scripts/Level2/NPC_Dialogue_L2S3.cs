using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L2S3 : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;
	   
	   public bool canPickUpFileAaron = false;
	   public bool canPickUpFileSavanna = false;
	   public bool canPickUpDrClaudiaID = false;
	   
	   

       void Start () {
              dialogueBox.SetActive(false);
			  dialogueText.gameObject.SetActive(false);
              //anim.SetBool("Chat", false)
			  
       }

       void Update () {
			
			if ((canPickUpFileAaron == true)&& (Input.GetKeyDown(KeyCode.E))) {
				GameHandler.itemFileAaron = true;
				Debug.Log("You Got Aaron's File");
			}else if ((canPickUpFileSavanna == true)&& (Input.GetKeyDown(KeyCode.E))) {
				GameHandler.itemFileSavanna = true;
				Debug.Log("You Got Savanna's File");
			}else if ((canPickUpDrClaudiaID == true)&& (Input.GetKeyDown(KeyCode.E))) {
				GameHandler.itemIdDrClaudia = true;
				Debug.Log("You Got Dr Claudia's ID");
			}
			
			if (Input.GetButtonDown("Talk") && playerInRange){ //input manager talk = spacebar
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
			 
			if (primeInt ==3){
            dialogueText.text =  "(press e to pick up a file!)";
				if (playerInRange == true){
					canPickUpFileAaron = true;
				}
			}
			
			if (primeInt == 4){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
				if (playerInRange == true){
					canPickUpFileAaron = false;
				}
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "It's a computer. It feels so familiar to you, and you're pretty sure that you could use it if you really tried.";
			}
			
			if (primeInt == 21){
            dialogueText.text = "Problem is, you don't have a clue what the password could be. Or what you would even do once you're in there.";
			}
			
			if (primeInt == 22){
            dialogueText.text = "But you keep the existence of the computer in mind.";
			}
			  
			if (primeInt == 23){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 30){
            dialogueText.text = "It's a cool, metal box with a lock on it. You spin it and wiggle the door a couple of time, just for kicks.";
			}
			
			if (primeInt == 31){
            dialogueText.text = "Feels like the lock on this one is a little beat up... Did somebody else try to break in?";
			}
			  
			if (primeInt == 32){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 40){
            dialogueText.text = "There are some hooks with things hanging on them in this closet. You feel some various jackets, bags, and a little plastic card on a lanyard.";
			}
			
			if (primeInt == 41){
            dialogueText.text = "That could be handy if that's what you think it is..";
			}
			  
			if (primeInt == 42){
            dialogueText.text = "(press e to pick up the ID!)";
				if (playerInRange == true){
					canPickUpDrClaudiaID = true;
				}
			}
			  
			if (primeInt == 43){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
				if (playerInRange == true){
					canPickUpDrClaudiaID = false;
				}
			primeInt = 0;
			}
			
			if (primeInt == 50){
            dialogueText.text = "There are some hooks with things hanging on them in this closet. You feel some various jackets, bags, and a little plastic card on a lanyard.";
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
				   canPickUpFileAaron = false;
				   canPickUpDrClaudiaID = false;
                   dialogueBox.SetActive(false);
				   dialogueText.gameObject.SetActive(false);
                   //Debug.Log("Player left range");
             }
       }
}