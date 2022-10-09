using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muzicaschimbare : MonoBehaviour
{
    AudioSource musicSource;
    public AudioClip newClip;

    private void Awake()
    {
        GameObject[] audio = GameObject.FindGameObjectsWithTag("GameMusic");
        if (audio.Length > 0)
        {
            if (newClip != null)
            {
                audio[0].GetComponent<AudioSource>().clip = newClip;
                audio[0].GetComponent<AudioSource>().Play();

            }
            else
            {
                Debug.Log("Nu exista Clip Muzical de schimbat");
            }

        }
        else
        {
            Debug.Log("Clipul Nu este selectat pt scena asta, se va continua cu muzica anterioara");
        }
    }
}
