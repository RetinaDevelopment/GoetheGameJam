
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene22: MonoBehaviour
{
    public void changeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}

