using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New User", menuName = "User")]
public class SocialClass : ScriptableObject
{
    public Texture profile;
    public Texture ChatPFP;
    public Sprite bg;
    public string userName;
    public int score;
    public string karma;
    public string cakeDay;
    [TextArea(15, 20)]
    public string Description;
    [TextArea(7, 10)]
    public string Chat;
    [TextArea(4, 7)]
    public string Post;
    public string[] hobbies;
}
