using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuncionesDelMouse : MonoBehaviour
{
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        if (Application.isMobilePlatform)
        {
            Cursor.visible = false; // Once Android cursor bug is fixed, you can delete the next 3 lines. 
            Texture2D cursorTexture = new Texture2D(1, 1);
            cursorTexture.SetPixel(0, 0, Color.clear);
            Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        }
        else if (Application.isEditor)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
