using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NMove : MonoBehaviour
{
    public List<Transform> transforms;
    int index;
    [SerializeField]
    float speed = 1;
    void Start()
    {
    }
    void Update()
    {
        Run();
    }
    void Run()
    {
        if (transforms == null) return; //��λ����Ϣ���б�Ϊ������¾Ͳ�ִ����������
        if(index>=transforms.Count) index = 0;
        transform.LookAt(transforms[index].position);//����Ŀ��λ��
        transform.position = Vector3.Lerp(transform.position, transforms[index].position, Time.deltaTime * speed);//�ƶ�����ǰ������λ����ȥ
        if (Vector3.Distance(transform.position, transforms[index].position) <= 0.1f)//�ж�����֮���һ���������˵С��0.1��ʱ����л���һ���ƶ���λ��
        {
            index += 1;//�л���һ�������
        }
    }
}
