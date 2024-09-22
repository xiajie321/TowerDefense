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
        if (transforms == null) return; //当位置信息的列表为空情况下就不执行下面的语句
        if(index>=transforms.Count) index = 0;
        transform.LookAt(transforms[index].position);//面向目标位置
        transform.position = Vector3.Lerp(transform.position, transforms[index].position, Time.deltaTime * speed);//移动至当前锁定的位置中去
        if (Vector3.Distance(transform.position, transforms[index].position) <= 0.1f)//判断两者之间的一个距离如果说小于0.1的时候就切换下一个移动的位置
        {
            index += 1;//切换下一个坐标点
        }
    }
}
