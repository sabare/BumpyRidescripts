using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] tilePrefabs;
    private List<GameObject> activeTiles = new List<GameObject>();
    void Start()
    {
        Instantiate(tilePrefabs[0],Vector3.zero , Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnTile(int tileIndex){

        GameObject go = Instantiate(tilePrefabs[tileIndex], Vector3.zero, Quaternion.identity);
        activeTiles.Add(go);
    }

    private void deleteTile(){

        Destroy(activeTiles[0]);
        activeTiles.RemoveAt(0);
    }
}
