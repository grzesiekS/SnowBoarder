using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    private string tagLevelSurface = "LevelSurface";
    private int levelOne = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == tagLevelSurface)
        {
            SceneManager.LoadScene(levelOne);
        }
    }
}
