using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L5S1 : MonoBehaviour {
    //public Animator anim;
    public GameObject dialogueBox;
    public Text dialogueText;
    public bool playerInRange = false;
    public int primeInt = 0;
	public int startPoint = 1;
	public GameObject player; //MSG #1/4


       void Start () {
              dialogueBox.SetActive(false);
			  dialogueText.gameObject.SetActive(false);
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
			
       }

       public void NPCdialogue (){
			if (primeInt == 0){
				primeInt += startPoint;
			} else {
				primeInt +=1;
			}

			if (primeInt == 1){
            dialogueText.text = "Oh, goodness. This floor sounds busy.";
			}

			if (primeInt ==2){
            dialogueText.text = "Better be careful and listen closely.";
			}
			  
			if (primeInt == 3){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 4){
            dialogueText.text = "There are some drawers on this bedside table. Stick your hand in there, girl!";
			}

			if (primeInt ==5){
            dialogueText.text = "...Nah. Feels like they're all empty.";
			}
			  
			if (primeInt == 6){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 7){
            dialogueText.text = "I'd rather not know what she has on here, actually.";
			}
			  
			if (primeInt == 8){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 9){
            dialogueText.text = "";
			}
			
			if (primeInt == 10){
            dialogueText.text = "But you can't.";
			}
			  
			if (primeInt == 11){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 12){
            dialogueText.text = "This is a vent. It's kind of dusty and gross.";
			}
			
			if (primeInt == 13){
            dialogueText.text = "Even if you were able to get the panel off, you're not sure if you would want to crawl in there.";
			}
			  
			if (primeInt == 14){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 15){
            dialogueText.text = "Some sort of remote? It feels like some of the buttons are damaged...";
			}
			
			if (primeInt == 16){
            dialogueText.text = "(press e to investigate! drag your hand around with the mouse to unveil what you're feeling.)";
			}
			  
			if (primeInt == 17){
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