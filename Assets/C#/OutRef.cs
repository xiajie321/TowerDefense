using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutRef : MonoBehaviour
{
    int i;
    void Start()
    {
       
        Run(out i);//从方法内传出的参数传入到i中
        i = 1;
        Run2(ref i);
        Debug.Log(i);
        Debug.Log($"{i}");//将值输出
    }
    void Update()
    {
    }
    void Run(out int f)//out只向外输出值
    {
        f = 1;
    }
    void Run2(ref int f)//ref可读写
    {
        Debug.Log(f);
        f = 2;
    }
}
