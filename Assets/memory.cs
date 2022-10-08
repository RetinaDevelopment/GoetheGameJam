using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class memory : MonoBehaviour
{
    public static int mem = 0;
    public static int NrScena = 1;
    private Scene Scene; 
    private void Start ()
    {
        Scene = SceneManager.GetActiveScene(); 
    }
    public void changeMem(int newMem)
    {
            mem=mem+newMem;
     
        Debug.Log(mem);
    }
    public void SceneChange()
    {
        SceneManager.LoadScene(Scene.buildIndex + 1) ;
    }
}