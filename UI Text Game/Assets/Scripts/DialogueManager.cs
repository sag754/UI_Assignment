using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                       //allows me to use the Text class

public class DialogueManager : MonoBehaviour
{ 

    public Text nameText;                                   //holds the string data for the NPC name
    public Text dialogueText;                               //holds the string data for the dialogue text

    public Animator animator;                               //holds the animation data for dialogue box to come in and out

    private Queue<string> sentences;                        //data type that allows to store my sentences in a que

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();                    //loads new sentences from the end of the que to conintinue dialogue
    }

    public void StartDialogue(Dialogue dialogue)            //when called, brings up the dialogue box
    {
        animator.SetBool("IsOpen", true);                   //if isOpen is true, open the dialogue box

        nameText.text = dialogue.name;                      //displays NPC name on the dialogue box

        sentences.Clear();                                  //clears the previous dialogue text in the dialogue box

        foreach (string sentence in dialogue.sentences)     //go through all of the strings in our sentences array
        {
            sentences.Enqueue(sentence);                    //que up the next sentence
        }

        DisplayNextSentence();                              //calls displays the next sentence in the dialogue que
    }

    public void DisplayNextSentence()                       //displays the next piece of dialogue in the que
    {
        if (sentences.Count == 0)                           //checks to see if there is no further dialogue in the que
        {
            EndDialogue();                                  //pass to EndDialogue to close dialogue box
            return;                                         //returns out of the function
        }

        string sentence = sentences.Dequeue();              //checks to see if there are still sentences left in the que
        dialogueText.text = sentence;                       //display dialogue text in dialogue box
    }
    
    void EndDialogue()                                      //passes end dialogue
    {
        animator.SetBool("IsOpen", false);                  //if IsOpen is false, close the dialogue box
    }
}