using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextManager : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField input;
    [SerializeField]
    private TextMeshProUGUI text;
    

    private void Awake()
    {
        text.gameObject.SetActive(false);
    }

    public void ShowText()
    {
        text.text = input.text;
        if (!text.gameObject.activeSelf) text.gameObject.SetActive(true);
    }
    
}
