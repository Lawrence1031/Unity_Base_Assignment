using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoStage1Trigger : MonoBehaviour
{
    public GameObject GoNextScene;

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))
        {
            StartCoroutine(GoStage1());
        }
    }

    IEnumerator GoStage1()
    {
        GoNextScene.SetActive(true);

        // ���� �ð� ���� ���
        yield return new WaitForSeconds(1f);

        // ���� ���������� �̵�
        SceneManager.LoadScene("03_Stage1Scene");
    }
}
