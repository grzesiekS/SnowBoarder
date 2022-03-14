using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect;

    private string tagPlayer = "Player";
    private int levelOne = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == tagPlayer)
        {
            finishEffect.Play();
            Invoke("ReloadScene", loadDelay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(levelOne);
    }
}
