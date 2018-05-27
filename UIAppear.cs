using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIAppear : MonoBehaviour {

    public Image image;
    void Start () {
        image.enabled = false;
	}

    private void OnMouseDown()
    {
        image.enabled = !image.enabled;
    }
}
