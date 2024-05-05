using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyCharacter1 : MonoBehaviour
{
    public int moveSpeed;

    private void Update()
    {
        transform.Translate(Time.deltaTime * moveSpeed * Vector2.right);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("RESPAWN"))
        {
            transform.position = new Vector3(-9.5f, -2.77f, 0);
        }
    }
}
