using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] GameObject _DoorWoodenRoundLeft;
    [SerializeField] GameObject _Player;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_DoorWoodenRoundLeft);
    }

    // Update is called once per frame
    void Update()
    {

    }
void OnTriggerEnter(Collider other){

        if(other.tag =="Player"){
    _DoorWoodenRoundLeft.GetComponent<Animator>().SetTrigger("New Trigger");

    }
}
}