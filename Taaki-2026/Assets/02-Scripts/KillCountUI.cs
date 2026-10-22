using TMPro;
using UnityEngine;

public class KillCountUI : MonoBehaviour
{

    public TMP_Text label;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health.killCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        label.text = "Kill " + Health.killCount;
    }
}
