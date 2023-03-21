using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{

    private StartRunning running;
    private void Start()
    {
        running = FindObjectOfType<StartRunning>(); 
    }
    public void OnClick()
    {
        running.Run();
    }
}
