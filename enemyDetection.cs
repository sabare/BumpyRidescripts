using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDetection : MonoBehaviour
{
    // Start is called before the first frame update
    public ScoreUpdate scrupdt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision) {
        
        Debug.Log("nog");
        if (collision.gameObject.tag == "TrafficCone")
        {
            Debug.Log("Sa");
            scrupdt.life = Mathf.Max(0, scrupdt.life-1);
        }
    }
}
