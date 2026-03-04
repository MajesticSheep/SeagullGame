using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class ShowInfo : MonoBehaviour
{
    public TextMeshProUGUI beachWorldInfo;
    public void ShowTextOnClick()
    {
        if(beachWorldInfo != null)
        {
            beachWorldInfo.gameObject.SetActive(!beachWorldInfo.gameObject.activeSelf);
        }
    }
}
