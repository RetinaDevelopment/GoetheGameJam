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
    public int neededScore;
    public TextMeshProUGUI postsText;
    public TextMeshProUGUI fakeConsole;
    public Transform tutorialBoxNoti;
    public Transform tutorialBoxSwitch;
    public Transform tutorialAcceptBox;
    public TextMeshProUGUI upvotesText;
    public TextMeshProUGUI postName;

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
        if(tutorialBoxNoti != null)
        {
            tutorialBoxNoti.LeanMoveLocal(new Vector2(244.2f, 138.1f), 0.8f).setEaseOutBack();
        }
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
        if(postsText != null)
        {
            if (mainClass.Post != null)
            {
                postsText.text = mainClass.Post;
            }
        }
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
        //fakeConsole.text += "making profile ";
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
        //fakeConsole.text += "making description ";
        makeHobbies();
        //fakeConsole.text += "making hobbies ";
        karma.text = mainClass.karma;
        //fakeConsole.text += "making karma " + mainClass.karma;
        cakeDay.text = mainClass.cakeDay;
        //fakeConsole.text += "making cakeDay " + mainClass.cakeDay;
        ChatPFP.texture = mainClass.ChatPFP;
        if(mainClass.Post != "")
        {
            upvotesText.text = mainClass.upvotes;
            postName.text = mainClass.userName;
        }
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
        FindObjectOfType<AudioManager>().Play("click");
    }

    public void reject()
    {
        score -= mainClass.score;
        makeProfile();
        FindObjectOfType<AudioManager>().Play("click");
    }

    public void GameOver()
    {
        if (score >= neededScore)
        {
            gameOverText.text = "Congratulations on completing day " + day.ToString() + " as a happy comunity";
            gameOverScreen.transform.LeanScale(Vector2.one, 0.8f).setEaseOutBounce();
            gameOverScreen.SetActive(true);
        }
        else
        {
            loseText.text = "You ended day " + day.ToString() + " as a sad comunity because you accepted/rejected the wrong users. Please try again";
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
    public void nextDay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
   
    public void Click()
    {
        FindObjectOfType<AudioManager>().Play("click");
    }

    public void postClick()
    {
        desc.gameObject.SetActive(false);
        hobbies.gameObject.SetActive(false);
    }

    public void descClick()
    {
        hobbies.gameObject.SetActive(false);
        postsText.gameObject.SetActive(false);
    }
    public void hobbyClick()
    {
        postsText.gameObject.SetActive(false);
        desc.gameObject.SetActive(false);
    }
    public void tutSwitch()
    {
        if (tutorialBoxSwitch != null)
            tutorialBoxSwitch.LeanMoveLocal(new Vector2(175f, 145.3f), 0.8f).setEaseOutBack();
        Debug.Log("mergi drc odata");
    }

    public void tutAccept()
    {
        if (tutorialAcceptBox != null)
            tutorialAcceptBox.LeanMoveLocal(new Vector2(149, -188), 0.8f).setEaseOutBack();
    }
    public void quitApp()
    {
        SceneManager.LoadScene(0);
    }
} 
 
 
 
 
 
 
 
 
 
