using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class MeteorPistol : MonoBehaviour
{
    public ParticleSystem particles;
    public LayerMask layer;
    public Transform shootSource;
    public float distance = 10;
    public bool raycastActive = false;



    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x=> StartShoot());
        grabInteractable.deactivated.AddListener(x=>StopShoot());

        
    }
    public void StartShoot(){
        particles.Play();
        raycastActive=true;

    }
    public void StopShoot(){
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        raycastActive=false;

    }

    // Update is called once per frame
    void Update()
    {
        if(raycastActive){
            RaycastCheck();
            }
        
    }
    void RaycastCheck(){
        RaycastHit hit;
        bool hashit= Physics.Raycast(shootSource.position,shootSource.forward, out hit,distance,layer);
        if (hashit){
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
        }
    }
}
