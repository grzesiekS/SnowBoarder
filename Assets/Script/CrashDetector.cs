using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;

    private string tagLevelSurface = "LevelSurface";
    private int levelOne = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == tagLevelSurface)
        {
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(levelOne);
    }
}
