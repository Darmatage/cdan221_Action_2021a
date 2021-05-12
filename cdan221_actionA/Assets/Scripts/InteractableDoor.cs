using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableDoor : MonoBehaviour {

	   public string NextLevel = "MainMenu";
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
                     Debug.Log("You pressed E and get a thing!");
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
		   SceneManager.LoadScene (NextLevel);
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