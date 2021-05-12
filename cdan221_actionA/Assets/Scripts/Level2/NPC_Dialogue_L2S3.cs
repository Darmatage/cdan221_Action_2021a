using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L2S3 : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;
	   
	   public bool canPickUpFileAaron = false;
	   public bool canPickUpDrClaudiaID = false;
	   
	public GameObject buttonFiles;
	public GameObject buttonID;
	public bool canPressSpace = true;
	public GameObject player; //MSG #1/4

    void Start () {
              dialogueBox.SetActive(false);
			  dialogueText.gameObject.SetActive(false);
              //anim.SetBool("Chat", false)
		buttonFiles.SetActive(false);
		buttonID.SetActive(false);
		player = GameObject.FindWithTag("Player"); //MSG #2/4
    }

       void Update () {
			
			// if ((canPickUpFileAaron == true)&& (Input.GetKeyDown(KeyCode.E))) {
				// GameHandler.itemFileAaron = true;
				// Debug.Log("You Got Aaron's File");
			// }else if ((canPickUpDrClaudiaID == true)&& (Input.GetKeyDown(KeyCode.E))) {
				// GameHandler.itemIdDrClaudia = true;
				// Debug.Log("You Got Dr Claudia's ID");
			// }
			
			if (Input.GetButtonDown("Talk") && playerInRange){ //input manager talk = spacebar
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
			
			if ((Input.GetButtonDown("Talk")) && (canPressSpace == true)){
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
            dialogueText.text = "There are a bunch of folders here. You can't make out what any of them are.";
			}

			if (primeInt ==2){
				dialogueText.text =  "They each have a labeled tab and some papers inside. Wonder if there's some way you can figure out what's in them...";
				if (playerInRange == true){
					if (GameHandler.itemFileAaron == true){
						primeInt = 5;
					}
				}
			}
			 
			if (primeInt ==3){
            dialogueText.text =  "(Click to pick up a file!)";
				if (playerInRange == true){
					canPickUpFileAaron = true;
					buttonFiles.SetActive(true);
					canPressSpace = false;
				}
			}
			
			if (primeInt ==4){
				buttonFiles.SetActive(false);
				dialogueText.text =  "You got a file!";
			}
			
			if (primeInt == 5){
				dialogueText.text =  "";
			}
			
			
			if (primeInt == 6){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
				if (playerInRange == true){
					canPickUpFileAaron = false;
				}
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "It's a computer. It feels so familiar to you, and you're pretty sure that you could use it if you really tried.";
			}
			
			if (primeInt == 21){
            dialogueText.text = "Problem is, you don't have a clue what the password could be. Or what you would even do once you're in there.";
			}
			
			if (primeInt == 22){
            dialogueText.text = "But you keep the existence of the computer in mind.";
			}
			  
			if (primeInt == 23){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 30){
            dialogueText.text = "It's a cool, metal box with a lock on it. You spin it and wiggle the door a couple of time, just for kicks.";
			}
			
			if (primeInt == 31){
            dialogueText.text = "Feels like the lock on this one is a little beat up... Did somebody else try to break in?";
			}
			  
			if (primeInt == 32){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 40){
             dialogueText.text = "This is a closet.";
			}
			
			if (primeInt == 41){
				dialogueText.text = "There are some hooks with things hanging on them. You feel some various jackets, bags, and a little plastic card on a lanyard.";
				if (playerInRange == true){
					if (GameHandler.itemIdDrClaudia == true){
						primeInt = 45;
					}
				}
			}
			
			if (primeInt == 42){
            dialogueText.text = "That could be handy if that's what you think it is..";
			}
			  
			if (primeInt == 43){
				dialogueText.text = "(Click to pick up the ID!)";
				if (playerInRange == true){
					canPickUpDrClaudiaID = true;
					buttonID.SetActive(true);
					canPressSpace = false;
				}
			}
			  
			  
			if (primeInt ==44){
				buttonID.SetActive(false);
				dialogueText.text =  "You got an ID!";
			}
			
			if (primeInt ==45){
				dialogueText.text =  "";
			}
			  
			  
			if (primeInt == 46){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
				if (playerInRange == true){
					canPickUpDrClaudiaID = false;
				}
			primeInt = 0;
			}
			
			if (primeInt == 50){
            dialogueText.text = "There are some hooks with things hanging on them in this closet. You feel some various jackets, bags, and a little plastic card on a lanyard.";
			}
			
			if (primeInt == 51){
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
				   canPickUpFileAaron = false;
				   canPickUpDrClaudiaID = false;
                   dialogueBox.SetActive(false);
				   dialogueText.gameObject.SetActive(false);
                   //Debug.Log("Player left range");
				   player.GetComponent<PlayerMoveAround>().MSG_hide(); //MSG #4/4
             }
    }
	   
	   
	 public void Button_PickUpFile(){
		buttonFiles.SetActive(false);
		NPCdialogue();
		canPressSpace = true;
		
		GameHandler.itemFileAaron = true;
		Debug.Log("You Got Aaron's File");
	}


	public void Button_PickUpID(){
		buttonID.SetActive(false);
		NPCdialogue ();
		canPressSpace = true;

		GameHandler.itemIdDrClaudia = true;
		Debug.Log("You Got Dr Claudia's ID");
	}  
	      
}