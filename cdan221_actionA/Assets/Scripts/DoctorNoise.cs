using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoctorNoise : MonoBehaviour
{
	public GameObject DoctorNoiseSource;
	
    // Start is called before the first frame update
    void Start()
    {
        DoctorNoiseSource.SetActive(false);
    }
	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Player"){
			DoctorNoiseSource.SetActive(true);
        }
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.gameObject.tag == "Player"){
			DoctorNoiseSource.SetActive(false);
        }
	}
}

