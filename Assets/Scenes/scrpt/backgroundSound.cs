using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundSound : MonoBehaviour
{
   private static backgroundSound BackgrooundSound;
    // Start is called before the first frame update
    private void Awake()
    {
        if(BackgrooundSound == null)
        {
            BackgrooundSound = this;
            DontDestroyOnLoad(BackgrooundSound);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

