using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro; 

public class code : MonoBehaviour
{
    public TMP_InputField CodeInput;
    public string SceneName1;
    public string SceneName2; 
    public string condition1;
    public string condition2;
    public void loadscene()
    {
        if (CodeInput.text==condition1)
        SceneManager.LoadScene(SceneName1, LoadSceneMode.Single);
        if (CodeInput.text==condition2)
            SceneManager.LoadScene(SceneName2, LoadSceneMode.Single);

    }
}