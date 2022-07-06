using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cell : MonoBehaviour
{
    public static int paritate = 0;
    public int pos;
    public static int[] stack = new int[10];
    private void OnMouseDown()
    {
        if (GetComponent<TMP_Text>().text == "" && manager.winner  == false)
        {
            stack[paritate] = pos - 1;
            GetComponent<TMP_Text>().text = paritate % 2 == 0 ? "X" : "0";
            paritate++;
        }
    }
}
