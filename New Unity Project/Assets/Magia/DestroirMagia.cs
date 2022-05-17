using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroirMagia : MonoBehaviour
{
    public int DistanciaDaMagia;
    void Start()
    {
        GameObject.Destroy(gameObject, DistanciaDaMagia);
    }

}
