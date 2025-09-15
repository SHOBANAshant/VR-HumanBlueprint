using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Correct namespace for SceneManager

public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void GoToSceneTwo(){
        SceneManager.LoadScene("new");
    }
}
