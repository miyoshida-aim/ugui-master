using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TargetObject : MonoBehaviour
{
    [SerializeField]
    Button self;

    // Start is called before the first frame update
    void Start()
    {
        self.onClick.AddListener(() => Debug.Log("aaaaa"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
