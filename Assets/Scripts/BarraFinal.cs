using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarraFinal : MonoBehaviour
{
    public GameObject modulo;
    public ModuloFinal variable1;
    public float counter;
    public float maxCounter;
    public float startingCounter;
    public string Identificador;
    // Start is called before the first frame update
    void Start()
    {
        modulo = GameObject.Find("Granja");
        if (modulo != null){
            variable1 = modulo.GetComponent<ModuloFinal>();
            int holdCANT = variable1.contCALV;
            int holdTEMP = variable1.contTEMP;
            int holdCNTA = variable1.contCNTA;
            int holdNIVA = variable1.contNIVA;
            
            
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
