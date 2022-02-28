using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    private string tagPlayer = "Player";

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == tagPlayer)
        {
            Debug.Log("You finished");
        }
    }
}
