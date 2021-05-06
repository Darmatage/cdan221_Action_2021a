using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RadioSlider : MonoBehaviour
{
	public GameObject dialogueBox;
    public Text dialogueText;
    public int primeInt = 1;
	public Slider sliderInstance;
	public bool allowSpace = false;
	public string ReturnLevel = "Level4Scene3";
	bool DialogueTriggered = false;
	public GameObject radioSource0;
	public GameObject radioSource1;
	public GameObject radioSource2;
	public GameObject radioSource3;
	public GameObject radioSource4;
	public GameObject radioSource5;
	public GameObject radioSource6;
	public GameObject radioSource7;
	public GameObject radioSource8;
	public GameObject radioSource9;
	public GameObject radioSource10;
	
	
	void Start(){
		dialogueBox.SetActive(false);
		dialogueText.gameObject.SetActive(false);
		sliderInstance.minValue = 0;
		sliderInstance.maxValue = 10;
		sliderInstance.wholeNumbers = true;
		sliderInstance.value = 1;
		
		allowSpace = false;
		dialogueBox.SetActive(false);
		dialogueText.gameObject.SetActive(false);
	}
	
	void Update(){
		
		if (Input.GetKeyDown(KeyCode.E)){
			GoBack();
        }
		
		if (Input.GetButtonDown("Talk") && allowSpace){
			NPCDialogue();
		}
		
		switch(sliderInstance.value){
			case 0:
				radioSource0.SetActive(true);
				radioSource1.SetActive(false);
				radioSource2.SetActive(false);
				radioSource3.SetActive(false);
				radioSource4.SetActive(false);
				radioSource5.SetActive(false);
				radioSource6.SetActive(false);
				radioSource7.SetActive(false);
				radioSource8.SetActive(false);
				radioSource9.SetActive(false);
				radioSource10.SetActive(false);
				break;
			case 1:
				radioSource0.SetActive(false);
				radioSource1.SetActive(true);
				radioSource2.SetActive(false);
				radioSource3.SetActive(false);
				radioSource4.SetActive(false);
				radioSource5.SetActive(false);
				radioSource6.SetActive(false);
				radioSource7.SetActive(false);
				radioSource8.SetActive(false);
				radioSource9.SetActive(false);
				radioSource10.SetActive(false);
				break;
			case 2:
				radioSource0.SetActive(false);
				radioSource1.SetActive(false);
				radioSource2.SetActive(true);
				radioSource3.SetActive(false);
				radioSource4.SetActive(false);
				radioSource5.SetActive(false);
				radioSource6.SetActive(false);
				radioSource7.SetActive(false);
				radioSource8.SetActive(false);
				radioSource9.SetActive(false);
				radioSource10.SetActive(false);
				break;
			case 3:
				radioSource0.SetActive(false);
				radioSource1.SetActive(false);
				radioSource2.SetActive(false);
				radioSource3.SetActive(true);
				radioSource4.SetActive(false);
				radioSource5.SetActive(false);
				radioSource6.SetActive(false);
				radioSource7.SetActive(false);
				radioSource8.SetActive(false);
				radioSource9.SetActive(false);
				radioSource10.SetActive(false);
				break;
			case 4:
				radioSource0.SetActive(false);
				radioSource1.SetActive(false);
				radioSource2.SetActive(false);
				radioSource3.SetActive(false);
				radioSource4.SetActive(true);
				radioSource5.SetActive(false);
				radioSource6.SetActive(false);
				radioSource7.SetActive(false);
				radioSource8.SetActive(false);
				radioSource9.SetActive(false);
				radioSource10.SetActive(false);
				break;
			case 5:
				radioSource0.SetActive(false);
				radioSource1.SetActive(false);
				radioSource2.SetActive(false);
				radioSource3.SetActive(false);
				radioSource4.SetActive(false);
				radioSource5.SetActive(true);
				radioSource6.SetActive(false);
				radioSource7.SetActive(false);
				radioSource8.SetActive(false);
				radioSource9.SetActive(false);
				radioSource10.SetActive(false);
				break;
			case 6:
				radioSource0.SetActive(false);
				radioSource1.SetActive(false);
				radioSource2.SetActive(false);
				radioSource3.SetActive(false);
				radioSource4.SetActive(false);
				radioSource5.SetActive(false);
				radioSource6.SetActive(true);
				radioSource7.SetActive(false);
				radioSource8.SetActive(false);
				radioSource9.SetActive(false);
				radioSource10.SetActive(false);
				break;
			case 7:
				allowSpace = false;
				dialogueBox.SetActive(false);
				dialogueText.gameObject.SetActive(false);
				primeInt = 0;
				DialogueTriggered = false;
				radioSource0.SetActive(false);
				radioSource1.SetActive(false);
				radioSource2.SetActive(false);
				radioSource3.SetActive(false);
				radioSource4.SetActive(false);
				radioSource5.SetActive(false);
				radioSource6.SetActive(false);
				radioSource7.SetActive(true);
				radioSource8.SetActive(false);
				radioSource9.SetActive(false);
				radioSource10.SetActive(false);
				break;
			case 8:
				if(DialogueTriggered == false){
					StartCoroutine(DialogueDelay());
					DialogueTriggered = true;
				}
				radioSource0.SetActive(false);
				radioSource1.SetActive(false);
				radioSource2.SetActive(false);
				radioSource3.SetActive(false);
				radioSource4.SetActive(false);
				radioSource5.SetActive(false);
				radioSource6.SetActive(false);
				radioSource7.SetActive(false);
				radioSource8.SetActive(true);
				radioSource9.SetActive(false);
				radioSource10.SetActive(false);
				break;
			case 9:
				allowSpace = false;
				dialogueBox.SetActive(false);
				dialogueText.gameObject.SetActive(false);
				primeInt = 0;
				DialogueTriggered = false;
				radioSource0.SetActive(false);
				radioSource1.SetActive(false);
				radioSource2.SetActive(false);
				radioSource3.SetActive(false);
				radioSource4.SetActive(false);
				radioSource5.SetActive(false);
				radioSource6.SetActive(false);
				radioSource7.SetActive(false);
				radioSource8.SetActive(false);
				radioSource9.SetActive(true);
				radioSource10.SetActive(false);
				break;
			case 10:
				radioSource0.SetActive(false);
				radioSource1.SetActive(false);
				radioSource2.SetActive(false);
				radioSource3.SetActive(false);
				radioSource4.SetActive(false);
				radioSource5.SetActive(false);
				radioSource6.SetActive(false);
				radioSource7.SetActive(false);
				radioSource8.SetActive(false);
				radioSource9.SetActive(false);
				radioSource10.SetActive(true);
				break;
		}
	}
	
	public void NPCDialogue(){
		primeInt += 1;
		
		if (primeInt == 1){
			dialogueText.text = "There's a piece of paper at the bottom of the bottle.";
		}
		if (primeInt == 2){
			dialogueText.text = "It's a note.";
		}
		if (primeInt == 3){
			dialogueText.text = "DOOR CODE: F3X7F8";
		}
		if (primeInt == 4){
			allowSpace = false;
			dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
			primeInt = 0;
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
	
	public void OnValueChanged(float value){
		Debug.Log ("New Value " + value);
	}
	
	public void GoBack(){
		SceneManager.LoadScene (ReturnLevel);
	}

}
