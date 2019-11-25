using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]              //allows this to show up in the inspector so we can edit it
public class Dialogue
{
    public string name;            //displays in editor box to input NPC name
    [TextArea(3, 10)]              //changes the textArea box size to make it easier to type sentences
    public string[] sentences;     //displays in editor the text box to input text and store sentences in an array
}