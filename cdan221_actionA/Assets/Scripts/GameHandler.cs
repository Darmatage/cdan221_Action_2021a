using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameHandler : MonoBehaviour{

        public static int playerStat;
        //public GameObject textGameObject;

        //void Start () { UpdateScore (); }

        void Update(){
                if (Input.GetKey("escape")){
                        Application.Quit();
                }
        }

        public void AddPlayerStat(int amount){
                playerStat += amount;
                Debug.Log("Current Player Stat = " + playerStat);
        //      UpdateScore ();
        }

        //void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("Scene1");
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