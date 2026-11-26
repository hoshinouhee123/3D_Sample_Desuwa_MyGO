using UnityEngine;

public class Fighter
{
    public string name;
    public int hp;
    public int attack;
    public int defense;

    public Fighter(string name, int hp, int attack, int defance)
    {
        this.name = name;
        this.hp = hp;
        this.attack = attack;
        this.defense = defance;


    }

    public int GetDamageTo(Fighter target)
    {
        if (attack - target.defense < 1)
        {
            return 1;
        }
        else
        {
            return attack - target.defense;
        }
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;

        if (hp < 0)
        {
            hp = 0;
        }
    }

    public bool IsDead()
    {
        if (hp <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
