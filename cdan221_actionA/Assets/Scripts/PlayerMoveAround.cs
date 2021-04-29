using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class PlayerMoveAround : MonoBehaviour {

    public Animator animator;
    public Rigidbody2D rb2D;
    private bool FaceRight = true; // determine which way player is facing.
    public static float runSpeed = 10f;
    public float startSpeed = 10f;
    public bool isAlive = true;
	  
	public bool isNearWall = false;
	  
	//scaleByDepth
	public bool scaleByDepth = false;
	public float scaleMultiplier = 1.2f; //set to 1 for greater depth
	private float scaleHeight = -5.6f;
	private Vector3 startHeight;	

      void Start(){
           animator = gameObject.GetComponentInChildren<Animator>();
           rb2D = transform.GetComponent<Rigidbody2D>();
		   
		   //scaleByDepth
		   if (GameObject.FindWithTag("PlayerScaleBottom") != null){
			   scaleHeight = GameObject.FindWithTag("PlayerScaleBottom").transform.position.y;
		   }
		   startHeight = transform.localScale;
      }

      void Update(){
            //NOTE: Horizontal axis: [a] / left arrow is -1, [d] / right arrow is 1
            //NOTE: Vertical axis: [w] / up arrow, [s] / down arrow
            Vector3 hvMove = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
           if (isAlive == true){
                 
                transform.position = transform.position + hvMove * runSpeed * Time.deltaTime;


				if ((Input.GetAxis("Horizontal") != 0) || (Input.GetAxis("Vertical") != 0)){
					if (isNearWall == true){
						animator.SetBool ("WalkWall", true);
						animator.SetBool ("Walk", false);
						animator.SetBool ("IdleWall", false);
					} else if (isNearWall == false){
						animator.SetBool ("Walk", true);
						animator.SetBool ("WalkWall", false);
						animator.SetBool ("IdleWall", false);
					}
				} else {
					animator.SetBool ("WalkWall", false);
					animator.SetBool ("Walk", false);
					if (isNearWall == true){
						animator.SetBool ("IdleWall", true);
					} else if (isNearWall == false){
						animator.SetBool ("IdleWall", false);
					}
				}

            // NOTE: if input is moving the Player right and Player faces left, turn, and vice-versa
				if ((hvMove.x >0 && !FaceRight) || (hvMove.x <0 && FaceRight)){
					playerTurn();
				}
				
				//scaleByDepth:
				if (scaleByDepth == true){
					Transform sceneBottom= GameObject.FindWithTag("PlayerScaleBottom").transform;
					float distanceFromBottom = Mathf.Abs(sceneBottom.position.y - transform.position.y);
					//transform.localScale = startHeight * 4 * (1/distanceFromBottom);
					if (FaceRight){ 
						transform.localScale = startHeight * 4 * (scaleMultiplier/distanceFromBottom);					
					} else {
						Vector3 theScale = transform.localScale;
						theScale.x = startHeight.x * -4 * (scaleMultiplier/distanceFromBottom);
						theScale.y = startHeight.y * 4 * (scaleMultiplier/distanceFromBottom);
						theScale.z = startHeight.z * 4 * (scaleMultiplier/distanceFromBottom);
						transform.localScale = theScale;
					}
					Debug.Log("CurrentSize = " + transform.localScale);
				}
			}
      }

      private void playerTurn(){
            // NOTE: Switch player facing label
            FaceRight = !FaceRight;

            // NOTE: Multiply player's x local scale by -1.
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
      }
	  
	  void OnCollisionEnter2D(Collision2D other){
            if (other.gameObject.tag == "sceneWall"){
                  isNearWall = true;
			} else {
                  isNearWall = false;
            }
      }

     void OnCollisionExit2D(Collision2D other){
            if (other.gameObject.tag == "sceneWall"){
                  isNearWall = false;
			}
      }
	  
	  
}