using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TMP_Text TextField;
    public int BounceCount;
    // Start is called before the first frame update
    void Start()
    {
        TextField = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        TextField.text = "Bounces: " + BounceCount;
    }
}
