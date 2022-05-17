using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LancarMagias : MonoBehaviour
{
    public Rigidbody Magia;
    public Transform OndeSaiMagia;
    public int VelocidadeDaMagia;
      
    public void atacar(){
        Rigidbody Rb = Rigidbody.Instantiate (Magia, OndeSaiMagia.position, OndeSaiMagia.rotation)
            as Rigidbody;
            Rb.AddForce(OndeSaiMagia.forward * VelocidadeDaMagia);
    }
}
