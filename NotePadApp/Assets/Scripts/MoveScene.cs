using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveScene : MonoBehaviour
{
    public GameObject Canvas;

    void Start()
    {
        StartCoroutine( MoveToNextScene());             // Function call in C# ... 
    }

    IEnumerator MoveToNextScene()
    {
        yield return new WaitForSeconds(2);             // Wait for 3 seconds ... (my animation takes only 1 second for 60 frames) ... 
        Canvas.SetActive(false);                        // Disable Canvas to show beautiful Skybox ... 
        yield return new WaitForSeconds(2);             // Wait for 2 seconds ... 
        SceneManager.LoadScene(1);                      // Scene 0 is the load screen ... Scene 1 is the Notepad Scene itself ... 
    }

}
