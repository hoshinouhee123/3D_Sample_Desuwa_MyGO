using UnityEngine;

public class LevelSystem : MonoBehaviour
{
    public int expPerKill = 35000;
    public int killCount = 3;


    [ContextMenu("레벨 계산")]
    void CalculateLevel()
    {
        int level = 1;
        int exp = 0;
        int currentKillcount = 0;

        for (int i = 0; i < killCount; i++)
        {
            exp += expPerKill;
            currentKillcount++;

            while (level * 10000 < exp)
            {
                exp -= level * 10000;
                level += 1;

                Debug.Log($"레벨 업 {level} ({currentKillcount}마리 째)");
            }
        }


        Debug.Log($"최종 Lv {level}, 경험치 {exp} / {level * 10000}");
    }
}
