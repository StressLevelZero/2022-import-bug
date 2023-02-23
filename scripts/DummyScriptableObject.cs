using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace ImportBug
{
    [CreateAssetMenu(fileName = "DummyScriptableObject.asset", menuName = "Dummy ScriptableObject", order = 0)]
    public class DummyScriptableObject : ScriptableObject
    {
        public string DummyValue = "This is an example scriptable object.";
    }
}