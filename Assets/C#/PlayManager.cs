using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    public static PlayManager instance;//单例
    int _gold;
    public int GoldSum { get { return _gold; } set { if ((_gold + value) > 0) { _gold = value; } } }
    public int EnemySum;
    void Start()
    {
        instance = this;
        GoldSum = 0;
        EnemySum = 0;
    }
    void Update()
    {

    }
    public void PlayGame()
    {
        //GameObject.Find(string 对象名称)查找场景中对应的对象
        //Transform.Find(string 对象名称)查找当前对象下的对象

        UIManager.instance.UIPlayGameMenu.SetActive(false);//关闭游戏开始菜单
        UIManager.instance.UIPlayMenu.SetActive(true);//开启游戏计分板菜单
        UIManager.instance.UIPlayMenu.transform.Find("EnemySum").GetComponent<Text>().text = $"敌人数量: {EnemySum}";
        //通过UIManager上的UIPlayMenu的transform查找其子对象获取其组件并赋值以下同理
        UIManager.instance.UIPlayMenu.transform.Find("GoldSum").GetComponent<Text>().text = $"金币数量: {GoldSum}";
    }
}
