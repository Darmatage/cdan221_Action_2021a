using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour{

//when your shake is activated by another script, comment out this update function:

       void Update(){

       }

       public IEnumerator ShakeMe(float durationTime, float magnitude){
              Vector3 originalPos = transform.localPosition;
              float elapsedTime = 0.0f;

              while (elapsedTime < durationTime){
                     float ShakeX = Random.Range(-1f, 1f) * magnitude;
                     float ShakeY = Random.Range(-1f, 1f) * magnitude;

                     transform.localPosition = new Vector3(ShakeX, ShakeY, originalPos.z);
                     elapsedTime += Time.deltaTime;
                     yield return null;
              }
              transform.localPosition = originalPos;
       }

}