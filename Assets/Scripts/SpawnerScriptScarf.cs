using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScriptScarf : MonoBehaviour
{
    public GameObject objectToSpawn;

    // Start is called before the first frame update
    void start()
    {
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
