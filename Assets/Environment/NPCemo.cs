using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCemo : MonoBehaviour
{
    public Dialogue dialogue;
    public Animator animator;
    public Transform wall;
    public GameObject suicideCam;
    public GameObject initialCam;
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
        suicideCam.SetActive(true);
        initialCam.SetActive(false);
        DialogueManager.instance.StartDialogue(dialogue);
        wall.Translate(40, 0, 0);
        gameObject.SetActive(false);
    }
}
