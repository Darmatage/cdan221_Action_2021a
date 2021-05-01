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
	public GameObject dialogueBox2;
    public Text dialogueText2;
	public GameObject dialogueBox3;
    public Text dialogueText3;
	public bool allowSpace = false;
	   
    // Start is called before the first frame update
    void Start()
    {
		dialogueBox.SetActive(false);
		dialogueText.gameObject.SetActive(false);
		dialogueBox2.SetActive(false);
		dialogueText2.gameObject.SetActive(false);
		dialogueBox3.SetActive(false);
		dialogueText3.gameObject.SetActive(false);
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
			dialogueText.text = "HEY!";
		}

		if (primeInt ==2){
			dialogueText.text =  "What are you doing down here?";
		}
		 
		if (primeInt ==3){
            dialogueBox2.SetActive(true);
			dialogueText2.gameObject.SetActive(true);
			dialogueText2.text = "Patients aren't allowed to leave their rooms, you know.";
		}
		if (primeInt ==4){
            dialogueBox3.SetActive(true);
			dialogueText3.gameObject.SetActive(true);
			dialogueText3.text = "Come, now.";
		}
		if (primeInt ==5){
			dialogueText3.text =  "We'll escort you back to your room immediately.";
		}
		if (primeInt ==6){
			allowSpace = false;
            dialogueBox.SetActive(false);
			dialogueText.gameObject.SetActive(false);
            dialogueBox2.SetActive(false);
			dialogueText2.gameObject.SetActive(false);
            dialogueBox3.SetActive(false);
			dialogueText3.gameObject.SetActive(false);
			StartCoroutine(BacktoRoomDelay());
		}
	}
	public CameraShake cameraShake;
	
	public void BubbleShake(){
		StartCoroutine(cameraShake.ShakeMe(0.1f, 0.2f));
    }
	
	public IEnumerator BacktoRoomDelay()
    {
        yield return new WaitForSeconds(0.5F);
		SendBackToRoom();
		
    }
	
	public void SendBackToRoom(){
		SceneManager.LoadScene (ReturnLevel);
	}
}
