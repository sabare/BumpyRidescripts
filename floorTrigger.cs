using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorTrigger : MonoBehaviour
{
    
    public tileManager tileManager;
    // Update is called once per frame
    private void OnTriggerEnter(Collider other) {
        
        tileManager.spawnTile(Random.Range(1, 5));
        tileManager.deleteTile();  
    }
}
