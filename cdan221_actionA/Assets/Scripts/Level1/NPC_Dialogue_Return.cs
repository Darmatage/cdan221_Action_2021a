using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_Return : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;
	   public bool itemSensitive = false;

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
			if (primeInt == 0){
				primeInt += startPoint;
			} else {
				primeInt +=1;
			}

			if (primeInt == 1){
            dialogueText.text = "Hey, you alright? I heard you got caught sneaking around."; //Lani Game Over
			}

			if (primeInt ==2){
            dialogueText.text = "I tried to warn you. They really don't want us out of our rooms without supervision.";
			}
			  
			if (primeInt == 3){
            dialogueText.text = "They're probably going to go easy on you because you're new, but... they might not go so easy on you in the future.";
			}

			if (primeInt ==4){
            dialogueText.text = "Especially if the matron finds you.";
			}
			
			if (primeInt == 5){
            dialogueText.text = "I know this isn't what you want to hear, but all this is a bad idea. You should quit while you're ahead.";
			}
			  
			if (primeInt == 6){
            dialogueText.text = "It's not that bad here, right? We have eachother, and... we're safe. Safer than we were outside.";
			}
			
			if (primeInt == 7){
            dialogueText.text = "...Just be careful, okay?";
			}
			  
			if (primeInt == 8){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "Ema! It's so great to see you again! I wasn't sure if you were ever gonna come back."; //Sav Game Over
			}
			
			if (primeInt == 21){
            dialogueText.text = "Don't forget, we have plans to partyyyy together once we're discharged. So don't go leaving without us, 'kay?";
			}
			  
			if (primeInt == 22){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 30){
            dialogueText.text = "You--!! You're okay?! I mean, um. Of course you're okay! I wasn't worried at all."; //Jack Game Over
			}
			  
			if (primeInt == 31){
            dialogueText.text = "Man, I can't believe you got yourself! Listen, if you hear doctors, just run away from there! Got it?!";
			}
			  
			if (primeInt == 32){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 40){
            dialogueText.text = "The offices? Come on, don't tell me you really plan on snooping around down there."; //Lani Level 2
			if ((itemSensitive == true)&&(GameHandler.itemFileLani == true)) {
						primeInt = 50;
					}
			}
			
			if (primeInt == 41){
            dialogueText.text = "You're not going to find much other than paperwork. Maybe somebody will have left an ID down there if your lucky. But like, what you going to do with those?";
			}
			
			if (primeInt == 42){
            dialogueText.text = "Hey, what's with that face? I'm not trying to call you stupid or anything...";
			}
			
			if (primeInt == 43){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 50){
            dialogueText.text = "You... you got my file? How'd you pull that off?";
			}
			
			if (primeInt == 51){
            dialogueText.text = "Heh. Well, be honest. Are you surprised I was a cheerleader? Something like that would suit Savanna a lot more than me.";
			}
			
			if (primeInt == 52){
            dialogueText.text = "I wasn't very popular or anything. But I was the tiniest girl on the team, so I always got to be the flyer.";
			}
			
			if (primeInt == 53){
            dialogueText.text = "A lot of other girls who were a lot more passionate about it, they would have killed to be front and venter like that. So, you know.. ";
			}
			
			if (primeInt == 54){
            dialogueText.text = "..Dropping me on purpose was probably the perfect crime for them. Hahaha.";
			}
			
			if (primeInt == 55){
            dialogueText.text = "But no, it's not like I have proof or anything. But I don't think they'd miss me either. And the feeling is mutual, honestly. Good riddance.";
			}
			
			if (primeInt == 56){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
		
			if (primeInt == 60){
            dialogueText.text = "Wow, Ema. I was right about you, you're a real natural!"; //Jack Level 2
			if ((itemSensitive == true)&&(GameHandler.itemFileAaron == true)) {
						primeInt = 70;
					}
			}
			
			if (primeInt == 61){
            dialogueText.text = "So? Did you find anything good?";
			}
			
			if (primeInt == 62){
            dialogueText.text = "A... 'Lazy Door Doctor'? Uh. Interesting?";
			}
			
			if (primeInt == 63){
            dialogueText.text = "Hey, make sure you don't get caught, though! You can never know which staff are actually stupid or not.";
			}
			
			if (primeInt == 64){
            dialogueText.text = "But... If you *can* find a way to get information out of them... that might be good. Don't tell Lani I said that. If she asks, I said to play it COMPLETELY safe!";
			}
			
			if (primeInt == 65){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 70){
            dialogueText.text = "What? You found Aaron's file?!";
			}
			
			if (primeInt == 71){
            dialogueText.text = "W-Well? What did it say?!";
			}
			
			if (primeInt == 72){
            dialogueText.text = "...Oh. Right. Let me see it!";
			}
			
			if (primeInt == 73){
            dialogueText.text = "....murmermurmerJuly, no.....medications......mumblemumble.....allergies....";
			}
			
			if (primeInt == 74){
            dialogueText.text = "Ugh! I already know all this stuff! What gives?!";
			}
			
			if (primeInt == 75){
            dialogueText.text = "At- At least this means he's alive...right? If he died, they'd have to document it... Don't you think so?";
			}
			
			if (primeInt == 76){
            dialogueText.text = "So you do agree! Hahaha, agh-- aha. Thanks, Ema. Where ever he is we'll find him, I'm sure of it.";
			}
			
			if (primeInt == 77){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			
			if (primeInt == 80){
            dialogueText.text = " It's Ema! My new 3A bestie, hehehe! How has your adventure been going?"; //Sav Level 2
			}
			
			if (primeInt == 81){
            dialogueText.text = "Did you make it to the cafeteria yet? I heard they sell whole cakes down there! Like! What?! Omg.";
			}
			
			if (primeInt == 82){
            dialogueText.text = "But yeah, they brought Jack up one for his birthday last month, and he didn't even share! He threw it on the ground, actually. And he was all like;";
			}
			
			if (primeInt == 83){
            dialogueText.text = "IT'S PROBABLY POISONED! THEY'RE TRYING TO GET US MORE SICK SO WE CAN NEVER LEAVE! AAAAAAAAHHH!!";
			}
			
			if (primeInt == 84){
            dialogueText.text = "...Or something. I dunno, he's so funny like that.";
			}
			
			if (primeInt == 85){
            dialogueText.text = "At least he's seemed calmer since he talked to you! He never stays one way for long, but if exposing the hospital will make Jack happy then let's do it~ OK?";
			}
			  
			if (primeInt == 86){
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