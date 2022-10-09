using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialButton : MonoBehaviour
{
    public float timer;
    public float startTimer;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        timer = startTimer;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            button.SetActive(true);
        }
    }
    public void ClickButton()
    {
        FindObjectOfType<AudioManager>().Play("click");
    }
}
