using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class memory : MonoBehaviour
{
    public bool mem;
    public void changeMem(bool newMem)
    {
        mem = newMem;
        Debug.Log(mem);
    }
        public void Scene2()
        {
        SceneManager.LoadScene("Scene2");
        }
}
    