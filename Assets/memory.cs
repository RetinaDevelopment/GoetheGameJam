using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class memory : MonoBehaviour
{
    public bool mem;
    public void changeMem(bool newMem)
    {
        mem = newMem;
        Debug.Log(mem);
    }
}