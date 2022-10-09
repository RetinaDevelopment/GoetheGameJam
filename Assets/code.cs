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
    public void loadscene()
    {
        if (CodeInput.text=="1212")
        SceneManager.LoadScene("secret1", LoadSceneMode.Single);
        if (CodeInput.text=="7244")
            SceneManager.LoadScene("secret2", LoadSceneMode.Single);

    }
}