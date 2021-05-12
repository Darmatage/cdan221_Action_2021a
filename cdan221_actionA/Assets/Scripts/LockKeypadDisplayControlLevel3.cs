using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockKeypadDisplayControlLevel3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMesh>().text = LockKeypadClickControlLevel3.playerCode;
    }
}
