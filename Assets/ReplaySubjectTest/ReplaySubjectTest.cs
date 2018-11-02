using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using UnityEngine.EventSystems;

public class ReplaySubjectTest : UIBehaviour
{
    readonly ReplaySubject<int> subject = new ReplaySubject<int>(2);

    protected override void Start()
    {
        base.Start();
        subject.OnNext(1);
        subject.OnNext(2);


        subject.Subscribe(value => Debug.Log("last ???? " + value)).AddTo(this);

        subject.OnNext(3);
        subject.OnNext(4);
        subject.OnNext(5);
    }
}
