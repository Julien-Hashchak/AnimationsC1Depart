using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuvrirPorte : MonoBehaviour
{
    [SerializeField] GameObject _PorteDroite;
    [SerializeField] GameObject _PorteGauche;
    [SerializeField] GameObject _joueur;

    // Start is called before the first frame update
    void Start()
    {
         Debug.Log(_PorteDroite);
         Debug.Log(_PorteGauche);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
{
if(other.tag =="player"){
    _PorteGauche.GetComponent<Animator>().SetBool("Ouvre",true);
}

}



}