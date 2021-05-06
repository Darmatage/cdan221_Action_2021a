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
	   
	   public bool canPickUpFileLani = false;
	   public bool canPickUpFileJack = false;
	   public bool canPickUpDrMarkID = false;
	   
	   

       void Start () {
              dialogueBox.SetActive(false);
			  dialogueText.gameObject.SetActive(false);
              //anim.SetBool("Chat", false)
			  
       }

       void Update () {
			
			if ((canPickUpFileLani == true)&& (Input.GetKeyDown(KeyCode.E))) {
				GameHandler.itemFileLani = true;
				Debug.Log("You Got Lani's File");
			}else if ((canPickUpFileJack == true)&& (Input.GetKeyDown(KeyCode.E))) {
				GameHandler.itemFileJack = true;
				Debug.Log("You Got Jack's File");
			}else if ((canPickUpDrMarkID == true)&& (Input.GetKeyDown(KeyCode.E))) {
				GameHandler.itemIdDrMark = true;
				Debug.Log("You Got Dr Mark's ID");
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
            dialogueText.text = "There are a bunch of folders neatly filed away on the desk.";
			}

			if (primeInt ==2){
            dialogueText.text =  "They each have a labeled tab and some papers inside. Wonder if there's some way you can figure out what's in them...";
			}
			 
			if (primeInt ==3){
            dialogueText.text =  "(press e to pick up a file!)";
				if (playerInRange == true){
					canPickUpFileLani = true;
				}
			}
			
			if (primeInt == 4){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
				if (playerInRange == true){
					canPickUpFileLani = false;
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
				if (GameHandler.SafeUnlock == true) {
						primeInt = 60;
					}
			}
			
			if (primeInt == 31){
            dialogueText.text = "What on earth does a doctor need a safe in their office for?";
			}
			  
			if (primeInt == 32){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 40){
            dialogueText.text = "It's a closet. Inside, you feel a jacket and a little plastic card on a lanyard.";
			}
			
			if (primeInt == 41){
            dialogueText.text = "That could be useful.";
			}
			  
			if (primeInt == 42){
            dialogueText.text = "(press e to pick up the ID!)";
				if (playerInRange == true){
					canPickUpDrMarkID = true;
				}
			}
			  
			if (primeInt == 43){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
				if (playerInRange == true){
					canPickUpDrMarkID = false;
				}
			primeInt = 0;
			}
			
			if (primeInt == 60){
            dialogueText.text = "You unlock the safe. Nice!";
			}
			
			if (primeInt == 61){
            dialogueText.text = "There's some valuables in here, but you don't really have any use for those.";
			}
			
			if (primeInt == 62){
            dialogueText.text = "There is also a loose card in here... The lazy doctor mentioned something about Dr. Mark locking himself off the floor often, didn't they?";
			}
			
			if (primeInt == 63){
            dialogueText.text = "Guess it's worth a shot to see if it's a key card. You pocket it. Sorry Mark!";
			}
			
			if (primeInt == 64){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			GameHandler.HasKey = true;
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
				   canPickUpFileLani = false;
				   canPickUpDrMarkID = false;
                   dialogueBox.SetActive(false);
				   dialogueText.gameObject.SetActive(false);
                   //Debug.Log("Player left range");
             }
       }
}