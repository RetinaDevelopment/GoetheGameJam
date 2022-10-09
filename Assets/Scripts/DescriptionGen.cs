using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class DescriptionGen : MonoBehaviour
{

    public GameObject notificationBox;
    public int score;
    public GameObject gameOverScreen;
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
    public RawImage ChatPFP;
    public TextMeshProUGUI karma;
    public TextMeshProUGUI cakeDay;
    public Image bg;
    public Transform descPanel;
    public Transform chatPanel;
    public int day;
    public TextMeshProUGUI gameOverText;
    public GameObject loseScreen;
    public TextMeshProUGUI loseText;
    public float loadProfileTime = 0f;

    private void Start()
    {
        chatPanel.localPosition = new Vector2(-660, 160);
        descPanel.localPosition = new Vector2(680, 101);
        notificationBox.transform.localScale = Vector2.zero;
        gameOverScreen.transform.localScale = Vector2.zero;
        loseScreen.transform.localScale = Vector2.zero;
        StartNoti();
        //mainSprite = sprites[Random.Range(0, sprites.Length)];
        makeProfile();
    }
    private void Update()
    {
        ScoreUI.text = score.ToString();
        if(notifTimer > 0)
        {
            notifTimer -= Time.deltaTime;
        }
        /*else
        {
            closeNoti();
//            notificationBox.SetActive(false);
        }*/
    }

    public void makeDesc()
    {
        desc.text = mainClass.Description;
    }

    public void makeHobbies()
    {
        for (int i = 0; i < mainClass.hobbies.Length; i++)
        {
            hobbies.text += "-" + mainClass.hobbies[i] + "\n";
        }
    }

    public void makeProfile()
    {
        desc.text = "";
        hobbies.text = "";
        if(k<classes.Length)
        {
            mainClass = classes[k];
        }
        else
        {
            GameOver();
        }
        pfp.texture = mainClass.profile;
        chatTxT.text = mainClass.Chat;
        userName.text = mainClass.userName;
        makeDesc();
        makeHobbies();
        karma.text = mainClass.karma;
        cakeDay.text = mainClass.cakeDay;
        ChatPFP.texture = mainClass.ChatPFP;
        k++;
    }

    public void accept()
    {
        score += mainClass.score;
        if(mainClass.bg != null)
        {
            bg.sprite = mainClass.bg;
        }
        Invoke("makeProfile", loadProfileTime);
    }

    public void reject()
    {
        score -= mainClass.score;
        makeProfile();
    }

    public void GameOver()
    {
        if (score >= 400)
        {
            gameOverText.text = "Congratulations on completing day " + day.ToString() + " as a happy comunity";
            gameOverScreen.transform.LeanScale(Vector2.one, 0.8f).setEaseOutBounce();
            gameOverScreen.SetActive(true);
        }
        else
        {
            loseText.text = "You ended day " + day.ToString() + " as a sad comunity. Please try again";
            loseScreen.transform.LeanScale(Vector2.one, 0.8f).setEaseOutBounce();
            loseScreen.SetActive(true);
        }
    }
    public void closeNoti()
    {
        notificationBox.transform.LeanScale(Vector2.zero, 0.2f).setEaseInBack();
        descPanel.LeanMoveLocal(new Vector2(167, 101), 0.8f).setEaseOutBounce();
        chatPanel.LeanMoveLocal(new Vector2(-226, 160), 0.8f).setEaseOutBounce();
    }

    public void StartNoti()
    {
        if(k<=classes.Length)
        {
            notificationBox.SetActive(true);
            notificationBox.transform.LeanScale(Vector2.one, 0.7f).setEaseOutBounce();
            notifTimer = startNotifTimer;
        }
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
   





} 
 
 
 
 
 
 
 
 
 
