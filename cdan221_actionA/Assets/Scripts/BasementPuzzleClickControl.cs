using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasementPuzzleClickControl : MonoBehaviour
{
	public static string correctCode = "J97EKF";
	public static string playerCode = "";
	
	public static int totalDigits = 0;
	
	public string ReturnLevel = "Level1Scene2";
	public string SolvedLevel = "Level2Scene1";
	public GameObject KeypadSoundWrong;
	public GameObject KeypadSoundRight;
	public GameObject NoteSound;
	public GameObject Dot1;
	public GameObject Dot2;
	public GameObject Dot3;
	public GameObject Dot4;
	public GameObject Dot5;
	public GameObject Dot6;
	
    // Start is called before the first frame update
    void Start()
    {
		GetComponent<SpriteRenderer>().color = new Color(0.3f,0.3f,0.3f);
		KeypadSoundWrong.SetActive(false);
		KeypadSoundRight.SetActive(false);
		NoteSound.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.E)){
			GoBack();
        }
		
		if (Input.GetKeyDown(KeyCode.R)){
			Reset();
        }
		
        Debug.Log(playerCode);
		if (totalDigits == 6){
			if (playerCode == correctCode){
				Debug.Log("Correct!");
				KeypadSoundRight.SetActive(true);
				StartCoroutine(RightDelay());
				
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
		playerCode += gameObject.name;
		totalDigits += 1;
		NoteSound.SetActive(true);
		StartCoroutine(NoteSoundDelay());
	}
	
	void OnMouseOver(){
		GetComponent<SpriteRenderer>().color = new Color(1,1,1);
	}
	
	void OnMouseExit(){
		GetComponent<SpriteRenderer>().color = new Color(0.3f,0.3f,0.3f);
	}
	
	public IEnumerator WrongDelay(){
        yield return new WaitForSeconds(0.5F);
		KeypadSoundWrong.SetActive(false);
	}
	
	public IEnumerator RightDelay(){
        yield return new WaitForSeconds(0.5F);
		KeypadSoundRight.SetActive(false);
		SolvedKeypad();
	}
	
	public IEnumerator NoteSoundDelay(){
        yield return new WaitForSeconds(0.1F);
		NoteSound.SetActive(false);
	}
	
	public void GoBack(){
		SceneManager.LoadScene (ReturnLevel);
	}
	
	public void SolvedKeypad(){
		SceneManager.LoadScene (SolvedLevel);
	}
	
	public void Reset(){
		playerCode = "";
		totalDigits = 0;
		Debug.Log("reset.");
	}
	
	
}
