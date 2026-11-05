using UnityEngine;

public class HPPractice : MonoBehaviour
{
    public int currentHP = 7;
    public int maxHp = 10;

    [ContextMenu("Ã¼·Â")]
    void PrintHP()
    {
        int a = (int)((float) currentHP / maxHp * 100);   // 70

        Debug.Log($"HP {a}%");
    }
}
