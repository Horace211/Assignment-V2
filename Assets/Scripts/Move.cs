using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    float speed = 0.152f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.W))
        {
            pos.y += speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed;
        }


        pos.y = Mathf.Clamp(pos.y, -3.690012f, 3.700985f);
        transform.position = pos;
    }
}