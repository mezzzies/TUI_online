using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home_State : MonoBehaviour
{
    Transform temp_transform;
    void Start()
    {
        float x;
        float y;
        float z;

        temp_transform = GetComponent<Transform>();

        x = temp_transform.position.x;
        y = temp_transform.position.y;
        z = temp_transform.position.z;

        if(x != 0.0f && y != 1.1f && z != -0.7f)
        {
            temp_transform.transform.position = new Vector3(0.0f, 1.1f , -0.7f);
        }
    }
    void Update()
    {

    }
}
