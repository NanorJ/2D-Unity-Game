using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class LoadSceneOnClick : MonoBehaviour
{

    public void SetText(string text)
    {
        transform.Find("Text").GetComponent<Text>();
    }




}