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
	public bool itemSensitive = false;
	public GameObject MusicBox;
	public GameObject ClaudiasOfficeDoor;
	public GameObject XrayRoom;

	public GameObject theKeys;

       void Start () {
              dialogueBox.SetActive(false);
			  dialogueText.gameObject.SetActive(false);
			  MusicBox.SetActive(false);
			  XrayRoom.SetActive(false);
			  ClaudiasOfficeDoor.SetActive(true);
              //anim.SetBool("Chat", false)
			  player = GameObject.FindWithTag("Player"); //MSG #2/4
			  
			  if (GameHandler.RingofKeys == false){
				  theKeys.SetActive(true);
			  } else {theKeys.SetActive(false);}
			  
			  
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
            dialogueText.text = "Huh? There's a book in one of the bags in here...You run your fingers along the pages, indented by the hard press of a pen.";
			}
			
			if (primeInt == 10){
            dialogueText.text = "You pick it up. You might need somebody else to read this to you... Maybe another patient would be willing to help.";
				if (playerInRange == true) {
					GameHandler.HasJournal = true;
				}
			}
			  
			if (primeInt == 11){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 12){
            dialogueText.text = "It's a music box...";
				if (playerInRange == true) {
				MusicBox.SetActive(true);
				}
			}
			
			if (primeInt == 13){
            dialogueText.text = "It plays soft notes that could put a child to sleep. Or you to sleep, honestly.";
			}
			  
			if (primeInt == 14){
            dialogueText.text = "You listen to the simple, nostalgic melody a few times. The song seems unbefitting of the person keeping people prisoner here.";
			}  
			  
			if (primeInt == 15){
            dialogueText.text = "...Or does it? How should you know. You haven't met her.";
			}  
			  
			if (primeInt == 16){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			MusicBox.SetActive(false);
			}
			
			if (primeInt == 25){
            dialogueText.text = "The tv is playing quietly. You can hear it when you get close, though.";
			}
			
			if (primeInt == 26){
            dialogueText.text = "Happy sweet melodies play beneath the sound of static. It sounds like some sort of children's program.";
			}
			
			if (primeInt == 27){
            dialogueText.text = "'You have to go to bed now,' a woman's voice is saying. A child whines and protests. They want to go explore instead.";
			}
			  
			if (primeInt == 28){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			if (primeInt == 40){
            dialogueText.text = "Hell yeah! Mints!";
			}
			
			if (primeInt == 41){
            dialogueText.text = "It's not a waiting room without mints.";
			}
			  
			if (primeInt == 42){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			if (primeInt == 50){
            dialogueText.text = "These chairs literally feel like nobody has ever sat in them.";
			}
			
			if (primeInt == 51){
            dialogueText.text = "Nobody probably ever has, because that would imply they came here willingly.";
			}
			  
			if (primeInt == 52){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 53){
            dialogueText.text = "This door can be unlocked with a key card...";
				if ((itemSensitive == true)&&(GameHandler.itemIdDrClaudia == true)) {
						ClaudiasOfficeDoor.SetActive(false);
					}
			}
			  
			if (primeInt == 54){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 55){
            dialogueText.text = "Feels like this door has a standard lock on it.";
				if (GameHandler.RingofKeys == true) {
					XrayRoom.SetActive(true);
				}
			}
			  
			if (primeInt == 56){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 65){
				dialogueText.text = "A ring of keys hangs from a hook. ";
			}
			
			if (primeInt == 66){
				dialogueText.text = "Maybe one of these could open one of the locked doors in the hall.";
			}
			
			if (primeInt == 67){
            dialogueText.text = "You picked up the keys.";
			if (playerInRange == true){
					GameHandler.RingofKeys = true;
					theKeys.SetActive(false);
				}
			}
			
			if (primeInt == 68){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 70){
            dialogueText.text = "The TV is playing softly. Sounds like a clip from a news channel or something? You think you can make out a name...";
			}
			
			if (primeInt == 71){
            dialogueText.text = "J KEEFE";
			}
			
			if (primeInt == 72){
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