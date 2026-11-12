using UnityEngine;

public class DamagePractice : MonoBehaviour
{
    public int attack = 12;
    public int defence = 5;
    public bool isCritical = true;
    public bool targetIsBoss = true;

    [ContextMenu("데미지")]
    void Calc()
    {
        int defaultDamage = attack - defence;

        if (defaultDamage > 1)
        {
            defaultDamage = attack - defence;
        }
        else
        {
            defaultDamage = 1;
        }

        if (isCritical)
        {
            defaultDamage = defaultDamage * 2;
        }

        if (targetIsBoss)
        {
            
            defaultDamage = (int)(defaultDamage / 2);
            
        }

        Debug.Log (defaultDamage);
    }

    [ContextMenu("계단")]
    void Stairs()
    {
        int height = 10;

        string text = "";

        for (int row = 1 ; row <= height ; row++)
        {
            for (int col = 1; col <= row ; col++)
            {
                text += "*";
            }

            text += "\n";
        }

        Debug.Log(text);
    }

    [ContextMenu("뒤집힌 계단")]
    void ReverseStair()
    {
        int height = 5;

        string text = "";

        for (int row = height; row > 0 ; row--)    //5
        {
            for (int col = row  ; col > 0 ; col--)     //5
            {
                text += "*";
            }

            text += "\n";
        }

        Debug.Log(text);
    }

    
}
