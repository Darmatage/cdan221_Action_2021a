﻿using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SecondFloorInteractableDoor : MonoBehaviour {

	   public string levelTwoReturnMap = "Return_Level2";
	   public string levelThreeReturnMap = "Return_Level3";
	   public string levelFourReturnMap = "Return_Level4";
	   private GameHandler_PlayerReturn gh_PlayerReturn;
       //public GameObject pulseVFX;
       //public AudioSource pulseSFX;
       public GameObject msgPressE;
       public bool canPressE =false;


       void Start(){
              msgPressE.SetActive(false);
			  gh_PlayerReturn = GameObject.FindWithTag("GameHandler").GetComponent<GameHandler_PlayerReturn>();
       }

       void Update(){
              if ((canPressE == true) && (Input.GetButtonDown("Enter"))){
                     //Put code here for getting a result, like revealing a message or secret door
                     //Debug.Log("You pressed E and get a thing!");
					 EnterDoor();
              }
       }

       void OnTriggerEnter2D(Collider2D other){
              if (other.gameObject.tag == "Player"){
                     //GameObject vfx = Instantiate(pulseVFX, transform.position, Quaternion.identity);
                     //StartCoroutine(DestroyVFX(vfx));
                     //pulseSFX.Play();
                     msgPressE.SetActive(true);
                     canPressE =true;
              }
       }

       void OnTriggerExit2D(Collider2D other){
              if (other.gameObject.tag == "Player"){
                     msgPressE.SetActive(false);
                     canPressE = false;
              }
       }
	   
	   public void EnterDoor(){
		   gh_PlayerReturn.UpdateLocation();
		   Debug.Log("You entered a door");
		   if(GameHandler.Level5Complete == true){
				//Level 6 return here)
		   } else if (GameHandler.Level4Complete == true){	
				//Level 5 return here)
		   } else if (GameHandler.Level3Complete){
				SceneManager.LoadScene (levelFourReturnMap);
		   } else if (GameHandler.Level2Complete){
				SceneManager.LoadScene (levelThreeReturnMap);
		   } else if (GameHandler.Level1Complete){
				SceneManager.LoadScene (levelTwoReturnMap);
		   } else {SceneManager.LoadScene (levelTwoReturnMap);}
	   }

       IEnumerator DestroyVFX(GameObject vfx){
              yield return new WaitForSeconds(0.5f);
              Destroy(vfx);
       }

      //NOTE: Draw a sphere at transform's position:
       void OnDrawGizmos(){
              Gizmos.color = Color.yellow;
              Gizmos.DrawWireSphere(transform.position, 1);
       }
}