using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YBlock : MonoBehaviour
{
    private bool turnMove = true;

    private void Update()
    {
        if(turnMove)
        {
            transform.Translate(Time.deltaTime * Vector2.down);
        }
        else
        {
            transform.Translate(Time.deltaTime * Vector2.up);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("TURNWALL"))
        {
            turnMove = !turnMove;
        }
    }
}
