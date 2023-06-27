using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorTrigger : MonoBehaviour
{
    

    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        
        Debug.Log("came");  
    }
}
