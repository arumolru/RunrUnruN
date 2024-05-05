using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("PLAYER2"))
        {
            gameObject.SetActive(false);
        }
    }
}
