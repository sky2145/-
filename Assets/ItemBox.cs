using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public GameObject[] boxes;

    // どこからでも使えるようにする
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        // 初期化：全てのBoxをからにする
        for (int i = 0; i < boxes.Length; i++)
        {
            boxes[i].SetActive(false);
        }
        /*
        boxes[0].SetActive(false);
        boxes[1].SetActive(false);
        boxes[2].SetActive(false);
        boxes[3].SetActive(false);
        boxes[4].SetActive(false);
        */
    }

    public void SetItem(ItemManager.Item item)
    {
        int index = (int)item;
        boxes[index].SetActive(true);
    }

    public bool CanUseItem(ItemManager.Item item)
    {
        int index = (int)item;
        if (boxes[index].activeSelf == true)
        {
            return true;
        }
        return false;
    }

    public void UseItem(ItemManager.Item item)
    {
        int index = (int)item;
        boxes[index].SetActive(false);
    }

}