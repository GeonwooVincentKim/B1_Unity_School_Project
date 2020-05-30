using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int health = 30;
    int level = 5;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");

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

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼 끝남?" + isEndTutorial);


        string monsterAlarm;
        switch (monsters[1])
        {

            case "슬라임":
                Debug.Log("소형 몬스터 출현!");
                break;

            case "사막뱀":
                monsterAlarm = "소형 몬스터가 출현!";
                break;

            case "악마":
                Debug.Log("중형 몬스터 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터 출현!");
                break;
            default:
                Debug.Log("??? 몬스터 출현!");
                break;
        }

        for(int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("이 지역에 있는 몬스터 : " + monsters[index]);
        }

        foreach(string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터는? : " + monster);
        }

        //health = Heal(health);
        Heal();
        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는 " + monsters[index] + "에게" + Battle(monsterLevel[index]));
        }

        // Import Class
        Player player = new Player();
        player.id = 0;
        player.name = "나법관";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은 " + player.level + "입니다.");
        Debug.Log(player.move());
    }

    //int Heal(int currentHealth)
    //{
    //    currentHealth += 10;
    //    Debug.Log("힘을 받았습니다. " + currentHealth);
    //    return currentHealth;
    //}
    void Heal()
    {
        health += 10;
        Debug.Log("힘을 받았습니다." + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "승리";
        else
            result = "패배";
        return result;
    }
}
