using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L2S2LaniFilePickup : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;
	   
	   public bool canPickUpFileLani = false;
	   
	   

       void Start () {
              dialogueBox.SetActive(false);
			  dialogueText.gameObject.SetActive(false);
              //anim.SetBool("Chat", false)
			  
       }

       void Update () {
			
			if ((canPickUpFileLani == true)&& (Input.GetKeyDown(KeyCode.E))) {
				GameHandler.itemFileLani = true;
				Debug.Log("You Got Lani's File");
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
			canPickUpFileLani = true;
			}
			
			if (primeInt == 4){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			canPickUpFileLani = false;
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