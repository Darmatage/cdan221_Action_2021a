using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClaudiaCutscene : MonoBehaviour
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
			dialogueText.text = "What are you doing here? Ema.";
		}
		if (primeInt == 2){
			dialogueText.text = "You know you’re unwell. It’s unsafe for you to be so far from your room. Return at once, and we can forget all about this.";
		}
		if (primeInt == 3){
			dialogueText.text = "...No. That’s impossible for you, isn’t it? With that memory of yours.";
		}
		if (primeInt == 4){
			dialogueText.text = "So, what did they say about me? That I’m a mad scientist? A cold-hearted prison warden? Well, let me tell you the truth: ";
		}
		if (primeInt == 5){
			dialogueText.text = "I’m a doctor, and I’m a mother. That’s all there is to it.";
		}
		if (primeInt == 6){
			dialogueText.text = "When a mother sees her child in pain… what else is she supposed to do but protect them? Even if it means going against her child’s wishes.";
		}
		if (primeInt == 7){
			dialogueText.text = "He was unhappy here, yes. He was always unhappy. And the more I tried to help him… the more he resisted. He was careless, and only hurt himself further.";
		}
		if (primeInt == 8){
			dialogueText.text = "So what I did to him wasn’t a punishment. It was only a necessity. This is the only way he’ll stay alive long enough for me to cure him.";
		}
		if (primeInt == 9){
			dialogueText.text = "Do you understand? I only want what's best... for all of you.";
		}
		if (primeInt == 10){
			dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			GameHandler.ClaudiaEncountered = true;
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
