using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NPC_Dialogue_EndingScene : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;
	   public string MainMenu = "MainMenu";
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
            dialogueText.text = "Bandages girl, you made it! Remember me? Thanks for the snack earlier.";
			}

			if (primeInt ==2){
            dialogueText.text = "Man, I'm so glad somebody broke us out. Honestly, I don't even think I want to pursue medicine anymore...";
			}
			  
			if (primeInt == 3){
            dialogueText.text = "I'm gonna be a baker.";
			}
			
			if (primeInt == 4){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 8){
            dialogueText.text = "Are you ready to go?";
			}
			
			if (primeInt == 9){
            dialogueText.text = "You can walk away now if you're not.";
			}
			
			if (primeInt == 10){
            dialogueText.text = "If you are, let's go, then. It's time for you to heal properly.";
			}
			  
			if (primeInt == 11){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
					if (playerInRange == true){
					EndTheGame ();
					}
			primeInt = 0;
			
			}
			
			if (primeInt == 12){
            dialogueText.text = "It's so bright out.";
			}
			  
			if (primeInt == 13){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 14){
            dialogueText.text = "Should probably find a real hospital instead.";
			}
			  
			if (primeInt == 15){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "You.. you don't think we're all going to be in trouble, do you? Like, malpractice and all that?";
			}
			
			if (primeInt == 21){
            dialogueText.text = "D-Doctor Claudia should really be the one getting in trouble! Ooohh.. where is she though?";
			}
			
			if (primeInt == 22){
            dialogueText.text = "Don't leave us for dead! Claudiaaaaaa!!";
			}
			
			if (primeInt == 23){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 25){
            dialogueText.text = "Haha, you really pulled it off! I can't believe it. I knew you were amazing, Ema.";
			}
			
			if (primeInt == 26){
            dialogueText.text = "Ugh, the light is kind of hurting me. Is that normal? I didn't expect that. Still, it's nice to breathe fresh air again...";
			}
			
			if (primeInt == 27){
            dialogueText.text = "But, um. I'm gonna go back in! Ironic, I know, but only for a little bit. There are just some things I've got to get. I want to make sure I don't forget this place.";
			}
			
			if (primeInt == 28){
            dialogueText.text = "I'll see you afterwards, hopefully. Sometime. Would, ah, that be okay?";
			}
			
			if (primeInt == 29){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 35){
            dialogueText.text = "Em...Emaaaaa!!";
			}
			
			if (primeInt == 36){
            dialogueText.text = "Huuh? M-me, crying? No way! I never cry! Ever!!";
			}
			
			if (primeInt == 37){
            dialogueText.text = "Why would I cry when the sun is shining? And I'm gonna have wifi again? And maybe even see my mom?!";
			}
			
			if (primeInt == 38){
            dialogueText.text = "I'm so happpyyyy!! sniff,sob...!!!";
			}
			
			if (primeInt == 39){
            dialogueText.text = "When I get my phone back, you have to give me your number, okay? Okay?? We're friends forever after today!";
			}
			
			if (primeInt == 40){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 50){
            dialogueText.text = "Since the beginning, I already knew she wanted to protect us. Back when she talked to us, she even told me. Obviously I believed her.";
			}
			
			if (primeInt == 51){
            dialogueText.text = "Is it wrong that I felt that way? I mean… I could have used even one person there for me. If even one single person hadn’t stepped away before I hit the ground… I… ";
			}
			
			if (primeInt == 52){
            dialogueText.text = "Sorry. I know I said I usually don't get gloomy about that. I guess I'm just little scared. I have been ever since you showed up.";
			}
			
			if (primeInt == 53){
            dialogueText.text = "But I understand now. She failed to protect us, and... Well, I failed too, in a lot of ways. But I won't let it happen again.";
			}
			
			if (primeInt == 54){
            dialogueText.text = "Ema, you still have a long way to go in your recovery, right? I'll be right here to support you. If you need a friend, or anything.";
			}
			
			if (primeInt == 55){
            dialogueText.text = "Ha, I get it if this sounds strange coming from me. But I mean it.";
			}
			
			if (primeInt == 56){
            dialogueText.text = "This goes for you, and the others, too: I'll catch you if you fall. I swear it.";
			}
			
			if (primeInt == 57){
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
	   
	       public void EndTheGame(){
		   SceneManager.LoadScene(MainMenu);
	}
}