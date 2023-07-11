using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishZone : MonoBehaviour
{
    public GameObject panel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<SpriteRenderer>().sprite = null;
	panel.SetActive(true);
        Time.timeScale = 0f;
    }
}
