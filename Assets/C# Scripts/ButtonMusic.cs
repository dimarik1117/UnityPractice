using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMusic : MonoBehaviour
{
    public Sprite musicOn;
    public Sprite musicOff;

    public Image MusicButton;
    public bool isOn;
    public AudioSource ad;


    void Start()
    {
        isOn = true;

    }

    void Update()
    {
        if (PlayerPrefs.GetInt("music") == 0)
        {
            MusicButton.GetComponent<Image>().sprite = musicOn;
            ad.enabled = true;
            isOn = true;
        }
        else if (PlayerPrefs.GetInt("music") == 1)
        {
            MusicButton.GetComponent<Image>().sprite = musicOff;
            ad.enabled = false;
            isOn = false;
        }
    }

    public void offMusic()
    {
        if (!isOn)
        {
            PlayerPrefs.SetInt("music", 0);
        }
        else if (isOn)
        {
            PlayerPrefs.SetInt("music", 1);
        }
    }
}
