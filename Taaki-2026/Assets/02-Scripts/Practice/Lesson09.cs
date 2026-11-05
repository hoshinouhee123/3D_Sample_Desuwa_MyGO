using UnityEngine;
using UnityEngine.UIElements;

public class Lesson09 : MonoBehaviour
{
    public int attack = 10;
    int killConut = 0;

    public int gold = 100;


    public string itemName = "포션";
    public int price = 30;
    public float discount = 0.5f;
    public bool isSoldOut = false;

    private void Start()
    {
        Debug.Log(attack);
    }

    void Hit()
    {
        killConut = killConut + 1;
    }

    [ContextMenu("골드 보기")]
    void ShowGold()
    {
        Debug.Log(gold);
    }

    [ContextMenu("예측 1")]
    void Predict1()
    {
        int hp = 10;
        hp = hp - 3;
        Debug.Log(7);
        Debug.Log(hp);  //hp == 10 - 3
        hp = 20;        //hp에 새로 20을 선언했기에
        Debug.Log(20);
        Debug.Log(hp);  //hp는 20
        int maxHp = hp; //이미 maxHp에 hp를 선언했기에
        hp = 5;     //후에 hp에 5를 선언해도
        Debug.Log(20);
        Debug.Log(maxHp);       //maxHp는 20임
    }

    [ContextMenu("처치")]
    void CountKill()
    {
        int defense = 3;
        killConut += killConut + 1;
        Debug.Log(attack - defense);
        Debug.Log(killConut);
    }

    [ContextMenu("가격")]
    void ShowPrice()
    {
        float finalPrice = price * discount;
        Debug.Log(itemName + "" + finalPrice);
    }

    [ContextMenu("오버 플로")]
    void Overflow()
    {
        int gold = int.MaxValue;// int 최댓값은2147483647
        Debug.Log(gold);    //따라서 2147483647
        Debug.Log(2147483648);
        gold = gold + 1;    //최댓값이 넘으면 최솟값으로 돌아감
        Debug.Log(-2147483648); //따라서 -2147483647
        Debug.Log(gold);
        byte red = 255;     //byte의 최댓값은 255
        red++;              //값을 1더함
        Debug.Log(0);
        Debug.Log(red);     //따라서 최솟값인 0으로 돌아감
    }

    [ContextMenu("정밀도")]
    void Precision()
    {
        double d = 0.1 + 0.2;
        Debug.Log(false);
        Debug.Log(d == 0.3);

        float half = 1 / 2;
        Debug.Log(0);
        Debug.Log(half);
    }

    [ContextMenu("자료형")]
    void Types()
    {
        int level = 30;
        byte red = 255;
        char grade = 'S';
        float speed = 5.5f;
        bool isHigh = level >= 10;
        Debug.Log(level + " " + red + " " + grade);
        Debug.Log(speed + " " + isHigh);
    }

    [ContextMenu("예측 2")]
    void Predict2()
    {
        int hp = 7;
        int maxHp = 10;
        Debug.Log(0);
        Debug.Log(hp/maxHp);

        Debug.Log(0.7);
        Debug.Log((float)hp / maxHp);

        Debug.Log(3);
        Debug.Log(hp / 2);

        Debug.Log(3.5);
        Debug.Log(hp / 2f);

        Debug.Log(1);
        Debug.Log(hp % 2);

    }

    [ContextMenu("예측 3")]
    void Predict3()
    {
        int a = 1;
        int b = 2;

        Debug.Log("합 : 12");
        Debug.Log("합: " + a + b);

        Debug.Log("합 : 3");
        Debug.Log("합: " + (a + b));

        Debug.Log("12점");
        Debug.Log(a + b + "점");

        Debug.Log("HP 3");
        Debug.Log("HP " + 7 / 2);
    }
}
