using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    private string tagPlayer = "Player";
    private int levelOne = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == tagPlayer)
        {
            SceneManager.LoadScene(levelOne);
        }
    }
}
