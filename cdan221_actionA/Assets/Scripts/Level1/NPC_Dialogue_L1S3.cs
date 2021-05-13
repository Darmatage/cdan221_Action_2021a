using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L1S3 : MonoBehaviour {
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
            dialogueText.text = "A new face! Are you from 3A?! That’s so crazy! My friend lived there too! He graffitied those walls so much, it feels like the room never stopped being his.";
				if (GameHandler.KnowSav == true) {
						primeInt = 11;
					}
			}
			
			if (primeInt == 2){
            dialogueText.text = "Soo, tell me about yourself! What's your favorite season? Color? Animal? Subject in school??";
			}
			
			if (primeInt == 3){
            dialogueText.text = "Well, not that that matters~ While you're admitted here, you never have to go to school! It's true!";
			}
			
			if (primeInt == 4){
            dialogueText.text = "Buuut, you do also have *literally* no contact with the outside world... Siiigh, I wonder how many instagram followers I've lost.";
			}
			
			if (primeInt == 5){
            dialogueText.text = "Now that my arm's all healed up and not grody anymore, I think I could take some really cute selfies again. The Doctor says I'm not all better, still, though...";
			}
			
			if (primeInt == 6){
            dialogueText.text = "What do you think, blindfold girl? You're super pretty, so I want to take lots of pictures with you, too...";
			}
			
			if (primeInt == 7){
            dialogueText.text = "Oh, your name is Ema? That's sooo cute! I hope I see you around lots!";
			}
			
			if (primeInt == 8){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}

			if (primeInt ==11){
            dialogueText.text = "A new face! Are you from 3A?! That’s so crazy! My friend lived there too!";
			}

			if (primeInt ==12){
            dialogueText.text = "...Huh? You think my name must be Savanna?";
			}
			  
			if (primeInt == 13){
            dialogueText.text = "Oh. My. Gosh. How did you know?! Don't tell me you're psychic or something!";
			}

			if (primeInt == 14){
            dialogueText.text = "I saw that in a movie once! Going blind can open up your third eye! I wish I got some sort of arm-loss super power.";
			}
			
			if (primeInt == 15){
            dialogueText.text = "Though, I did lose like, a ton of weight! You've got super cute and slender legs, too, new girl! Let's go to the beach together once we get discharged!";
			}
			
			if (primeInt == 16){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "Huh? Something feels off about this...";
			}
			
			if (primeInt == 21){
            dialogueText.text = "(press e to investigate!)";
			}
			  
			if (primeInt == 22){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 30){
            dialogueText.text = "Still no light.";
			}
			  
			if (primeInt == 31){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 35){
            dialogueText.text = "Still no dice on getting that panel off. Do you really want to crawl in there?";
			}
			  
			if (primeInt == 36){
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
				   player.GetComponent<PlayerMoveAround>().MSG_show();
                  }
             }
                        
       private void OnTriggerExit2D(Collider2D other){
             if (other.gameObject.tag == "Player") {
                   playerInRange = false;
                   dialogueBox.SetActive(false);
				   dialogueText.gameObject.SetActive(false);
                   //Debug.Log("Player left range");
				   player.GetComponent<PlayerMoveAround>().MSG_hide();
             }
       }
}