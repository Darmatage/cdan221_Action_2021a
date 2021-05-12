using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LockKeypadClickControl1 : MonoBehaviour
{
	public string correctCode = "J97EKF";
	public static string playerCode = "";
	
	public static int totalDigits = 0;
	
	public string ReturnLevel = "Level1Scene2";
	public string SolvedLevel = "Level2Scene1";
	public GameObject KeypadSoundWrong;
	public GameObject KeypadSoundRight;
	public GameObject KeypadSoundBeep;
	public GameObject DownStairsSprite;
	public bool CanClick;
	
    // Start is called before the first frame update
    void Start()
    {
		KeypadSoundWrong.SetActive(false);
		KeypadSoundRight.SetActive(false);
		KeypadSoundBeep.SetActive(false);
		DownStairsSprite.SetActive(false);
		CanClick = true;
		GetComponent<SpriteRenderer>().color = new Color(0.3f,0.3f,0.3f);
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Enter")){
			GoBack();
        }
		
        Debug.Log(playerCode);
		if (totalDigits == 4){
			if (playerCode == correctCode){
				Debug.Log("Correct!");
				CanClick = false;
				KeypadSoundRight.SetActive(true);
				DownStairsSprite.SetActive(true);
				StartCoroutine(RightDelay());
				
			} else {
				playerCode = "";
				totalDigits = 0;
				Debug.Log("INCORRECT.");
				KeypadSoundWrong.SetActive(true);
				StartCoroutine(WrongDelay());
			}
		}
    }
	
	void OnMouseUp(){
		if (CanClick = true){
			playerCode += gameObject.name;
			totalDigits += 1;
			KeypadSoundBeep.SetActive(true);
			StartCoroutine(BeepDelay());
		}
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
		CanClick = false;
		KeypadSoundRight.SetActive(false);
		SolvedKeypad();
	}

	public IEnumerator BeepDelay(){
        yield return new WaitForSeconds(0.05F);
		KeypadSoundBeep.SetActive(false);
	}
	
	public void GoBack(){
		SceneManager.LoadScene (ReturnLevel);
	}
	
	public void SolvedKeypad(){
		SceneManager.LoadScene (SolvedLevel);
	}
}
