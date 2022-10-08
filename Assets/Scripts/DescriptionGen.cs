using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class DescriptionGen : MonoBehaviour
{
    public int score;
    public GameObject gameOverScreen;
    public float timer;
    public Slider timeSlider;
    public TextMeshProUGUI ScoreUI;
    public Texture[] sprites;
    public RawImage pfp;
    public TextMeshProUGUI desc;
    public TextMeshProUGUI hobbies;
    private SocialClass mainClass;
    public SocialClass[] classes;
    public string[] sentence;
    private void Start()
    {
        //mainSprite = sprites[Random.Range(0, sprites.Length)];
        makeProfile();
        timeSlider.maxValue = timer;
    }
    private void Update()
    {
        if(timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            GameOver();
            timer = 0;
        }
        timeSlider.value = timer;
        ScoreUI.text = score.ToString();
    }

    public void makeDesc()
    {
        desc.text = mainClass.Description;
    }

    public void makeHobbies()
    {
        for (int i = 0; i < mainClass.hobbies.Length; i++)
        {
            hobbies.text += mainClass.hobbies[i] += ", ";
        }
    }

    public void makeProfile()
    {
        desc.text = "";
        hobbies.text = "";
        pfp.texture = sprites[Random.Range(0, sprites.Length)];
        mainClass = classes[Random.Range(0, classes.Length)];

        makeDesc();
        makeHobbies();
    }

    public void accept()
    {
        score += mainClass.score;
        makeProfile();
    }

    public void reject()
    {
        score -= mainClass.score;
        makeProfile();
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
 }
