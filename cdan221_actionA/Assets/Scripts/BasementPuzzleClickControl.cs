using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasementPuzzleClickControl : MonoBehaviour
{
	public static string correctCode = "654312";
	public static string playerCode = "";
	
	public static int totalDigits = 0;
	
	public string ReturnLevel = "Level7Scene2";
	public string EndCutsceneLevel = "EndCutscene";
	public GameObject KeypadSoundWrong;
	public GameObject KeypadSoundRight;
	public GameObject NoteSound;
	public GameObject Dot1;
	public GameObject Dot2;
	public GameObject Dot3;
	public GameObject Dot4;
	public GameObject Dot5;
	public GameObject Dot6;
	
	public GameObject blackScreen;
	
    // Start is called before the first frame update
    void Start()
    {
		GetComponent<SpriteRenderer>().color = new Color(0.3f,0.3f,0.3f);
		KeypadSoundWrong.SetActive(false);
		KeypadSoundRight.SetActive(false);
		NoteSound.SetActive(false);

		blackScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Enter") && totalDigits != 7){
			GoBack();
        }
		
		//if (Input.GetKeyDown(KeyCode.R) && totalDigits != 7){
		if (Input.GetButtonDown("Talk") && totalDigits != 7){
			Reset();
        }

        Debug.Log(playerCode);
		if (totalDigits == 6){
			if (playerCode == correctCode){
				Debug.Log("Correct!");
				blackScreen.SetActive(true);
				KeypadSoundRight.SetActive(true);
				totalDigits = 7;
				StartCoroutine(EndCutsceneDelay());
				
			} else {
				playerCode = "";
				totalDigits = 0;
				Debug.Log("INCORRECT.");
				KeypadSoundWrong.SetActive(true);
				StartCoroutine(WrongDelay());
			}
		}
		
		switch (totalDigits){
			case 0:
				Dot1.SetActive(false);
				Dot2.SetActive(false);
				Dot3.SetActive(false);
				Dot4.SetActive(false);
				Dot5.SetActive(false);
				Dot6.SetActive(false);
				break;
				
			case 1:
				Dot1.SetActive(true);
				Dot2.SetActive(false);
				Dot3.SetActive(false);
				Dot4.SetActive(false);
				Dot5.SetActive(false);
				Dot6.SetActive(false);
				break;
				
			case 2:
				Dot1.SetActive(true);
				Dot2.SetActive(true);
				Dot3.SetActive(false);
				Dot4.SetActive(false);
				Dot5.SetActive(false);
				Dot6.SetActive(false);
				break;
				
			case 3:
				Dot1.SetActive(true);
				Dot2.SetActive(true);
				Dot3.SetActive(true);
				Dot4.SetActive(false);
				Dot5.SetActive(false);
				Dot6.SetActive(false);
				break;
				
			case 4:
				Dot1.SetActive(true);
				Dot2.SetActive(true);
				Dot3.SetActive(true);
				Dot4.SetActive(true);
				Dot5.SetActive(false);
				Dot6.SetActive(false);
				break;
				
			case 5:
				Dot1.SetActive(true);
				Dot2.SetActive(true);
				Dot3.SetActive(true);
				Dot4.SetActive(true);
				Dot5.SetActive(true);
				Dot6.SetActive(false);
				break;
				
			case 6:
				Dot1.SetActive(true);
				Dot2.SetActive(true);
				Dot3.SetActive(true);
				Dot4.SetActive(true);
				Dot5.SetActive(true);
				Dot6.SetActive(true);
				break;
		}
    }
	
	void OnMouseUp(){
		if (totalDigits != 7){
			playerCode += gameObject.name;
			totalDigits += 1;
			NoteSound.SetActive(true);
			StartCoroutine(NoteSoundDelay());
		}
	}
	
	void OnMouseOver(){
		if (totalDigits != 7){
			GetComponent<SpriteRenderer>().color = new Color(1,1,1);
		}
	}
	void OnMouseExit(){
		if (totalDigits != 7){
			GetComponent<SpriteRenderer>().color = new Color(0.3f,0.3f,0.3f);
		}
	}
	
	public IEnumerator WrongDelay(){
        yield return new WaitForSeconds(0.5F);
		KeypadSoundWrong.SetActive(false);
	}
	
	public IEnumerator NoteSoundDelay(){
        yield return new WaitForSeconds(0.1F);
		NoteSound.SetActive(false);
	}
	
	public IEnumerator EndCutsceneDelay(){
        yield return new WaitForSeconds(1.5F);
		SendToEndCutscene();
	}
	
	public void GoBack(){
		SceneManager.LoadScene (ReturnLevel);
	}
	
	public void SendToEndCutscene(){
		SceneManager.LoadScene (EndCutsceneLevel);
	}
	
	public void Reset(){
		playerCode = "";
		totalDigits = 0;
		Debug.Log("reset.");
	}
	
	
}
