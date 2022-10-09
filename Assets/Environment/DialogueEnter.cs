using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEnter : MonoBehaviour
{
    public Dialogue dialogue;
    public void OnTriggerEnter2D(Collider2D other)
    {
        FindObjectOfType<NPCbaba1>().TriggerDialogue();
    }
}
