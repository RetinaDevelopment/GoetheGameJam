using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCbaba1 : MonoBehaviour
{
    public Dialogue dialogue;
    public Animator animator;
    public GameObject portrait;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            portrait.SetActive(true);
            TriggerDialogue();
            animator.SetBool("Pula", true);
        }

    }
    public void TriggerDialogue()
    {
        DialogueManager.instance.StartDialogue(dialogue);
        gameObject.SetActive(false);
    }
}
