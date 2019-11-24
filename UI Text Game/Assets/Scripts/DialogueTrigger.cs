using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject startButton;
    public GameObject dialogueBox;
    public GameObject continueButton;
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        startButton.SetActive(false);
        dialogueBox.SetActive(true);
        continueButton.SetActive(true);
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
}
