using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrendreTorche : MonoBehaviour
{
    [SerializeField] GameObject _monJoueur;
    [SerializeField] GameObject _torcheMur;
    [SerializeField] GameObject _torcheJoueur;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "player"){
            _torcheMur.SetActive(false);
            _torcheJoueur.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update( )
    {
        
    }
}
