using UnityEngine;

public class ForeachPractice : MonoBehaviour
{
    public int[] monsterHps = { 0, 35, 0, 80, 12 };

    [ContextMenu("foreach 실습")]
    void CountAlive()

    {
        int aliveMonster = 0;
        int hpsSum = 0;

        foreach (var monster in monsterHps)
        {
            if (monster == 0) continue;

            hpsSum += monster;
            aliveMonster++;
        }

        Debug.Log($"살아있는 몬스터 {aliveMonster}마리");
        Debug.Log($"남은 체력 합 {hpsSum}");
    }
}
