using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveSystem : MonoBehaviour
{
    public GameObject correctForm;
	public string ReturnLevel = "MainMenu";
    private bool moving = false;
    private bool finish = false;

    private float startPosX;
    private float startPosY;

    private Vector3 resetPosition;
	
	private float finishRange = 0.5f;

    void Start()
    {
        resetPosition = this.transform.localPosition;
    }

  
    void Update()
    {
        if (finish == false)
        {
            if (moving)
            {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPosX, mousePos.y - startPosY, this.gameObject.transform.localPosition.z);
            }
        }
		
		if (Input.GetButtonDown("Enter")){
		GoBack();
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;

            moving = true;
        }
    }

    private void OnMouseUp()
    {
        moving = false;

        if(Mathf.Abs(this.transform.localPosition.x - correctForm.transform.localPosition.x) <= finishRange &&
           Mathf.Abs(this.transform.localPosition.y - correctForm.transform.localPosition.y) <= finishRange)
        {
            this.transform.position = new Vector3(correctForm.transform.position.x, correctForm.transform.position.y, correctForm.transform.position.z);
            finish = true;
        }
        else
        {
            this.transform.localPosition = new Vector3(resetPosition.x, resetPosition.y, resetPosition.z);
        }
    }
	
	
      //NOTE: to help see the attack sphere in editor:
      void OnDrawGizmosSelected(){
           
            Gizmos.DrawWireSphere(transform.position, finishRange);
      }	
	  
	public void GoBack(){
	SceneManager.LoadScene (ReturnLevel);
	}
}
