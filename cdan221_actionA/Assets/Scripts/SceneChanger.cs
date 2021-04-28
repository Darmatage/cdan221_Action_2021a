using System.Collections;  
using System.Collections.Generic;  
using UnityEngine;  
using UnityEngine.SceneManagement;  


public class SceneChanger: MonoBehaviour {  

	public string NextLevel = "MainMenu";
	
    public void Scene1() {  
        SceneManager.LoadScene("NextLevel");  
    }  
    public void Scene2() {  
        SceneManager.LoadScene("Scene2");  
    }  
    public void Scene3() {  
        SceneManager.LoadScene("Scene3");  
    }  
}   