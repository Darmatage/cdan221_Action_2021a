using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC_Dialogue_L6 : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;
	   public string TapeRecorderScene = "TapeRecorderScene";
	   public GameObject Level7Staircase;
	   public GameObject player; //MSG #1/4

       void Start () {
              dialogueBox.SetActive(false);
			  dialogueText.gameObject.SetActive(false);
			  Level7Staircase.SetActive(false);
              //anim.SetBool("Chat", false)
			  player = GameObject.FindWithTag("Player"); //MSG #2/4
			  
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
			
			if (GameHandler.BasementUnlock == true) {
				  Level7Staircase.SetActive(true);
			  }
       }

       public void NPCdialogue (){
			if (primeInt == 0){
				primeInt += startPoint;
			} else {
				primeInt +=1;
			}

			if (primeInt == 1){
            dialogueText.text = "You hear breathing... There's only one person it could be."; 
			}

			if (primeInt == 2){
            dialogueText.text = "Thank you for all the help. It's nice to finally meet eachother.";
			}
			  
			if (primeInt == 3){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "It's light out."; 
			}
			
			if (primeInt == 21){
            dialogueText.text = "Haha!";
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
				if (playerInRange == true){
					GameHandler.BasementUnlock = true;
				}
			}
			
			if (primeInt == 33){
            dialogueText.text = "Sorry little guy... You tear open the loose stitches.";
			}
			  
			if (primeInt == 34){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
					if (playerInRange == true){
					GoToTape ();
					}
			primeInt = 0;
			
			}
			
			if (primeInt == 50){
            dialogueText.text = "There are so many flowers here. It seems typical for a hospital room of someone well-beloved.";
			}
			
			if (primeInt == 51){
            dialogueText.text = "But friends and family don't visit patients at this hospital. His friends upstairs think he's dead.";
			}
			
			if (primeInt == 52){
            dialogueText.text = "So... Who put these here?";
			}
			
			if (primeInt == 53){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 60){
            dialogueText.text = "We can't turn back now.";
			}
			
			if (primeInt == 61){
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
				   player.GetComponent<PlayerMoveAround>().MSG_show(); //MSG #3/4
                  }
             }
                        
       private void OnTriggerExit2D(Collider2D other){
             if (other.gameObject.tag == "Player") {
                   playerInRange = false;
                   dialogueBox.SetActive(false);
				   dialogueText.gameObject.SetActive(false);
                   //Debug.Log("Player left range");
				    player.GetComponent<PlayerMoveAround>().MSG_hide(); //MSG #4/4
             }
       }
	   
	    public void GoToTape(){
		   SceneManager.LoadScene(TapeRecorderScene);
	}
}