using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC_Dialogue_L4S1 : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;
	   public string HideoutLevel = "RadioScene";

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
            dialogueText.text = "You want to hear a secret?";
			}

			if (primeInt ==2){
            dialogueText.text = "The security guards for the hospital have a secret hideout in the operating rooms on this floor.";
			}
			  
			if (primeInt == 3){
            dialogueText.text = "Well, it's not really a secret.";
			}

			if (primeInt ==4){
            dialogueText.text = "You can always hear their radio blaring behind the wall, so everyone on this floor knows about it.";
			}
			
			if (primeInt == 5){
            dialogueText.text = "They talk about all sorts of stuff over the radio. Patient information, gossip about hospital staff, door passcodes...";
			}
			  
			if (primeInt == 6){
            dialogueText.text = "You know, secret stuff.";
			}
			
			if (primeInt == 7){
            dialogueText.text = "You're probably really interested in that radio now, huh. I bet you want me tell you where it is.";
			}
			
			if (primeInt == 8){
            dialogueText.text = "Well I can't.";
			}
			
			if (primeInt == 9){
            dialogueText.text = "'cause it's a secret.";
			}
			  
			if (primeInt == 10){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "No way! You really got it!";
			}
			
			if (primeInt == 21){
            dialogueText.text = "Oh, I'm so pumped. I totally owe you one for this!";
			}
			
			if (primeInt == 22){
            dialogueText.text = "You can head on into the pharmacy if you want, and we'll both keep quiet about this. Alright?";
			}
			
			if (primeInt == 23){
            dialogueText.text = "Good luck, blindfold girl!";
			}
			  
			if (primeInt == 24){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 30){
            dialogueText.text = "You can feel a thin crack in the wall here.";
			}
			
			if (primeInt == 31){
            dialogueText.text = "You give it a little push and the wall gives away.";
			}
			
			if (primeInt == 32){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			GoToHideout();
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
	   public void GoToHideout(){
		   SceneManager.LoadScene(HideoutLevel);
	}
}