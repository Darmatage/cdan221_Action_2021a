using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BeginningCutscene : MonoBehaviour
{
    public GameObject dialogueBox;
    public Text dialogueText;
    public int primeInt = 0;
	public bool allowSpace = false;
	
	public string EndLevel = "Level1Scene1";
	
    // Start is called before the first frame update
    void Start()
    {
        dialogueBox.SetActive(false);
		dialogueText.gameObject.SetActive(false);
		StartCoroutine(DialogueDelay());
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Talk") && allowSpace){
			NPCDialogue();
		}
    }
	
	public void NPCDialogue(){
		primeInt += 1;
		
		if (primeInt == 1){
			dialogueText.text = "Where...are you?";
		}
		if (primeInt == 2){
			dialogueText.text = "Your head hurts... you feel like you can barely move. You slowly get your limbs to move one by one as your body awakens.";
		}
		if (primeInt == 3){
			dialogueText.text = "What exactly happened to you? It's unusual for you to have any gaps in your memory at all... You've always been rather proud of your skill for remembering things.";
		}
		if (primeInt == 4){
			dialogueText.text = "But nothing comes to mind. And the room is so dark, you can't see anything at all.";
		}
		if (primeInt == 5){
			dialogueText.text = "No... it's not that the room is dark... If you lift a hand to your face, you can feel it. The dried blood soaking through your bandages...";
		}
		if (primeInt == 6){
			dialogueText.text = "You feel yourself begin to panic. You call out for somebody in the room to help you, but no answer comes.";
		}
		if (primeInt == 7){
			dialogueText.text = "You have an awful feeling about this. But let's stay calm for now, and observe your surroundings.";
		}
		if (primeInt == 8){
			dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			SendToEnd();
		}
	}
	
    public IEnumerator DialogueDelay()
    {
        yield return new WaitForSeconds(2F);
		allowSpace = true;
		dialogueBox.SetActive(true);
		dialogueText.gameObject.SetActive(true);
		NPCDialogue();
    }
		
	public void SendToEnd(){
		SceneManager.LoadScene (EndLevel);
	}
}
