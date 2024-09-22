using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayManager : MonoBehaviour
{
    public static PlayManager instance;//单例
    bool isPlay; //判断游戏是否启动
    [SerializeField]
    GameObject go1;
    Camera mainCamera;
    Ray ray;
    RaycastHit hit;
    void Start()
    {
        instance = this;
        mainCamera = Camera.main;
        
    }
    void Update()
    {
        if (!isPlay) return;
        ray = mainCamera.ScreenPointToRay(Input.mousePosition);//从屏幕向鼠标的位置发射一个世界空间的射线
        if (Physics.Raycast(ray,out hit) && Input.GetMouseButtonDown(0))//Physics.Raycast(ray,out hit)如果射线检测到物体他的返回值会是true并且将检测到的物体传到hit参数里
        {
            if (hit.transform.tag.Equals("FYT"))//判断标签是否为FYT是的话就执行下面的方法
            {
                UIManager.instance.UISelect.transform.position = mainCamera.WorldToScreenPoint(hit.transform.position);//将世界坐标转为屏幕坐标后传给UI
                UIManager.instance.UISelect.SetActive(true);
            }
        }
        else if(Input.GetMouseButtonDown(0))
        {
            UIManager.instance.UISelect.SetActive(false);
        }
    }
    public void PlayGame()
    {
        //GameObject.Find(string 对象名称)查找场景中对应的对象
        //Transform.Find(string 对象名称)查找当前对象下的对象
        isPlay = true;
        UIManager.instance.UIPlayGameMenu.SetActive(false);//关闭游戏开始菜单
        UIManager.instance.UIPlayMenu.SetActive(true);//开启游戏计分板菜单
        UIManager.instance.UIPlayMenu.transform.Find("EnemySum").GetComponent<Text>().text = $"敌人数量: {DataManager.instance.EnemySum}";
        //通过UIManager上的UIPlayMenu的transform查找其子对象获取其组件并赋值以下同理
        UIManager.instance.UIPlayMenu.transform.Find("GoldSum").GetComponent<Text>().text = $"金币数量: {DataManager.instance.GoldSum}";
        if(go1!=null) go1.SetActive(true);

    }
}
