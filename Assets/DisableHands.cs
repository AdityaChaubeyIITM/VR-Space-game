using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.WebGL;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class DisableHands : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject leftHandModel;
    public GameObject rightHandModel;
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(HideGrabingHand);
        grabInteractable.selectExited.AddListener(ShowGrabingHand);
        
    }

    // Update is called once per frame
    public void HideGrabingHand(SelectEnterEventArgs args)
    {
        if(args.interactorObject.transform.tag== "Left Hand")
        {
            leftHandModel.SetActive(false);
        }
        else if (args.interactorObject.transform.tag== "Right Hand")
        {
            rightHandModel.SetActive(false);
        }
    }

    public void ShowGrabingHand(SelectExitEventArgs args)
    {
        if(args.interactorObject.transform.tag== "Left Hand")
        {
            leftHandModel.SetActive(true);
        }
        else if (args.interactorObject.transform.tag== "Right Hand")
        {
            rightHandModel.SetActive(true);
        }
    }
    void Update()
    {
        
    }
}
