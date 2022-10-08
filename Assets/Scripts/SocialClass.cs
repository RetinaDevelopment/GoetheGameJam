using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Class", menuName = "Class")]
public class SocialClass : ScriptableObject
{
    public int id;
    public string CName;
    public int score;
    public string[] keywords;
    public string[] hobbies;
}
