using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameHandler_PlayerReturn : MonoBehaviour {

    public static string lastRoom = "";
    public static Vector2 lastRoomPosition;       // where the Player entered a puzzle in a room
       
	private string h1 = "Level1Scene2";
	public static Vector2 HallPos1 = new Vector2 (-13, -1); 
	
	private string h2 = "Level2Scene1";
	public static Vector2 HallPos2 = new Vector2 (-18, -1);
	
	private string h3 = "Level3Scene1";
	public static Vector2 HallPos3 = new Vector2 (-18, -1);
	
	private string h4 = "Level4Scene1";
	public static Vector2 HallPos4 = new Vector2 (-18, -1);   
	
	private string h5 = "Level5Scene1";
	public static Vector2 HallPos5 = new Vector2 (-18, -1); 
	
	private string h6 = "Level6Scene1";
	public static Vector2 HallPos6 = new Vector2 (-18, -1);   
	    
	private string thisLevel;
    private Transform player;

    void Start() {
        thisLevel = SceneManager.GetActiveScene().name;
        if (GameObject.FindWithTag("Player") != null){
			player = GameObject.FindWithTag("Player").GetComponent<Transform>();
        }
		
		if ((thisLevel == h1) && (HallPos1 != null)){
			Debug.Log("Checking.");
			Vector3 playerReturn = new Vector3(HallPos1.x, HallPos1.y, player.position.z);
			player.position = playerReturn;
		} 
		else if ((thisLevel == h2) && (HallPos2 != null)){
			Debug.Log("Checking.");
			Vector3 playerReturn = new Vector3(HallPos2.x, HallPos2.y, player.position.z);
			player.position = playerReturn;
		}
		else if ((thisLevel == h3) && (HallPos3 != null)){
			Debug.Log("Checking.");
			Vector3 playerReturn = new Vector3(HallPos3.x, HallPos3.y, player.position.z);
			player.position = playerReturn;
		}			
		else if ((thisLevel == h4) && (HallPos4 != null)){
			Debug.Log("Checking.");
			Vector3 playerReturn = new Vector3(HallPos4.x, HallPos4.y, player.position.z);
			player.position = playerReturn;
		}
		else if ((thisLevel == h5) && (HallPos5 != null)){
			Debug.Log("Checking.");
			Vector3 playerReturn = new Vector3(HallPos5.x, HallPos5.y, player.position.z);
			player.position = playerReturn;
		}
		else if ((thisLevel == h6) && (HallPos6 != null)){
			Debug.Log("Checking.");
			Vector3 playerReturn = new Vector3(HallPos6.x, HallPos6.y, player.position.z);
			player.position = playerReturn;
		}
		else if (lastRoom != null){
			if (thisLevel == lastRoom){
				player.position = lastRoomPosition;
			}
		}
			
	}
	
	
	public void UpdateLocation(){
		string thisScene = SceneManager.GetActiveScene().name;
		//update the records of last location in each hallways or most recent room
		if (thisScene == h1){HallPos1 = player.position;} 
		else if (thisScene == h2){HallPos2 = player.position;} 
		else if (thisScene == h3){HallPos3 = player.position;} 
		else if (thisScene == h4){HallPos4 = player.position;} 
		else if (thisScene == h5){HallPos5 = player.position;} 
		else if (thisScene == h6){HallPos6 = player.position;} 
		else {
			lastRoom = thisScene;
			//Vector2 playerPos = new Vector2(player.position.x, (player.position.y - 2))
			lastRoomPosition = player.position;
		}
		
		Debug.Log("I updated location for : " + thisScene + ": " + player.position);
		
	}
	
}