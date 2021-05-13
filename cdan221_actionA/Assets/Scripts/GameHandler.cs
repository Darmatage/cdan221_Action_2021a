using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{

        public static int playerStat;
        //public GameObject textGameObject;
		
		public static bool Level1Complete = false;
		public static bool Level2Complete = false;
		public static bool Level3Complete = false;
		public static bool Level4Complete = false;

		public static bool stairCaseUnlocked = false; //use this in other scenes: GameHandler.stairCaseUnlocked = true;
		public static bool BasementUnlock = false;
		public static bool KnowSav = false;
		
		public static bool MedStudentGone = false;
		
		public static bool itemFileLani = false; 
		public static bool itemFileSavanna = false; 
		public static bool itemFileJack = false; 
		public static bool itemFileAaron = false; 
		public static bool itemIdDrClaudia = false; 
		public static bool itemIdDrMark = false; 
		public static bool itemCake = false; 
		
		public static bool HasJournal = false; 
		public static bool SafeUnlock = false;
		public static bool HasKey = false;
		public static bool RingofKeys = false;
		
		public static bool ClaudiaEncountered = false;
		
		//void Start () { UpdateScore (); }
		
		void Update(){
			if (Input.GetKeyDown(KeyCode.R)){
				CheckInventory();
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
			if (itemFileSavanna == true){
                Debug.Log("Sav Patient File \n");
			}
			if (itemFileJack == true){
                Debug.Log("Jack Patient File \n");
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

        //void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("BeginningCutscene");
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