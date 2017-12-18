using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveP2 : MonoBehaviour
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

        if (Input.GetMouseButton(0))
        {
            pos.y += speed;

            pos.y = Mathf.Clamp(pos.y, -3.690012f, 3.700985f);
            transform.position = pos;
        }

        if (Input.GetMouseButton(1))
        {
            pos.y -= speed;

            pos.y = Mathf.Clamp(pos.y, -3.690012f, 3.700985f);
            transform.position = pos;

        }
    }
}