using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


namespace UGUIShader
{
    public class UICustomDefaultGUI : ShaderGUI
    {
        public override void OnGUI(MaterialEditor materialEditor, MaterialProperty[] properties)
        {
            materialEditor.PropertiesDefaultGUI(properties);
        }
    }
    
}

