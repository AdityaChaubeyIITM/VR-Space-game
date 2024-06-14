using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breakablePieces : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> Breakable;
    public float TimeToBreak=4;
    public float Timer=0;
    void Start()
    {
        foreach (var item in Breakable){
            item.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Timer+=Time.deltaTime;
        if (Timer>TimeToBreak){

            foreach (var item in Breakable){
                item.SetActive(true);
                item.transform.parent=null;
            }

            gameObject.SetActive(false);   
        }  
    }
}
