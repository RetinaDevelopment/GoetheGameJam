using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public static DialogueManager instance;
    public Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        sentences = new Queue<string>();
    }


    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("starting convo with");

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }


    void EndDialogue()
    {
        Debug.Log("End Conversation");
        anim.SetBool("Pula", false);    
    }
}
