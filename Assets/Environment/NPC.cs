using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public Dialogue dialogue;
    public Animator animator;
    void Start()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            TriggerDialogue();
            animator.SetBool("Pula", true);
        }

        void TriggerDialogue()
        {
            DialogueManager.instance.StartDialogue(dialogue);
        }

    }
}
