using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScene : MonoBehaviour
{
	public string ReturnLevel = "MainMenu";
	public int primeInt = 0;
	public GameObject dialogueBox;
    public Text dialogueText;
	public bool allowSpace = false;
	   
    // Start is called before the first frame update
    void Start()
    {
		dialogueBox.SetActive(false);
		dialogueText.gameObject.SetActive(false);
		allowSpace = false;		
	    StartCoroutine(DialogueDelay());
    }
	
	void Update()
	{
		if (Input.GetButtonDown("Talk") && allowSpace){
			NPCDialogue();
		}		
	}

    public IEnumerator DialogueDelay()
    {
        yield return new WaitForSeconds(1F);
		Debug.Log("People start shouting.");
		dialogueBox.SetActive(true);
		dialogueText.gameObject.SetActive(true);
		allowSpace = true;
		NPCDialogue();
		
    }
	
	public void NPCDialogue(){
		primeInt += 1;
		
		if (primeInt == 1){
			dialogueText.text = "This is is just some placeholder text for the gameover event.";
		}

		if (primeInt ==2){
			dialogueText.text =  "I gotta replace it at some point...";
		}
		 
		if (primeInt ==3){
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
			SendBackToRoom();
		}
	}
	
	public void SendBackToRoom(){
		SceneManager.LoadScene (ReturnLevel);
	}
}
