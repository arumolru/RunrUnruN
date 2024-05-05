using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class XBlock : MonoBehaviour
{
    private bool moveDirection = true;

    private void Update()
    {
        if(moveDirection)
        {
            transform.Translate(Time.deltaTime * Vector2.right);
        }
        else
        {
            transform.Translate(Time.deltaTime * Vector2.left);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("TURNWALL"))
        {
            moveDirection = !moveDirection;
        }
    }
}
