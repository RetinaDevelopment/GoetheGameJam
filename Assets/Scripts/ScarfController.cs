using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScarfController : MonoBehaviour
{
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void start()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
