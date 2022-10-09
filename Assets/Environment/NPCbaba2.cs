using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCbaba2 : MonoBehaviour
{
    public Dialogue dialogue;
    public Animator animator;
    public Transform wall;
    public GameObject portrait;
    public GameObject lastPortrait;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            portrait.SetActive(true);
            lastPortrait.SetActive(false);
            TriggerDialogue();
            animator.SetBool("Pula", true);
        }

    }
    public void TriggerDialogue()
    {
        wall.Translate(40, 0, 0); 
        DialogueManager.instance.StartDialogue(dialogue);
        gameObject.SetActive(false);
    }
}
