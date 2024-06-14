using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trashCan : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start() {
        GetComponent<triggerScript>().OnEnterEvent.AddListener(InsideTrash);
    }
    public void InsideTrash(GameObject go) {
        go.SetActive(false);

        
    }
}
