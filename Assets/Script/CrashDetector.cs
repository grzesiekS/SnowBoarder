using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    private string tagLevelSurface = "LevelSurface";

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == tagLevelSurface)
        {
            Debug.Log("You crashed your head");
        }
    }
}
