using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutRef : MonoBehaviour
{
    int i;
    void Start()
    {
       
        Run(out i);//�ӷ����ڴ����Ĳ������뵽i��
        i = 1;
        Run2(ref i);
        Debug.Log(i);
        Debug.Log($"{i}");//��ֵ���
    }
    void Update()
    {
    }
    void Run(out int f)//outֻ�������ֵ
    {
        f = 1;
    }
    void Run2(ref int f)//ref�ɶ�д
    {
        Debug.Log(f);
        f = 2;
    }
}
