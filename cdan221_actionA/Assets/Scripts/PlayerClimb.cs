using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerClimb : MonoBehaviour {

      public Animator anim;
      public Rigidbody2D rb2D;
      //public bool isAlive = true;

      void Start(){
           anim = gameObject.GetComponentInChildren<Animator>();
           rb2D = transform.GetComponent<Rigidbody2D>();
      }

      void OnTriggerStay2D(Collider2D other){
            if (other.gameObject.tag == "sceneClimbLeft"){
                  anim.SetBool("ClimbLeft", true);
            } else if (other.gameObject.tag == "sceneClimbRight"){
                  anim.SetBool("ClimbRight", true);
            } else {
                  anim.SetBool("ClimbLeft", false);
                  anim.SetBool("ClimbRight", false);
            }
      }

     void OnTriggerExit2D(Collider2D other){
            anim.SetBool("ClimbLeft", false); 
            anim.SetBool("ClimbRight", false);
            
            // if (other.gameObject.tag == "climbLeft"){
                  // anim.SetBool("ClimbLeft", false);
            // } else if (other.gameObject.tag == "climbRight"){
                  // anim.SetBool("ClimbRight", false);
            // }
      }
}