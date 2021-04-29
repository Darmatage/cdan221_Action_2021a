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
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			
			if (primeInt == 40){
            dialogueText.text = "Placeholder.";
			}
			
			if (primeInt == 41){
            dialogueText.text = "Write the Dr. Mark text here.";
			}
			  
			if (primeInt == 42){
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