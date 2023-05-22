using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CubeHealth : MonoBehaviour, INewsletterSubscriber
{
    public TextMeshProUGUI textMeshProUGUI;
    public IntValue MonsterHp;
    public SubNewsletter MonsterDeathNewsletter;
    

    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
        
    }

    private void Start()
    {
        MonsterHp.value = 100;
    }

    private void Update()
    {
        UpdateTextWithNumbers(MonsterHp.value);
        MonsterDeathNewsletter.SubsrcribeForNewsletter(this);
    }

    public void UpdateTextWithNumbers(int value)
    {
        if (textMeshProUGUI != null) textMeshProUGUI.text = value.ToString();
    }

    public void Notify()
    {
        Debug.Log("Informed");
        Destroy(textMeshProUGUI);
       
        
    }
}
