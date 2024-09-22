using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    public static PlayManager instance;//单例
    [SerializeField]
    GameObject go1;
    void Start()
    {
        instance = this;
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
        UIManager.instance.UIPlayMenu.transform.Find("EnemySum").GetComponent<Text>().text = $"敌人数量: {DataManager.instance.EnemySum}";
        //通过UIManager上的UIPlayMenu的transform查找其子对象获取其组件并赋值以下同理
        UIManager.instance.UIPlayMenu.transform.Find("GoldSum").GetComponent<Text>().text = $"金币数量: {DataManager.instance.GoldSum}";
        if(go1!=null) go1.SetActive(true);
    }
}
