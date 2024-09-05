using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapShow : MonoBehaviour
{
    [Header("UI")]
    // �̴ϸ� ǥ��
    [SerializeField] GameObject MiniMap;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            MiniMap.SetActive(true);
        }
        else
        {
            MiniMap.SetActive(false);
        }
    }
}
