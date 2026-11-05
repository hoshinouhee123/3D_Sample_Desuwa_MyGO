using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725;
    public int gold = 1234;
    public int members = 4;
    public int kills = 7;
    public int expPerKill = 35;
    public int totalDamage = 250;
    public int hits = 20;

    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Settle()
    {
        //600 / 60 == 10 , 600 % 60 == 0
        //초
        int sec = playSeconds % 60; 
        Debug.Log(sec);

        int min = playSeconds / 60;
        Debug.Log($"{min % 60}");

        // 6600 / 60 == 110, 110 % 60 == 1
        //int 라서 소수점은 버리기에 딱 시간만 나옴

        int hour = (playSeconds / 60) % 60;
        Debug.Log(hour);

        Debug.Log($"{hour}시간 {min % 60}분 {sec}초");


        int minGold = gold / min;
        Debug.Log(minGold);

        int namergeGold = gold % members;
        Debug.Log(namergeGold);


        int normalExp = kills * expPerKill;
        Debug.Log(normalExp);

        int totalExp = (int)(normalExp * expRate);
        Debug.Log(totalExp);

        int currentLevel = 1 + (totalExp / 100);

        int namergeExp = 100 - (totalExp / 100);

        Debug.Log(currentLevel);

        float pyeongunDamage = ((float)totalDamage / hits);

        Debug.Log(pyeongunDamage);
    }

}
