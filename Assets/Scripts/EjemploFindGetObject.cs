using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjemploFindGetObject : MonoBehaviour
{
    public GameObject modulo;
    public ModuloFinal variable; // Variable tipo Script
    // Start is called before the first frame update
    void Start()
    {
        modulo = GameObject.Find("Granja");
        if (modulo != null){
            variable = modulo.GetComponent<ModuloFinal>();
            int holdCANT = variable.contCALV;
            int holdTEMP = variable.contTEMP;
            int holdCNTA = variable.contCNTA;
            int holdNIVA = variable.contNIVA;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}