using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class LanguageManager : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern string GetLang();
    [SerializeField]
    public static string CurrentLanguage = "ru"; //ru en tr

}
