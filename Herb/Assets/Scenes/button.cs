using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class button : MonoBehaviour
{
    public GameObject Building;

    public void BuldingSetActive()
    {
        Building.SetActive(!Building.active);
    }
}