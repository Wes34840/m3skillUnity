using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEditor.FilePathAttribute;
using UnityEditor.Experimental.GraphView;

public class StartRunning : MonoBehaviour
{
    private TMP_Text TextField;

    private float nextActionTime = 0.0f;
    public float period = 1f;
    
    private int distance = 300;
    private int BUPSpeed = 5;
    private int TickCount = 0;
    private int TickResetCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        TextField = GetComponent<TMP_Text>();

    }
    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime += period;
            distance -= BUPSpeed;
            TextField.text = "I am currently " + distance + " meters from your exact location";
            Debug.Log(distance);
            TickCount++;
        }

        if (TickCount > 4)
        {
            BUPSpeed += 1;
            TickCount = 0;
            TickResetCount++;
        }
        if (TickResetCount > 2 && period > 0.5f)
        {
            period -= 0.1f;
            TickResetCount = 0;
        }
        


    }

    public void Run()
    {
        distance += 3;
        TextField.text = "I am currently " + distance + " meters from your exact location";

    }
}
