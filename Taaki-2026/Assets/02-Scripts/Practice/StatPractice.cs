using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName;
    public int level;
    public float attack;
    public bool isBoss;


    [ContextMenu("스탯")]
    void ShowStat()
    {
        Debug.Log($"플레이어 이름: {playerName}");
        Debug.Log($"플레이어 레벨벨 : {level}");
        Debug.Log($"공격력: {attack}");
        Debug.Log($"보스일까 아닐까 정답은: {isBoss}");

    }
}
