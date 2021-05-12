using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{

        public static int playerStat;
        //public GameObject textGameObject;
		
		public static int gameProgression = 1;

		public static bool stairCaseUnlocked = false; //use this in other scenes: GameHandler.stairCaseUnlocked = true;
		
		public static bool KnowSav = false;
		
		public static bool BasementUnlock = false;
		
		public static bool MedStudentGone = false;
		
		public static bool itemFileLani = false; 
		public static bool itemFileAaron = false; 
		public static bool itemIdDrClaudia = false; 
		public static bool itemIdDrMark = false; 
		public static bool itemCake = false; 
		
		public static bool HasJournal = false;
		
		public static bool SafeUnlock = false;
		public static bool HasKey = false;
		
		//void Start () { UpdateScore (); }
		
		void Update(){
			if (Input.GetKeyDown(KeyCode.R)){
				CheckInventory();
			}
			if (Input.GetKeyDown(KeyCode.P)){
				CheckProgression();
			}
		}
		

        public void AddPlayerStat(int amount){
                playerStat += amount;
                Debug.Log("Current Player Stat = " + playerStat);
        //      UpdateScore ();
        }

		public void CheckInventory(){
			 Debug.Log("INVENTORY: \n");
			if (itemFileLani == true){
                Debug.Log("Lani Patient File \n");
			}
			if (itemFileAaron == true){
                Debug.Log("Aaron Patient File \n");
			}
			if (itemIdDrClaudia == true){
                Debug.Log("Dr Claudia ID \n");
			}
			if (itemIdDrMark == true){
                Debug.Log("Dr Mark ID \n");
			}
			if (itemCake == true){
                Debug.Log("Cake\n");
			}
        }
		
		public void CheckProgression(){
			switch (gameProgression){
				case 1:
					Debug.Log("1");
					break;
				case 2:
					Debug.Log("2");
					break;
				case 3:
					Debug.Log("3");
					break;
				case 4:
					Debug.Log("4");
					break;
				case 5:
					Debug.Log("5");
					break;
				case 6:
					Debug.Log("6");
					break;
				case 7:
					Debug.Log("7");
					break;
			}
		}


        //void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("Level1Scene1");
        }

        public void RestartGame(){
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
}