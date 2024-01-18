using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class _ : MonoBehaviour
{
     public float fadeDuration = 1f;
     bool m_IsPlayerAtExit
     public GameObject player;

     public CanvasGroup

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            m_IsPlayerAtExit = true;
        }        
    }
}
