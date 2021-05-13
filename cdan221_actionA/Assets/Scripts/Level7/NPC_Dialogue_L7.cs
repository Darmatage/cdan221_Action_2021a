using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC_Dialogue_L7 : MonoBehaviour {
	
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;
	   
	   public GameObject player; //MSG #1/4

       void Start () {
              dialogueBox.SetActive(false);
			  dialogueText.gameObject.SetActive(false);
			  player = GameObject.FindWithTag("Player"); //MSG #2/4
			  
       }

       void Update (){
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
            dialogueText.text = "This is foolish of you, Ema.";
			}

			if (primeInt ==2){
            dialogueText.text = "Who could possibly help you once you leave this place?";
			}
			  
			if (primeInt == 3){
            dialogueText.text = "Nobody out there will want to deal with you. But here, you're safe.";
			}

			if (primeInt ==4){
            dialogueText.text = "Do you really think all of you will survive if you do this?";
			}
			
			if (primeInt ==5){
            dialogueText.text = "Don't worry, though. You won't succeed. I'll stay here as long as you want until you realize that.";
			}
			  
			if (primeInt == 6){
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
	
}