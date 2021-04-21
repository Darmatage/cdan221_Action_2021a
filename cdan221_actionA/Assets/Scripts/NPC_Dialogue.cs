using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
	   public int switchvalue;
       public bool playerInRange = false;
       public int primeInt = 0;

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
              switch (switchvalue){
				case 1:
					primeInt +=1;

					if (primeInt == 1){
                    dialogueText.text = "ONE.";
					}

					if (primeInt ==2){
                     dialogueText.text = "TWO.";
					}
			  
					if (primeInt == 3){
                     dialogueBox.SetActive(false);
					 dialogueText.gameObject.SetActive(false);
					 primeInt = 0;
					}
					break;
				case 2:
					primeInt +=1;

					if (primeInt == 1){
                    dialogueText.text = "THREE.";
					}

					if (primeInt ==2){
                     dialogueText.text = "FOUR.";
					}
			  
					if (primeInt == 3){
                     dialogueBox.SetActive(false);
					 dialogueText.gameObject.SetActive(false);
					 primeInt = 0;
					}
					break;
				case 3:
					primeInt +=1;

					if (primeInt == 1){
                    dialogueText.text = "FIVE.";
					}

					if (primeInt ==2){
                     dialogueText.text = "SIX.";
					}
			  
					if (primeInt == 3){
                     dialogueBox.SetActive(false);
					 dialogueText.gameObject.SetActive(false);
					 primeInt = 0;
					}
					break;
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