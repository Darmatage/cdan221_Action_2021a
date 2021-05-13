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
            dialogueText.text = "Psst! Hey, you!";
			}

			if (primeInt ==2){
            dialogueText.text = "Don't run away. I'm not gonna turn you in. See, you patients and me, we're both trapped here in a way.";
			}
			  
			if (primeInt == 3){
            dialogueText.text = "I'm not even real staff. I'm just doing my residency. But still, I think I deserve a little more respect than to be treated like some run of the mill intern!";
			}

			if (primeInt ==4){
            dialogueText.text = "But it's too late for me now. I'm not allowed to stop doing their dirty work...";
			}
			
			if (primeInt == 5){
            dialogueText.text = "So listen: I won't tell Dr. Claudia you're breaking rules, if you do one thing for me.";
			}
			  
			if (primeInt == 6){
            dialogueText.text = "Just steal me one of those icecream cakes they have. The ones they give to patients and staff on their birthdays.";
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