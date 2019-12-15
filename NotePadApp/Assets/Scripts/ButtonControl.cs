using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{

    public GameObject Text;
    public AudioSource ClearSound;
    public GameObject optionsPanel;

    public void clearButton()                          // Function/Method for the Clear Button!
    {
        Text.GetComponent<InputField>().text = "";     // Overwrites the text component of input field into a blank string ...    
        ClearSound.Play();                             // Plays the Sound file when the Clear Button is pressed ... 
    }

    public void cancelButton()                         // Function/Method for the Cancel Button! 
    {
        optionsPanel.SetActive(false);                 // Turns off the options panel, with the save button, quit button, and the cancel button.
    }

    public void closeButton()                          // Function/Method for the Close Button!
    {
        optionsPanel.SetActive(true);                  // Turns on the options panel, with the save button, quit button, and the cancel button.
    }


    public void quitButton()                           // Function/Method for the Quit Button!
    {
        Application.Quit();                            // Quits and terminates the application ... 
    }

}