using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConttoller : MonoBehaviour
{
    //�Q�[���I�u�W�F�N�g��ǉ�
    GameObject player;

    private void Start()
    {
        //�Q�[���I�u�W�F�N�g��ݒ�
        this.player = GameObject.Find("cat");
    }

    private void Update()
    {
        //�Ǐ]����悤�ɐݒ�
        Vector3 playerPos = this.player.transform.position;
        //�J�����̍��W��ύX������
        transform.position = new Vector3(transform.position.x,playerPos.y,transform.position.z);

    }
}
