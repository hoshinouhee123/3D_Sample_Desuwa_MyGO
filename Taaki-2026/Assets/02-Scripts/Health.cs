using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int maxHp = 3;
    public int currentHp;
    public Slider hpSlider;
    public GameObject hitEffect;

    public static int killCount;

    public float invincibleTime = 0f;
    float lastHitTime = -999f;

    public GameObject dropPrefab;
    public float dropChance = 0.3f;

    

    void Start()
    {
        currentHp = maxHp;
        UpdateBar();
    }

    public void TakeDamage(int damage)
    {
        if (currentHp <= 0) return;
        if (Time.time < lastHitTime + invincibleTime) return;
        lastHitTime = Time.time;


        currentHp -= damage;
        Debug.Log(name + " hp: " + currentHp);
        UpdateBar();

        Vector3 hitpos = transform.position + Vector3.up;
        if (hitEffect != null) Instantiate(hitEffect, hitpos, Quaternion.identity);

        if (currentHp <= 0) Die();
        else Blink();
    }

    void UpdateBar()
    {
        if (hpSlider != null)
            hpSlider.value = (float)currentHp / maxHp;
    }

    void Die()
    {
        if (CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
        else
        {
            if (dropPrefab != null && Random.value < dropChance)
            {
                Vector3 pos = transform.position + Vector3.up * 0.5f;
                Instantiate(dropPrefab, pos, Quaternion.identity);
            }
            killCount++;
            Destroy(gameObject);
        }
    }

    void Blink()
    {
        SetVinsible(false);
        Invoke(nameof(ShowAgain), 0.1f);
    }

    void ShowAgain()
    {
        SetVinsible(true);
    }

    void SetVinsible(bool on)
    {
        foreach (Renderer r in GetComponentsInChildren<Renderer>())
        {
            r.enabled = on;
        }
    }

    public void Heal(int amount)
    {
        currentHp = Mathf.Min(currentHp + amount, maxHp);
        UpdateBar();
    }
}
