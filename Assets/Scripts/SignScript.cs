using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignScript : MonoBehaviour
{

    [SerializeField] GameObject sign;
    
    private void OnMouseDown()
    {
        sign.SetActive(true);
    }

    public void CloseWindow()
    {
        sign.SetActive(false);
    }

}
