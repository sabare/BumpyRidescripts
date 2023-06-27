using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform tf;
    Vector3 offset;
    void Start()
    {
        offset = transform.position - tf.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, tf.position.z + offset.z);
    }
}
