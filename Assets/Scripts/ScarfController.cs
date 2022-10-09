using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarfController : MonoBehaviour
{
    public GameObject diaBox2;

    // Start is called before the first frame update
    void start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameObject.SetActive(false);
            diaBox2.SetActive(true);
        }
    }
}
