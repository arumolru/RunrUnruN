using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PLAYER"))
        {
            gameObject.SetActive(false);
        }
    }
}
