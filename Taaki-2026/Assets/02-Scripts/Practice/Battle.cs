using UnityEngine;

public class Battle : MonoBehaviour
{
    public int heroHp = 100;
    public int heroAttack = 30;
    public int heroDefence = 10;
    public int monsterHp = 80;
    public int monsterAttack = 25;
    public int monsterDefence = 5;


    void Attack(int turn, Fighter attacker, Fighter target)
    {
        int damage = attacker.GetDamageTo(target);
        target.TakeDamage(damage);

        Debug.Log($"{turn}턴: {attacker.name}의 공격 {damage}, {target.name} 체력 {target.hp}");
    }

    [ContextMenu("전투")]
    void StartBattle()
    {
        Fighter hero = new Fighter("용사", heroHp, heroAttack, heroDefence);

        Fighter monster = new Fighter("슬라임", monsterHp, monsterAttack, monsterDefence);

        int turn = 0;

        while (hero.hp != 0 || monster.hp != 0)
        {
            turn++;

            Attack(turn, hero, monster);

            if (monster.IsDead())
            {
                Debug.Log($"{hero.name} 승리 ({turn}턴)");
                break;
            }
            else
            {
                Attack(turn, monster, hero);

                if (hero.IsDead())
                {
                    Debug.Log($"{monster.name} 승리 ({turn}턴)");
                    break;
                }
            }
        }
    }
}
