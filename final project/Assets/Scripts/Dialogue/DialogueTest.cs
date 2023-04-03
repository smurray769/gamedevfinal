using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;
using UnityEngine.SceneManagement;

public class DialogueTest : MonoBehaviour
{
    public DialogManager DialogManager;

    void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Hey, Captain. I have something you should take a look at./click/", "Petra"));
        dialogTexts.Add(new DialogData("... What do you mean who? You. You're the captain.", "Petra"));
        dialogTexts.Add(new DialogData("Who am I? Okay, stop joking around. We have a serious issue at hand.", "Petra"));
        dialogTexts.Add(new DialogData("I detected some suspicious behavior on the ship's network. I have a feeling Sapphire Industries used HALO as a backdoor into our system.", "Petra"));
        dialogTexts.Add(new DialogData("Luckily, our cyberdefense system has a GUI that should make it pretty easy to fix.", "Petra"));
        dialogTexts.Add(new DialogData("'How's that supposed to work?' What a silly question.", "Petra"));
        dialogTexts.Add(new DialogData("You're going to use the WASD keys to move around the screen. Click the mouse or press E to shoot.", "Petra"));
        dialogTexts.Add(new DialogData("Oh, and the SPACE button will let you jump.", "Petra"));
        dialogTexts.Add(new DialogData("Alright, this framing mechanism has gone on long enough. Just get started playing the game.", "Petra"));

        var Text1 = new DialogData("Are you ready?");
        Text1.SelectList.Add("Continue", "Uh, sure. I guess.");
        Text1.SelectList.Add("Continue", "I'll do my best?");
        Text1.SelectList.Add("Refuse", "I want to go back to the main menu, actually.");

        Text1.Callback = () => CheckAnswer();
        dialogTexts.Add(Text1);

        DialogManager.Show(dialogTexts);
    }

    private void CheckAnswer()
    {
        if(DialogManager.Result == "Continue")
        {
            SceneManager.LoadScene("StartScene");
        }
        else if (DialogManager.Result == "Refuse")
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
