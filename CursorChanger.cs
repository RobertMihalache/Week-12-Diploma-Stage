using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorChanger : MonoBehaviour {

    public Texture2D cursorImage;
    void Start () {
        Cursor.SetCursor(cursorImage, Vector2.zero, CursorMode.Auto);
	}

}
