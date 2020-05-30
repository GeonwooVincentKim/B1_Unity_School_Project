using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");

        int level = 5;
        float strength = 15.5f;
        string playerName = "나판사";
        bool isFullLevel = false;

        Debug.Log("용사 이름");
        Debug.Log(playerName);
        Debug.Log("용사 레벨");
        Debug.Log(level);
        Debug.Log("용사 힘");
        Debug.Log(strength);
        Debug.Log("용사 만랩");
        Debug.Log(isFullLevel);

        string[] monsters = { "슬라임", "사막뱀", "악마" };

        //Debug.Log("맵 보스");
        //Debug.Log(monsters[0]);
        //Debug.Log(monsters[1]);
        //Debug.Log(monsters[2]);

        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        //Debug.Log("몬스터 레벨");
        //Debug.Log(monsterLevel[0]);
        //Debug.Log(monsterLevel[1]);
        //Debug.Log(monsterLevel[2]);

        List<string> items = new List<string>();
        items.Add("생명물약 30");
        items.Add("마나물약 30");

        Debug.Log("아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        items.RemoveAt(0);

        Debug.Log("가지고 있는 아이템");
        Debug.Log(items[0]);
        //Debug.Log(items[1]);

        int exp = 1500;
        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.5f;

        Debug.Log("경험치");
        Debug.Log(exp);
        Debug.Log("용사레벨");
        Debug.Log(level);
        Debug.Log("용사 힘");
        Debug.Log(strength);

        string title = "전설의";
        Debug.Log("용사 이름");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        // 용사 만렙 여부 결정
        isFullLevel = level == fullLevel;
        Debug.Log("용사 만렙?" + isFullLevel);
    }
}
