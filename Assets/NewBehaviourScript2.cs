using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviour3 : MonoBehaviour
{
    void Start()
    {
        SceneManager.LoadScene("code1", LoadSceneMode.Additive);
    }
}