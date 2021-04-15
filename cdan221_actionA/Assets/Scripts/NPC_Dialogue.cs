using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
		public GameObject face1;
		public GameObject face2;
       public bool playerInRange = false;
       public int primeInt = -1;
       public string dialogue0;
       public string dialogue1;
       public string dialogue2;
       public string dialogue3;
       public string dialogue4;
       public string dialogue5;

private bool isPlayerSpeaking = false;

       void Start () {
              dialogueBox.SetActive(false);
              //anim.SetBool("Chat", false)
			  face1.SetActive(false);
			  face2.SetActive(true);
			  
       }

       void Update () {
			
			
			if (Input.GetButtonDown("Talk") && playerInRange){ //can change teh key to
                   if (dialogueBox.activeInHierarchy){
                        //dialogueBox.SetActive(false);
                        //anim.SetBool("Chat", false);

                   } else {
                        dialogueText.text = dialogue0;
                        dialogueBox.SetActive(true);
                        //anim.SetBool("Chat", true);
                   }
				   
				   if (isPlayerSpeaking = false){
						face1.SetActive(false);
						face2.SetActive(true);
				   } else {
					   face1.SetActive(true);
						face2.SetActive(false);
				   }
				   
            }
			
			
			if (Input.GetButtonDown("Talk")){
				NPCdialogue();
			}
			
       }

       public void NPCdialogue (){
              primeInt +=1;

              if (primeInt == 1){
                    dialogueText.text = dialogue1;
					isPlayerSpeaking = true;
              }

              if (primeInt ==2){
                     dialogueText.text = dialogue2;
					 isPlayerSpeaking = false;
              }

              if (primeInt == 3){
                     dialogueText.text = dialogue3;
					isPlayerSpeaking = true;
              }

              if (primeInt == 4){
                     dialogueText.text = dialogue4;
					 isPlayerSpeaking = false;
              }

              if (primeInt == 5){
                     dialogueText.text = dialogue5;
					 isPlayerSpeaking = true;
              }
			  
			  if (primeInt == 6){
                     dialogueBox.SetActive(false);
              }
			  
       }

       private void OnTriggerEnter2D(Collider2D other){
             if (other.gameObject.tag == "Player") {
                   playerInRange = true;
                   primeInt = -1;
				   Debug.Log("Hit Space to talk");
                  }
             }
                        
       private void OnTriggerExit2D(Collider2D other){
             if (other.gameObject.tag == "Player") {
                   playerInRange = false;
                   dialogueBox.SetActive(false);
                   //Debug.Log("Player left range");
             }
       }
}