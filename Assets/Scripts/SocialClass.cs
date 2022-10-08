using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New User", menuName = "User")]
public class SocialClass : ScriptableObject
{
    public Texture profile;
    public Texture ChatPFP;
    public string userName;
    public int score;
    [TextArea(15, 20)]
    public string Description;
    [TextArea(7, 10)]
    public string Chat;
    public string[] hobbies;
}
