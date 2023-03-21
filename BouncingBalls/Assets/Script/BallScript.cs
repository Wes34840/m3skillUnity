using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    private GameObject textField;
    private TextScript textScript;

    private void Start()
    {
        textField = GameObject.FindWithTag("BounceCounter");
        textScript = textField.GetComponent<TextScript>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        textScript.BounceCount++;
    }
}
