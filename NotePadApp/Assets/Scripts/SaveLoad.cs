using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveLoad : MonoBehaviour
{

    public string Text;
    public GameObject userNote;
    public GameObject placeHolder;
    public GameObject saveAnim;


    void Start()
    {
        Text = PlayerPrefs.GetString("NoteContents");           // PlayerPrefs.Get --> is for loading file contents
        placeHolder.GetComponent<InputField>().text = Text;     // The Place Holder text is set to the loaded file contents! :D 
    }

    public void SaveFile()
    {
        Text = userNote.GetComponent<Text>().text;              // String stores all the text the user has written ... 
        PlayerPrefs.SetString("NoteContents", Text);            // Player Prefs is a built in function that saves the string contents to a System File 
                                                                // PlayerPrefs.Set --> is for saving file contents  
        StartCoroutine( SaveTextRoll() );                       // C# function call ... 
    }

    // We used a Coroutine, because we need to control time, like Doctor Strange ... 
    IEnumerator SaveTextRoll()
    {
        saveAnim.GetComponent<Animator>().Play("SavedAnim");    // Sets and Plays animation from State 1
        yield return new WaitForSeconds(1);                     // Waiting for animation to play out ... 
        saveAnim.GetComponent<Animator>().Play("New State");    // Sets Animator to an empty or null state.
    }

    
}
