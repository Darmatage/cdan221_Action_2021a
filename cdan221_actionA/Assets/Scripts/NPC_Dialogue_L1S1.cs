﻿using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L1S1 : MonoBehaviour {
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
				NPCdialogue_L1S1();
			}
			
       }

       public void NPCdialogue_L1S1 (){
              switch (switchvalue){
				case 1:
					primeInt +=1;

					if (primeInt == 1){
                    dialogueText.text = "It's a bed...";
					}

					if (primeInt ==2){
                     dialogueText.text = "Not my own, though.";
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
                    dialogueText.text = "There are some drawers here.";
					}

					if (primeInt ==2){
                     dialogueText.text = "I think they're empty.";
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