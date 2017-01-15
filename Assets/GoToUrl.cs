using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToUrl : MonoBehaviour
{

    private string Url = "https://www.instagram.com/lucid_reality_labs/"; 

    private void OnMouseDown()
    {
        Application.OpenURL(Url);
    }
}
