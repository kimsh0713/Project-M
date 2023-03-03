using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelecteServerAndChannel : MonoBehaviour
{
    [SerializeField] Button[] Servers;
    [SerializeField] GameObject SelectChannelUI;

    private void Awake()
    {
        foreach (var _btns in Servers)
        {
            _btns.onClick.AddListener(() =>
            {
                if (SelectChannelUI.activeSelf == false)
                    SelectChannelUI.SetActive(true);
            });
        }
    }

    private void Update()
    {
        if(SelectChannelUI.activeSelf)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                SelectChannelUI.SetActive(false);
            }
        }
    }
}
