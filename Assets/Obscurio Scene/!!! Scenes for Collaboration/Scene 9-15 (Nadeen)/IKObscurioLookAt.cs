using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKObscurioLookAt : MonoBehaviour
{
    Animator anim;
    public GameObject target;
    public float Weight = 1;

    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorIK(int layerIndex)
    {
        anim.SetLookAtPosition(target.transform.position);
        anim.SetLookAtWeight(Weight);
    }

    void Update()
    {

    }
}