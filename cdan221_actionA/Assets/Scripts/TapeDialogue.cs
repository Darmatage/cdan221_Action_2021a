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
	
    // Start is called before the first frame update
    void Start()
    {
		dialogueBox.SetActive(false);
		dialogueText.gameObject.SetActive(false);
		allowSpace = false;
		allowP = true;
		primeInt = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && allowP){
			StartCoroutine(DialogueDelay());
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
			dialogueText.text = "A";
		}
		if (primeInt == 2){
			dialogueText.text = "B";
		}
		if (primeInt == 3){
			dialogueText.text = "C";
		}
		if (primeInt == 4){
			dialogueText.text = "D";
		}
		if (primeInt == 5){
			allowSpace = false;
			dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			allowP = true;
			primeInt = 0;
		}
	}
}
