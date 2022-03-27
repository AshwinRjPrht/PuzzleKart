using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarButtons : MonoBehaviour
{
    public static bool isGasBtnDwn;
    public static bool isBrakeBtnDwn;

    private void Start()
    {
        isGasBtnDwn = false;
        isBrakeBtnDwn = false;
    }

    public void GasBtnDwn()
    {
        isGasBtnDwn = true;
        Debug.Log("Button pressed gas");
    }
    public void GasBtnUp()
    {
        isGasBtnDwn = false;
        Debug.Log("Button not pressed gas");

    }
    public void BrakeBtnDwn()
    {
        isBrakeBtnDwn = true;
        Debug.Log("Button pressed brake");

    }
    public void BrakeBtnUp()
    {
        isBrakeBtnDwn = false;
        Debug.Log("Button not pressed brake");

    }
}
