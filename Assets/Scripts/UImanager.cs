using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UImanager : MonoBehaviour
{
    private static UImanager instance;

    public static UImanager Instance
    {
        get
        {
            if (instance == null)
            {
              instance = FindObjectOfType<UImanager>();
            }

            return instance;
        }
    }

    private int appleCount;

    [SerializeField]
    private TMP_Text appleText;


    public void AddApple()
    {
        appleCount++;
        appleText.text = appleCount.ToString();
    }
}