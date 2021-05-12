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
        if (Input.GetButtonDown("PlayTape") && allowP){
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
			dialogueText.text = "Ba-da-daa-duuummm! Congratulations! You found my secret message!";
		}
		if (primeInt == 2){
			dialogueText.text = "So, what did you think? I tried to leave behind as many clues as I could, but it’s hard. Sometimes you can't solve things through logic alone.";
		}
		if (primeInt == 3){
			dialogueText.text = "Whoever you are, if you’re hearing this it means you found me after Claudia hid me away. You probably came looking because you want to save everyone who's been trapped here.";
		}
		if (primeInt == 4){
			dialogueText.text = "Well, the good news is this; you can break everyone out. It’s super easy.";
		}
		if (primeInt == 5){
			dialogueText.text = "There’s a place in the basement that controls all the power in the building. It has a kill switch. Only Claudia knows the code. ";
		}
		if (primeInt == 6){
			dialogueText.text = "Problem is...remember what I said about logic? I can tell you the what, and the where, but not the why or how.";
		}
		if (primeInt == 7){
			dialogueText.text = "Everything Claudia does is motivated by her feelings, so it has to be something important. But the code... it doesn’t even have numbers. Or letters. I was completely stumped.";
		}
		if (primeInt == 8){
			dialogueText.text = "It’s probably because I can’t understand her at all. What does she actually care about? I don’t know. I thought I did.";
		}
		if (primeInt == 9){
			dialogueText.text = "Anyways. I think I’m out of time. Good luck, be safe, and take good care of them.";
		}
		if (primeInt == 10){
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
