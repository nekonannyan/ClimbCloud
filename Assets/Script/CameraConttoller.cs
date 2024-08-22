using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConttoller : MonoBehaviour
{
    //ゲームオブジェクトを追加
    GameObject player;

    private void Start()
    {
        //ゲームオブジェクトを設定
        this.player = GameObject.Find("cat");
    }

    private void Update()
    {
        //追従するように設定
        Vector3 playerPos = this.player.transform.position;
        //カメラの座標を変更させる
        transform.position = new Vector3(transform.position.x,playerPos.y,transform.position.z);

    }
}
