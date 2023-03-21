using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableParticle : MonoBehaviour
{

    public GameObject ParticleSystem1, ParticleSystem2;

    void Start()
    {
        ParticleSystem1.SetActive(false);
        ParticleSystem2.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ParticleSystem1.SetActive(true);
            ParticleSystem2.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            ParticleSystem1.SetActive(false);
            ParticleSystem2.SetActive(false);
        }
    }
}
