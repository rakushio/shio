using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void StartGame() //新的游戏
    {
        Debug.Log("开始");
    }

    public void ContinueGame() //读取存档
    {
        Debug.Log("继续");
    }

    public void EndGame() //退出游戏
    {
        Debug.Log("结束");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
