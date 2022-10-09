using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    public static DialogueManager instance;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Animator anim;
    public GameObject dawg;
    public GameObject canvas;
    public GameObject suicidCam;
    public GameObject mainCam;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        sentences = new Queue<string>();
    }


    public void StartDialogue(Dialogue dialogue)
    {
        canvas.SetActive(true);

        nameText.text = dialogue.name;

        sentences.Clear();

        dawg.GetComponent<PlayerMovement>().speed = 0f;
        dawg.GetComponent<PlayerMovement>().jumpingPower = 0f;

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
        dialogueText.text = sentence;
    }


    void EndDialogue()
    {
        if(suicidCam.activeSelf)
        {
            suicidCam.SetActive(false);
            mainCam.SetActive(true);
        }
        anim.SetBool("Pula", false);
        dawg.GetComponent<PlayerMovement>().speed = 10f;
        dawg.GetComponent<PlayerMovement>().jumpingPower = 15f;
        canvas.SetActive(false);
    }
}
