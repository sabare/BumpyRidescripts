using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    int lane = 0;
    public float movementSpeed = 5f;

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
        MoveChar(lane);
    }

    void MoveChar(int lane){
        Debug.Log(lane);
        if(lane==0){

            rb.position= new Vector3(-2.5f, rb.position.y, rb.position.z);
        }
        if(lane==1){

            rb.position= new Vector3(2.5f, rb.position.y, rb.position.z);
        }
        if(lane==2){

            rb.position= new Vector3(7.5f, rb.position.y, rb.position.z);
        }
        if(lane==-1){

            rb.position= new Vector3(-7.5f, rb.position.y, rb.position.z);
        }
    }
}
