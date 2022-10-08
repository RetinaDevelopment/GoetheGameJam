using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New User", menuName = "User")]
public class SocialClass : ScriptableObject
{
    public string userName;
    public int score;
    [TextArea(15, 20)]
    public string Description;
    public string[] hobbies;
}
