using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TapeDialogue : MonoBehaviour
{
    public int primeInt = 0;
	public bool allowSpace = false;
	public bool allowP = true;
	public GameObject dialogueBox;
    public Text dialogueText;
	
	public GameObject TapeStartAudio;
	public GameObject TapeLoopAudio;
	public GameObject TapeEndAudio;
	
    // Start is called before the first frame update
    void Start()
    {
		dialogueBox.SetActive(false);
		dialogueText.gameObject.SetActive(false);
		TapeStartAudio.SetActive(false);
		TapeLoopAudio.SetActive(false);
		TapeEndAudio.SetActive(false);
		allowSpace = false;
		allowP = true;
		primeInt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && allowP){
			StartCoroutine(DialogueDelay());
			TapeStartAudio.SetActive(true);
			TapeLoopAudio.SetActive(true);
			TapeEndAudio.SetActive(false);
			allowP = false;
		}
		
		if (Input.GetButtonDown("Talk") && allowSpace){
			NPCDialogue();
		}
    }
	
    public IEnumerator DialogueDelay()
    {
        yield return new WaitForSeconds(0.1F);
		allowSpace = true;
		dialogueBox.SetActive(true);
		dialogueText.gameObject.SetActive(true);
		NPCDialogue();
    }
	
	public void NPCDialogue(){
		primeInt += 1;
		
		if (primeInt == 1){
			dialogueText.text = "Thanks for playing the demo!";
		}
		if (primeInt == 2){
			dialogueText.text = "...What, did you think I was just going to spoil the ending before the game is even finished?";
		}
		if (primeInt == 3){
			dialogueText.text = "I mean. The mysteries aren't all that complex. You could probably figure it out with the information everyone gave you already.";
		}
		if (primeInt == 4){
			dialogueText.text = "Still, I hope that you'll be interested enough to come back for more. See you then, Ema!";
		}
		if (primeInt == 5){
			allowSpace = false;
			dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			TapeStartAudio.SetActive(false);
			TapeEndAudio.SetActive(true);
			TapeLoopAudio.SetActive(false);
			allowP = true;
			primeInt = 0;
		}
	}
}
