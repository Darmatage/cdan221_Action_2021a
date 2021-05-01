using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LockKeypadClickControl : MonoBehaviour
{
	public static string correctCode = "J97EKF";
	public static string playerCode = "";
	
	public static int totalDigits = 0;
	
	public string ReturnLevel = "Level1Scene2";
	public string SolvedLevel = "Level2Scene1";
	
    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.E)){
			GoBack();
        }
		
        Debug.Log(playerCode);
		if (totalDigits == 6){
			if (playerCode == correctCode){
				Debug.Log("Correct!");
				SolvedKeypad();
			} else {
				playerCode = "";
				totalDigits = 0;
				Debug.Log("INCORRECT.");
			}
		}
    }
	
	void OnMouseUp(){
		playerCode += gameObject.name;
		totalDigits += 1;
	}
	
	public void GoBack(){
		SceneManager.LoadScene (ReturnLevel);
	}
	
	public void SolvedKeypad(){
		SceneManager.LoadScene (SolvedLevel);
	}
}
