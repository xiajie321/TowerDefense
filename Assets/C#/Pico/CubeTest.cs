using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeTest : MonoBehaviour
{
    [SerializeField]
    Text Text;
    [SerializeField]
    Text text2;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void Run()
    {
        Text.text = "≤‚ ‘";
        text2.text = "≤‚ ‘2";
    }
}
