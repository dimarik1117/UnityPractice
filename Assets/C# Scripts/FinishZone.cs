using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishZone : MonoBehaviour
{
    public GameObject panel;

    public AudioSource Audios;

    void Start()
    {
        Audios = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Audios.Play();
        GetComponent<SpriteRenderer>().sprite = null;
	panel.SetActive(true);
        Time.timeScale = 0f;
    }
}
