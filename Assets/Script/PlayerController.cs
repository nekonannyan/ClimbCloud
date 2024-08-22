using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigidbody2D;
    Animator animator;
    float jumpForce = 680.0f;
    float walkForce = 30.0f;
    float maxwalkForce = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        this.rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //�X�y�[�X�L�[�ŃW�����v������
        if (Input.GetKeyDown(KeyCode.Space) && this.rigidbody2D.velocity.y == 0)
        {
            this.rigidbody2D.AddForce(transform.up * this.jumpForce);
            animator.SetBool("jump", true);
        }
        else
        {
            animator.SetBool("jump", false);
        }

            //���E�̃L�[�ŉ��ړ�
            int key = 0;
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            key = 1;
            animator.SetBool("walk", true);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            key = -1;
            animator.SetBool("walk", true);
        }
        else
        {
            animator.SetBool("walk", false);
        }

        //�v���C���[�̑��x
        float speedx = Mathf.Abs(this.rigidbody2D.velocity.x);

        //�X�s�[�h����
        if (speedx < this.maxwalkForce)
        {
            this.rigidbody2D.AddForce(transform.right * key * this.walkForce);
        }

        //���������ɉ����Ĕ��]
        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }

        if (transform.position.y <= -6)
        {
            Debug.Log("�Q�[���I�[�o�[");
            SceneManager.LoadScene("Game");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Goal");
        SceneManager.LoadScene("Clear");
    }
}
