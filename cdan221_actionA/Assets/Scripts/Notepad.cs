﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Notepad : MonoBehaviour {

        public static string myNotes;
        public GameObject inputField;
        public GameObject textDisplay;

        public void Start(){
                UpdateNotes();
        }

        public void UpdateNotes(){
                if (inputField.GetComponentInChildren<Text>().text != ""){
					myNotes = myNotes + " " + inputField.GetComponentInChildren<Text>().text;
				}
                textDisplay.GetComponent<Text>().text = myNotes;
                inputField.GetComponent<InputField>().text = "";
        }
		
		public void ClearNotes(){
			myNotes = "";
			UpdateNotes();
		} 
		
}
