using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextTranslator : MonoBehaviour
{
    private TextMeshProUGUI text;
    [Header("Translations")]
    public string RuText;
    public string EnText;
    public string TrText;
    private void Awake()
    {
        text = GetComponent<TextMeshProUGUI>();
        RefreshText();
    }
    [ExecuteInEditMode]
    public void RefreshText()
    {
        string _text = EnText;
        switch (LanguageManager.CurrentLanguage)
        {
            case "ru":
                {
                    _text = RuText;
                    break;
                }
            case "tr":
                {
                    _text = TrText;
                    break;
                }
        }
        text.text = _text;
    }
}
