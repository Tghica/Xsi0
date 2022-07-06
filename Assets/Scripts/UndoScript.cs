using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoScript : MonoBehaviour
{
    public bool ok = false;
    private void OnMouseDown()
    {
        ok = true;
    }
}
