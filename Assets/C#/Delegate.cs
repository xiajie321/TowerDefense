using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour//学习委托的使用
{
    delegate void Aws();
    Aws aws;
    void Start()//方法是存放逻辑的容器,委托是存放方法的容器
    {
        aws = Run;
        aws += Run;
        aws += Run2;
        aws?.Invoke();//这里会先判断委托是否为空再决定执行Invoke
    }
    void Update()
    {
        
    }
    void Run()
    {
        Debug.Log("测试1");
    }
    void Run2()
    {
        Debug.Log("测试2");
    }
}
