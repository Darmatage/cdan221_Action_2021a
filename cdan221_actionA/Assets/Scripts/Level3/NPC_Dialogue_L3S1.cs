using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class NPC_Dialogue_L3S1 : MonoBehaviour {
       //public Animator anim;
       public GameObject dialogueBox;
       public Text dialogueText;
       public bool playerInRange = false;
       public int primeInt = 0;
	   public int startPoint = 1;
	   public bool itemSensitive = false;
	   public bool canPickUpCake = false;
	   public GameObject NPCMedStudent;
	   

       void Start () {
              dialogueBox.SetActive(false);
			  dialogueText.gameObject.SetActive(false);
              //anim.SetBool("Chat", false)
			  
       }

       void Update () {
		   
		   
		    if ((canPickUpCake == true)&& (Input.GetKeyDown(KeyCode.E))) {
				GameHandler.itemCake = true;
				Debug.Log("You Got Cake");
			}
			
			if (GameHandler.MedStudentGone == true) {
				  NPCMedStudent.SetActive(false);
			  }
			
			
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
            dialogueText.text = "Psst! Hey, you!";
				if ((itemSensitive == true)&&(GameHandler.itemCake == true)) {
						primeInt = 20;
					}
			}

			if (primeInt ==2){
            dialogueText.text = "Don't run away. I'm not gonna turn you in. See, you patients and me, we're both trapped here in a way.";
			}
			  
			if (primeInt == 3){
            dialogueText.text = "I'm not even real staff. I'm just doing my residency. But still, I think I deserve a little more respect than to be treated like some run of the mill intern!";
			}

			if (primeInt ==4){
            dialogueText.text = "But it's too late for me now. I'm not allowed to stop doing their dirty work...";
			}
			
			if (primeInt == 5){
            dialogueText.text = "So listen: I won't tell Dr. Claudia you're breaking rules, if you do one thing for me.";
			}
			  
			if (primeInt == 6){
            dialogueText.text = "Just steal me one of those icecream cakes they have. The ones they give to patients and staff on their birthdays.";
				if ((itemSensitive == true)&&(GameHandler.itemCake == true)) {
						primeInt = 20;
					}
			}
			
			if (primeInt == 7){
            dialogueText.text = "If you do that, I'll even let you into the pharmacy back here. You want to explore, right?";
			}
			  
			if (primeInt == 8){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 20){
            dialogueText.text = "No way! You really got it!";
			}
			
			if (primeInt == 21){
            dialogueText.text = "Oh, I'm so pumped. I totally owe you one for this!";
			}
			
			if (primeInt == 22){
            dialogueText.text = "You can head on into the pharmacy if you want, and we'll both keep quiet about this. Alright?";
			}
			
			if (primeInt == 23){
            dialogueText.text = "Good luck, blindfold girl!";
			}
			  
			if (primeInt == 24){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
				if (playerInRange == true) {
					GameHandler.MedStudentGone = true;
				}
			primeInt = 0;
			}
			
			if (primeInt == 30){
            dialogueText.text = "An icecream cake would probably be in the freezer. You get on your tiptoes and reach in there.";
			}
			
			if (primeInt == 31){
            dialogueText.text = "Sure enough, there's a medium-sized cardboard box in there.";
			}
			  
			if (primeInt == 32){
            dialogueText.text = "It's probably definitely the cake. But you do make sure to get a taste of the frosting, juuust in case. Just in case!";
			}
			 
			if (primeInt ==33){
            dialogueText.text =  "(press e to take that cake with you now!)";
				if (playerInRange == true){
					canPickUpCake = true;
				}
			}
			 
			if (primeInt == 34){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
				if (playerInRange == true){
					canPickUpCake = false;
				}
			primeInt = 0;
			}
			
			if (primeInt == 40){
            dialogueText.text = "It's a table. This place must be a kitchen or break room type of thing.";
			}
			  
			if (primeInt == 41){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 50){
            dialogueText.text = "A sink! You are more than happy to give your hands a nice wash after walking around a hospital all day.";
			}
			 
			if (primeInt == 51){
            dialogueText.text = "Especially since you have put your hands all over LITERALLY EVERYTHING that you've come across.";
			}
			  
			if (primeInt == 52){
            dialogueText.text = "In your case? Necessary! But arguably unsanitary.";
			}
			 
			if (primeInt == 53){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 60){
            dialogueText.text = "You imagine eating with all your friends. You can vividly remember each and every face.";
			}
			
			if (primeInt == 61){
            dialogueText.text = "But now isn't the time to think about the past! You have to focus on helping your new friends get discharged from here.";
			}
			
			if (primeInt == 62){
            dialogueText.text = "After that, you can eat icecream cake with all of them at a table just like this.";
			}
			
			if (primeInt == 63){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			  
			  
			if (primeInt == 70){
            dialogueText.text = "You don't feel anything in this freezer that could be any sort of cake. You do, however, feel various glass cylinders and...syringes?";
			}
			
			if (primeInt == 71){
            dialogueText.text = "Do they... not have a seperate medical freezer? This feels irresponsible.";
			}
			  
			if (primeInt == 72){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 80){
            dialogueText.text = "There are a looot of pill bottles here. Like... nothin' but bottles.";
			}
			
			if (primeInt == 81){
            dialogueText.text = "What did he think you were going to do in here..?";
			}
			  
			if (primeInt == 82){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			}
			
			if (primeInt == 90){
            dialogueText.text = "You really can't tell what pill bottles are for what sort of medicine. Though with your memory, you might be able to tell some of them by shape...";
			}
			
			if (primeInt == 91){
            dialogueText.text = "Would it be worth it to investigate?";
			}
			  
			if (primeInt == 92){
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
				   canPickUpCake = false;
                   //Debug.Log("Player left range");
             }
       }
}