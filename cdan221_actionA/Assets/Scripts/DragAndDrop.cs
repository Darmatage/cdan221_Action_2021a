using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DragAndDrop : MonoBehaviour {

       private bool selected;
	   public string ReturnLevel = "MainMenu";

       void Update () {
              if (selected == true) {
                     Vector2 cursorPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
                     transform.position = new Vector2 (cursorPos.x, cursorPos.y);
              }

              if (Input.GetMouseButtonUp (0)) {
                     selected = false;
              }
			  if (Input.GetKeyDown(KeyCode.E)){
					GoBack();
              }
       }

       void OnMouseOver(){
              if (Input.GetMouseButtonDown (0)) {
                     selected = true;
              }
       }
	   
	public void GoBack(){
	SceneManager.LoadScene (ReturnLevel);
	}

}