using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    float moveSpeed = 0.5f;

    private void Update()
    {
        transform.Translate(Time.deltaTime * moveSpeed * Vector3.left);
    }
}
