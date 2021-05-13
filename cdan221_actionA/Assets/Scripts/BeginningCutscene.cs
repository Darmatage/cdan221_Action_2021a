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
			dialogueText.text = "You can hear lights \"all\" over the hospital powering off.";
		}
		if (primeInt == 2){
			dialogueText.text = "Followed by the sounds of hurried footsteps as patients run for the newly unlocked exits.";
		}
		if (primeInt == 3){
			dialogueText.text = "You make your way up to the ground floor and can feel a light breeze on your face.";
		}
		if (primeInt == 4){
			dialogueText.text = "The front door has already been thrown open.";
		}
		if (primeInt == 5){
			dialogueText.text = "You can hear the familiar voices of your friends grow louder as you walk through the door.";
		}
		if (primeInt == 6){
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
