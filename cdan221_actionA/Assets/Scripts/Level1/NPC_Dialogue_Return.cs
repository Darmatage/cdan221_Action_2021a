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
            dialogueText.text = "Man, I can't believe you got yourself caught! Listen, if you hear doctors, just run away from there! Got it?!";
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
            dialogueText.text = " It's Ema! My new 3A bestie, hehehe! How has your adventure been going?"; //Sav Level 3
				if ((itemSensitive == true)&&(GameHandler.itemCake == true)) {
						primeInt = 145;
					}
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
			
			if (primeInt == 90){
            dialogueText.text = "Oh, hey. It's been a while since you've checked in."; //Lani Level 4
			}
			
			if (primeInt == 91){
            dialogueText.text = "You're pretty serious about this, huh? But...Why?";
			}
			
			if (primeInt == 92){
            dialogueText.text = "You only just got here recently. You have no reason to want to save us. You really... don't even know us.";
			}
			
			if (primeInt == 93){
            dialogueText.text = "And if something bad happens to you, then we'll never know eachother for real...";
			}
			
			if (primeInt == 94){
            dialogueText.text = "I don't think the others understand that you aren't Aaron. They're throwing you into danger because they think you can finish what he started.";
			}
			
			if (primeInt == 95){
            dialogueText.text = "But you're you. You're a normal patient just like us, and you haven't even healed yet.";
			}
			  
			if (primeInt == 96){
            dialogueText.text = "...You should really go back to your room, Ema.";
			}
			   
			if (primeInt == 97){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 100){
            dialogueText.text = "...Be honest. Lani is trying to screw us over, isn't she?"; //Jack Level 4
			}
			
			if (primeInt == 101){
            dialogueText.text = "You could be so close to getting us out of here, and she doesn't seem excited at all. It's like she doesn't even care!";
			}
			
			if (primeInt == 102){
            dialogueText.text = "And what about us, too?! Don't we deserve to get out of here? That greedy, egotistical matron is keeping us prisoner, and for what?";
			}
					
			if (primeInt == 103){
            dialogueText.text = "Damn it... Damn it, damn it. I know Lani cares about us. But keeping somebody trapped isn't protecting them.";
			}
			
			if (primeInt == 104){
            dialogueText.text = "...Hey, Ema. You said your memory is really good, yeah? Mine is really bad. Sometimes the others write things down for me.";
			}
			  	
			if (primeInt == 105){
            dialogueText.text = "I always thought it was funny, that somebody could help me in the future with a problem I don't even know I'm going to have yet.";
			}
			
			if (primeInt == 106){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 110){
            dialogueText.text = "Everyone is acting super down right now... I don't get it. Shouldn't they be happy?"; //Sav Level 4
			}
			
			if (primeInt == 111){
            dialogueText.text = "...Huh? You're asking *ME* for help, since everyone else is acting crazy??? You're stuck on a door code...";
			}
			
			if (primeInt == 112){
            dialogueText.text = "Um... I'm not really that smart, and I haven't been here as long as the others... So I don't really know a lot, you know~?";
			}
					
			if (primeInt == 113){
            dialogueText.text = "Ohh, I could tell you all about my friends though! I'm with them every day after all. Go on, quiz me!";
			}
			
			if (primeInt == 114){
            dialogueText.text = "Jack's birthday is September 9th, 2002! Lani's is February 15th, 2000! Aaron's is... um... Oh, it was in 1998!";
			}
			  	
			if (primeInt == 115){
            dialogueText.text = "What, you were born the same year? That's so crazy! You're really too alike!";
			}
			
			if (primeInt == 116){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 120){
            dialogueText.text = "Ema. You said you found Claudia’s office..?"; //Lani Level 5
				if (GameHandler.HasJournal == true) {
						primeInt = 130;
					}
			}
			
			if (primeInt == 121){
            dialogueText.text = "So she really wasn’t in there. All of this seems too easy, doesn’t it?";
			}
			
			if (primeInt == 122){
            dialogueText.text = "But I guess it makes sense. She hasn’t been around in months.";
			}
					
			if (primeInt == 123){
            dialogueText.text = "She doesn’t even come to check in on us patients anymore, even though she’s supposed to be our doctor. Even though…";
			}
			
			if (primeInt == 124){
            dialogueText.text = "One of us went missing, and we’re supposed to be safe here…";
			}
			  	
			if (primeInt == 125){
            dialogueText.text = "It really is hopeless, isn’t it?";
			}
			
			if (primeInt == 126){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 130){
            dialogueText.text = "You want me to read you a page from this journal? I could do that... This one is from September 13th. 2019."; //Lani Level 5 if you found the journal
			}
			
			if (primeInt == 131){
            dialogueText.text = "'It no longer seems possible to keep this facility running. Some of my colleagues have been urging me to give up and shut the hospital down. Ridiculous!";
			}
			
			if (primeInt == 132){
            dialogueText.text = "My program is legitimate. I'm not crazy. I'm just...' There are some sentences scratched out here.";
			}
					
			if (primeInt == 133){
            dialogueText.text = "'The only thing I require for more funding is more patients. I had considered it for a while, anyways. There are so many people who need my protection…'";
			}
			
			if (primeInt == 134){
            dialogueText.text = "2019 was the year she started getting more patients… So, I guess it’s actually been 2 years that I’ve been here. ";
			}
			  	
			if (primeInt == 135){
            dialogueText.text = "Since the beginning, I already knew she wanted to protect us. Back when she talked to us, she even told me. And I believed her.";
			}
			
			if (primeInt == 136){
            dialogueText.text = "Is it wrong that I felt that way? I mean… I could have used even one person there for me. If even one single person hadn’t stepped away before I hit the ground… I… ";
			}
			
			if (primeInt == 137){
            dialogueText.text = "But, I understand now. She failed to protect Aaron, and.. so did I. It won’t happen again.";
			}
			
			if (primeInt == 138){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 145){
            dialogueText.text = "No... Freaking.... WAY......!!!"; //Sav Cake
			}
			
			if (primeInt == 146){
            dialogueText.text = "YOU GOT THE CAKE!? Oh my god, you really snuck a piece up here for me?!";
			}
			  	
			if (primeInt == 147){
            dialogueText.text = "Ohhh, Emaaaaa!! I've missed the taste of forbidden cake! I'm super glad you came here!";
			}
			
			if (primeInt == 148){
            dialogueText.text = "Well, like... I'm not glad that you got your eyes ripped out or whatever. But I'm soo glad I met you!";
			}
			
			if (primeInt == 149){
            dialogueText.text = "Next time we can share with everybody else too, and bring smiles to their faces again!";
			}
			
			if (primeInt == 150){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 160){
            dialogueText.text = "Doc Claudia’s office? Oh, all I know about it is that she has a key lock on it!"; //Sav Level 5
			if (GameHandler.HasJournal == true) {
						primeInt = 170;
					}
			}
			
			if (primeInt == 161){
            dialogueText.text = "Aaron had stolen her ID before and gotten in. I dunno where he ever hid it afterwards.";
			}
			  	
			if (primeInt == 162){
            dialogueText.text = "All I know is that when he came back, he seemed really sad.. I had only just met him at the time, and I was really sad too, you know?";
			}
			
			if (primeInt == 163){
            dialogueText.text = "My arm hurt really bad. I was so confused, and frustrated, and really scared. I was crying a whole bunch and probably looked really ugly.";
			}
			
			if (primeInt == 164){
            dialogueText.text = "I was like, I want my mommyyy! Aaron said, they won’t bring your mom to you, I’m sorry. Then we cried together for a really long time.";
			}
			
			if (primeInt == 165){
            dialogueText.text = "It felt really nice for some reason… but that was forever ago! I hate crying. I’m never gonna cry again!";
			}
			
			if (primeInt == 166){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 170){
            dialogueText.text = "Ooh, you have some gossip about the Doc? I can read it for you!";
			}
			  	
			if (primeInt == 171){
            dialogueText.text = "";
			}
			
			if (primeInt == 172){
            dialogueText.text = "My arm hurt really bad. I was so confused, and frustrated, and really scared. I was crying a whole bunch and probably looked really ugly.";
			}
			
			if (primeInt == 173){
            dialogueText.text = "I was like, I want my mommyyy! Aaron said, they won’t bring your mom to you, I’m sorry. Then we cried together for a really long time.";
			}
			
			if (primeInt == 174){
            dialogueText.text = "It felt really nice for some reason… but that was forever ago! I hate crying. I’m never gonna cry again!";
			}
			
			if (primeInt == 175){
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