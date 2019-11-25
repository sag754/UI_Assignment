using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public GameObject startButton;                                    //shows in inspector in dialogue script as startButton to assign a  gameobject to startButton
    public GameObject dialogueBox;                                    //shows in inspector in dialogue script as dialogueBox to assign a gameobject to dialogueBox
    public GameObject continueButton;                                 //shows in inspector in dialogue script as continueButton to assign a gameobject to continueButton

    public Dialogue dialogue;                                         //shows in Inspector the dialogue script that enables us to put in the name,
                                                                      //number of sentences, and the dialogue text

    public void TriggerDialogue()                                     //trigger for the dialogue
    {
        startButton.SetActive(false);                                  //toggles startbutton to inactive [invisible]
        dialogueBox.SetActive(true);                                   //toggles dialogueBox to active [visible]
        continueButton.SetActive(true);                                //toggles continue button to active [visible]
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);   //calls on DialogueManager to begin the dialogue in the scene, bringing up the dialogue box
    }
}
