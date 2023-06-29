using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    int lane = 0;
    //public float movementSpeed = 10f;
    int oldlane = 0;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();   

    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown("right")){

            lane = Mathf.Min(lane+1, 2);
        }
        if(Input.GetKeyDown("left")){

            lane = Mathf.Max(lane-1, -1);
        }
        
    }

    void FixedUpdate(){

        if(lane!=oldlane)
            MoveChar(lane);
    }

    void MoveChar(int lane){
        if(lane==0){
            rb.MovePosition(new Vector3(-1.5f, rb.position.y, rb.position.z));
            // rb.position= new Vector3(-1.5f, rb.position.y, rb.position.z);
            oldlane = lane;
        }
        if(lane==1){

            // rb.position= new Vector3(1.5f, rb.position.y, rb.position.z);
            rb.MovePosition(new Vector3(1.5f, rb.position.y, rb.position.z));
            oldlane = lane;

        }
        if(lane==2){

            // rb.position= new Vector3(4.5f, rb.position.y, rb.position.z);
            rb.MovePosition(new Vector3(4.5f, rb.position.y, rb.position.z));
            oldlane = lane;
        }
        if(lane==-1){

            // rb.position= new Vector3(-4.5f, rb.position.y, rb.position.z);
            rb.MovePosition(new Vector3(-4.5f, rb.position.y, rb.position.z));
            oldlane = lane;
        }
    }
}
