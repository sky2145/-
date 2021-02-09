using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ref1 : MonoBehaviour
{
    public GameObject opneObj;

    // 連続入力の実装
    enum Direction
    {
        Left = 0,
        Right = 1,
    }
    // Playerの入力
    List<Direction> userInputs = new List<Direction>();
    // 正解の連続入力：右, 左, 左, 右, 右,
    Direction[] correctAnswer = {
        Direction.Right,
        Direction.Left,
        Direction.Left,
        Direction.Right,
        Direction.Right,
    };

    // 入力
    public void OnButton(int type)
    {
        // todo:ユーザーの入力を代入
        if (type == 0)
        {
            userInputs.Add(Direction.Left);
        }
        if (type == 1)
        {
            userInputs.Add(Direction.Right);
        }
        Debug.Log(type);
        // 5回入力されたらチェックする
        if (userInputs.Count == 5)
        {
            if (IsAllClear() == true)
            {
                Clear();
            }
            else
            {
                // 不一致の場合の実装 Reset
                ResetInput();
            }
        }
    }
    void ResetInput()
    {
        userInputs.Clear();
        Debug.Log("リセット");
    }

    // 一致しているかチェック
    bool IsAllClear()
    {
        for (int i=0; i< userInputs.Count; i++)
        {
            if (userInputs[i] != correctAnswer[i])
            {
                return false;
            }
        }
        return true;
    }

    void Clear()
    {
        Debug.Log("クリア");
        opneObj.SetActive(true);
    }
}