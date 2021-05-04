using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L2S1 : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;
	   public bool itemSensitive = false;
	   
	   public GameObject FileFolderLaniButton;
	   public GameObject IDDrMarkButton;
	   

       void Start () {
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
            //anim.SetBool("Chat", false)
			FileFolderLaniButton.SetActive(false);
			IDDrMarkButton.SetActive(false);
			
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
            dialogueText.text = "It's the stairs. You just came from there.";
			}

			if (primeInt ==2){
            dialogueText.text =  "But no shame in turning back if you need Lani's help. Or if you get too scared.";
			}
			  
			
			if (primeInt == 3){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 4){
            dialogueText.text = "D-Doctor Claudia? Is that you?";
			}
			
			if (primeInt == 5){
            dialogueText.text = "Ahaha, no worries! I'm definitely hard at work in here! Just like always!";
			}
			
			if (primeInt == 6){
				
            dialogueText.text = "In fact, you could name any patient and I could tell you, like... Anything about them! That's how diligent I am!";
						if ((itemSensitive == true)&&((GameHandler.itemFileLani == true)||(GameHandler.itemIdDrMark == true))){
							primeInt = 20;
						}
			}
			
			if (primeInt == 7){
            dialogueText.text = "Haha... ha...";
			}
			  
			if (primeInt == 8){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 12){
            dialogueText.text = "I can't turn back now.";
			}
			  
			if (primeInt == 13){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			
			if (primeInt == 20){
            dialogueText.text = "(Slide an item under the door?)";
			if (GameHandler.itemFileLani == true){
				FileFolderLaniButton.SetActive(true);
			}
			if (GameHandler.itemIdDrMark == true){
				IDDrMarkButton.SetActive(true);
			}
			
			}
			
			if (primeInt == 30){
            dialogueText.text = "Placeholder.";
			}
			
			if (primeInt == 31){
            dialogueText.text = "Kalani... That one's the cheerleader, right? Poor thing.";
			}
			
			if (primeInt == 32){
            dialogueText.text = "All it takes is to fall the wrong way, and that's a ruined back for you. Or, uh...To get dropped, rather.";
			}
			
			if (primeInt == 33){
            dialogueText.text = "If I remember correctly, her paralyzation wasn't caused until a complication during her surgery. Seems like nearly everything about her incident was avoidable.";
			}
			
			if (primeInt == 34){
            dialogueText.text = "It's a shame, but hey, it's only better for business if she's here even longer. So maybe it was on purpose?";
			}
			
			if (primeInt == 35){
            dialogueText.text = "Oh, haha, I'm kidding! Just kidding!";
			}
			  
			if (primeInt == 36) {
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			
			if (primeInt == 40){
            dialogueText.text = "Placeholder.";
			}
			
			if (primeInt == 41){
            dialogueText.text = "Dr. Mark? What are you doing here, I thought you had a patient to attend to!";
			}
			  
			if (primeInt == 42){
            dialogueText.text = "Oh, don't tell me you forgot the code to your safe AGAIN! How many times are you going to lock yourself out of the floor, huh?!";
			}
			
			if (primeInt == 43){
            dialogueText.text = "This is the last time I help you out, okay? It's 31 - 12 - 85. Write it down!";
			}
			  
			if (primeInt == 44){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
		}
		
		public void LaniItemButton(){
			primeInt = 30;
			NPCdialogue();
			FileFolderLaniButton.SetActive(false);
			IDDrMarkButton.SetActive(false);
		}
		
		public void DrMarkItemButton(){
			primeInt = 40;
			NPCdialogue();
			FileFolderLaniButton.SetActive(false);
			IDDrMarkButton.SetActive(false);
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
				FileFolderLaniButton.SetActive(false);
				IDDrMarkButton.SetActive(false);
                   //Debug.Log("Player left range");
             }
       }
}