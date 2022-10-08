using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class DescriptionGen : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI ScoreUI;
    public Sprite[] sprites;
    public Sprite mainSprite;
    public TextMeshProUGUI desc;
    public TextMeshProUGUI hobbies;
    private SocialClass mainClass;
    public SocialClass[] classes;
    public string[] sentence;

    private void Start()
    {
        //mainSprite = sprites[Random.Range(0, sprites.Length)];
        makeProfile();
    }
    private void Update()
    {
        ScoreUI.text = score.ToString();
    }

    public void makeDesc()
    {
        for (int i = 0; i < sentence.Length; i++)
        {
            desc.text += sentence[i] + " " + mainClass.keywords[i] + ". ";
        }
    }

    public void makeHobbies()
    {
        for (int i = 0; i < classes.Length; i++)
        {
            for (int j = 0; j < classes[i].hobbies.Length; j++)
            {
                hobbies.text += " " + classes[i].hobbies[j] + ",";
            }
        }
    }

    public void makeProfile()
    {
        desc.text = "";
        hobbies.text = "";
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

}
