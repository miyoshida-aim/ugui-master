using System.Collections;
using System.Collections.Generic;
using UniRx;
using UniRx.Triggers;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TargetObject : UIBehaviour
{
    [SerializeField]
    Button self;

    // Start is called before the first frame update
    void Start()
    {
        self.OnClickAsObservable()
            .Subscribe(_ => Debug.Log("target clicked"))
            .AddTo(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
