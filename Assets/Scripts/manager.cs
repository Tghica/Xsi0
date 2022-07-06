using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class manager : MonoBehaviour
{
    public TMP_Text[] v;
    public TMP_Text afisajFinal;
    private string ch;
    private bool ok;
    public GameObject liniaFinal;
    public static bool winner = false;
    public GameObject restart;
    public GameObject undo;
    public GameObject hint;

    // Update is called once per frame
    void Update()
    {
        if (restart.GetComponent<RestartScript>().ok == true)
        {
            restart.GetComponent<RestartScript>().ok = false;
            Cell.paritate = 0;
            Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
            c.a = 0;
            winner = false;
            afisajFinal.text = "";
            liniaFinal.GetComponent<SpriteRenderer>().color = c;
            liniaFinal.transform.rotation = Quaternion.Euler(0, 0, 0);
            liniaFinal.transform.localPosition = new Vector3(-0.728573918f, -0.72483319f, 10.0279436f);
            for (int i = 0; i < 9; i++)
            {
                v[i].text = "";
            }
            hint.GetComponent<HintScript>().ok = false;
            undo.GetComponent<UndoScript>().ok = false;
        }

        if (undo.GetComponent<UndoScript>().ok == true && winner == false)
        {
            undo.GetComponent<UndoScript>().ok = false;
            if (Cell.paritate > 0)
            {
                Cell.paritate--;
                v[Cell.stack[Cell.paritate]].text = "";
            }
        }

        if(hint.GetComponent<HintScript>().ok == true && winner == false)
        {
            hint.GetComponent<HintScript>().ok = false;

            for (int i = 0; i < 9; i++)
            {
                if (v[i].text == "")
                {
                    Cell.stack[Cell.paritate] = i;
                    v[i].text = Cell.paritate % 2 == 0 ? "X" : "0";
                    Cell.paritate++;
                    break;
                }
            }
        }

        ch = "X";
        {
            if (v[0].text == ch && v[1].text == ch && v[2].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.rotation = Quaternion.Euler(0, 0, 90);
                liniaFinal.transform.localPosition = new Vector3(-0.620000005f, 3.03999996f, 10.0279436f);
            }
            if (v[3].text == ch && v[4].text == ch && v[5].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            if (v[6].text == ch && v[7].text == ch && v[8].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.rotation = Quaternion.Euler(0, 0, 90);
                liniaFinal.transform.localPosition = new Vector3(-0.469999999f, -3.88000011f, 10.0279436f);
            }
            if (v[0].text == ch && v[3].text == ch && v[6].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.localPosition = new Vector3(-6.01000023f, -3.46000004f, 10.0279436f);
            }
            if (v[1].text == ch && v[4].text == ch && v[7].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
            }
            if (v[2].text == ch && v[5].text == ch && v[8].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.localPosition = new Vector3(5.51999998f, -3.46000004f, 10.0279436f);
            }

            if (v[0].text == ch && v[4].text == ch && v[8].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            if (v[2].text == ch && v[4].text == ch && v[6].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.rotation = Quaternion.Euler(0, 0, -45);
            }
        }
        ch = "0";
        {
            if (v[0].text == ch && v[1].text == ch && v[2].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.rotation = Quaternion.Euler(0, 0, 90);
                liniaFinal.transform.localPosition = new Vector3(-0.620000005f, 3.03999996f, 10.0279436f);
            }
            if (v[3].text == ch && v[4].text == ch && v[5].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.rotation = Quaternion.Euler(0, 0, 90);
            }
            if (v[6].text == ch && v[7].text == ch && v[8].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.rotation = Quaternion.Euler(0, 0, 90);
                liniaFinal.transform.localPosition = new Vector3(-0.469999999f, -3.88000011f, 10.0279436f);
            }
            if (v[0].text == ch && v[3].text == ch && v[6].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.localPosition = new Vector3(-6.01000023f, -3.46000004f, 10.0279436f);
            }
            if (v[1].text == ch && v[4].text == ch && v[7].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
            }
            if (v[2].text == ch && v[5].text == ch && v[8].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.localPosition = new Vector3(5.51999998f, -3.46000004f, 10.0279436f);
            }

            if (v[0].text == ch && v[4].text == ch && v[8].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.rotation = Quaternion.Euler(0, 0, 45);
            }
            if (v[2].text == ch && v[4].text == ch && v[6].text == ch)
            {
                afisajFinal.text = ch + " Castiga";
                winner = true;
                Color c = liniaFinal.GetComponent<SpriteRenderer>().color;
                c.a = 256;
                liniaFinal.GetComponent<SpriteRenderer>().color = c;
                liniaFinal.transform.rotation = Quaternion.Euler(0, 0, -45);
            }
        }
        if (afisajFinal.text == "")
        {
            ok = true;
            for (int i = 0; i < 9; i++)
            {
                if (v[i].text == "")
                    ok = false;
            }
            if (ok == true)
            {
                afisajFinal.text = "E egal";
                winner = true;
            }
        }
    }
}
