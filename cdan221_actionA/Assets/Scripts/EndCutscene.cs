using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndCutscene : MonoBehaviour
{
    public GameObject dialogueBox;
    public Text dialogueText;
    public int primeInt = 0;
	
	public string EndLevel = "Level2Scene1";
	
    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(true);
		dialogueText.gameObject.SetActive(true);
		NPCDialogue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Talk")){
		NPCDialogue();
		}
    }
	
	public void NPCDialogue(){
		primeInt += 1;
		
		if (primeInt == 1){
			dialogueText.text = "You can hear lights all over the hospital powering off. Claudia gasps, and then lets out a horrid cry.";
		}
		
		if (primeInt == 2){
			dialogueText.text = "\"No...No, no, NO!\" she screams. \"How could you?! I only ever wanted to protect you!";
		}
		
		if (primeInt == 3){
			dialogueText.text = "\"You’re nothing but a group of broken rejects! Defective little machines with missing parts. That’s how the people out there see you; Useless.\"";
		}
		
		if (primeInt == 4){
			dialogueText.text = "\"That’s just how they always treated Aaron! I’m the only one who understands; I’m the only one who ever loved him! Do you really want to take his future away from him?!\"";
		}
		
		if (primeInt == 5){
			dialogueText.text = "Ignore her. Don't look back. Your footsteps are soon accompanied by dozens of others, hurrying towards the newly-unlocked exits.";
		}
		
		if (primeInt == 6){
			dialogueText.text = "You make your way up to the ground floor and can feel a light breeze on your face.";
		}
		
		if (primeInt == 7){
			dialogueText.text = "The front door has already been thrown open.";
		}
		
		if (primeInt == 8){
			dialogueText.text = "You can hear the familiar voices of the other patients grow louder as you walk through the door. And you just think... She was wrong.";
		}
		
		if (primeInt == 9){
			dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			SendToEnd();
		}
	}
		
	public void SendToEnd(){
		SceneManager.LoadScene (EndLevel);
	}
}
