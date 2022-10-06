using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    //タイトルロゴの移動速度
    [SerializeField]
    private float moveTitlelogoSpeed = 1;
    //タイトルロゴの停止位置X
    [SerializeField]
    private float stopTitlelogoPosX = 0.0f;
    //タイトルロゴの停止位置Y
    [SerializeField]
    private float stopTitlelogoPosY = 100.0f;
    //

    //タイトルロゴ画像
    private GameObject titlelogo;
    //press any key画像
    private GameObject pnk;

    void Start()
    {
        //各変数からアクセス
        titlelogo = GameObject.Find("Titlelogo");
        pnk = GameObject.Find("press any key");
    }

    void Update()
    {
        //タイトルロゴのX座標がが停止位置Xに来ていないなら
        if(titlelogo.GetComponent<Transform>().position.x != stopTitlelogoPosX)
        {
            titlelogo.GetComponent<Transform>().position.x
        }
    }
}
