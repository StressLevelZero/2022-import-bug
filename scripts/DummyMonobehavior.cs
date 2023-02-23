using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ImportBug
{
    public class DummyMonobehavior : MonoBehaviour
    {
        [TextAreaAttribute(3, 16)]
        public string dummyField = "This is an example monobehavior";

        private void Start()
        {
            Debug.Log("Dummy Monobehavior is working");
        }
    }
}
