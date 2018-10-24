using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ClickHandler : UIBehaviour, IPointerClickHandler
{

    [SerializeField]
    GameObject target;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {

        Debug.Log("onpointer click");
        var raycastResult = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raycastResult);
//        foreach (var result in raycastResult)
//        {
//            Debug.Log("result : " + result.gameObject.name);
//        }

        if (raycastResult.Any(ray => ray.gameObject.name.Equals(target.name)))
        {
        //    ExecuteEvents.Execute(target, eventData, ExecuteEvents.pointerClickHandler);
            EventSystem.current.SetSelectedGameObject(target);
        }



    }

}
