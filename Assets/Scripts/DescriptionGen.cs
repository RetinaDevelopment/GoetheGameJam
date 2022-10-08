using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public class DescriptionGen : MonoBehaviour
{

    public GameObject notificationBox;
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
    public float notifTimer;
    public float startNotifTimer;
    public TextMeshProUGUI chatTxT;
    private int k = 0;
    public TextMeshProUGUI userName;


    private void Start()
    {
        StartNoti();
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
        if(notifTimer > 0)
        {
            notifTimer -= Time.deltaTime;
        }
        else
        {
            notificationBox.SetActive(false);
        }
    }

    public void makeDesc()
    {
        desc.text = mainClass.Description;
    }

    public void makeHobbies()
    {
        for (int i = 0; i < mainClass.hobbies.Length; i++)
        {
            hobbies.text += mainClass.hobbies[i] + ", ";
        }
    }

    public void makeProfile()
    {
        desc.text = "";
        hobbies.text = "";
        mainClass = classes[k];
        pfp.texture = mainClass.profile;
        chatTxT.text = mainClass.Chat;
        userName.text = mainClass.userName;
        makeDesc();
        makeHobbies();
        k++;
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
    
    public void StartNoti()
    {
        notificationBox.SetActive(true);
        notifTimer = startNotifTimer;
    }
   





} 
 
 
 
 
 
 
 
 
 
