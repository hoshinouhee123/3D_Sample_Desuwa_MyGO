using UnityEngine;
using System.Collections.Generic;

public class BattleLog : MonoBehaviour
{
    public int[] damages = { 1200, 3500, 800, 12000, 3500, 950 };
    public int criticalLine = 3000;


    [ContextMenu("전투 기록")]
    void ShowBattleLog()
    {
        List<int> criticals = new List<int>();

        int damageSum = 0;

        //총 데미지 구함
        foreach (int damage in damages)
        {
            damageSum += damage;

            if (damage > criticalLine)
            {
                criticals.Add(damage);
            }
        }

        Debug.Log($"총 데미지 {damageSum}");
        Debug.Log($"치명타 {criticals.Count}");

        foreach (int criticalCount in criticals)
        {
            Debug.Log($"치명타 {criticalCount}");
        }

        
    }


    [ContextMenu("전투 기록 업그레이드")]
    void ShowBattleLogUpgrade()
    {
        List<int> criticals = new List<int>();

        int damageSum = 0;

        //총 데미지 구함
        foreach (int damage in damages)
        {
            damageSum += damage;

            if (damage > criticalLine)
            {
                criticals.Add(damage);
            }
        }

        Debug.Log($"총 데미지 {damageSum}");
        Debug.Log($"치명타 {criticals.Count}");

        string criticalTexts = "치명타 목록: ";
        foreach (int criticalCount in criticals)
        {
            for (int i = 0; i < 1; i++)
            {
                criticalTexts += criticalCount;

                
            }

            criticalTexts += ", ";
        }


        Debug.Log(criticalTexts);
    }
}
