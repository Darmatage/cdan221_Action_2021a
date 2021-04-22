using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Level1StartManager : MonoBehaviour
{
	
	public GameObject thePlayer;
	public GameObject wakeUpSprite;
	public float narrateDelay = 2f;
	
    // Start is called before the first frame update
    void Start(){
		thePlayer = GameObject.FindWithTag("Player");

		thePlayer.GetComponent<PlayerMoveAround>().isAlive = false;
		thePlayer.SetActive(false);
		wakeUpSprite.SetActive(true);
		StartCoroutine(DelayNarration());
    }

    // autoplace narration in dialoguebox
    public void myTalking(int switchNum){
        
		
		
		
    }
	
	
	IEnumerator DelayNarration (){
		yield return new WaitForSeconds(narrateDelay);
		myTalking(1);
		yield return new WaitForSeconds(narrateDelay);
		myTalking(2);
		yield return new WaitForSeconds(narrateDelay);
		myTalking(3);
		yield return new WaitForSeconds(narrateDelay);
		wakeUpSprite.SetActive(false);
		thePlayer.SetActive(true);
		thePlayer.GetComponent<PlayerMoveAround>().isAlive = true;
	}
	
}
