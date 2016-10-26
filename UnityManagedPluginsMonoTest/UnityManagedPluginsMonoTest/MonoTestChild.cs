using UnityEngine;
using System.Collections;

namespace UnityManagedPluginsMonoTest
{
    public class MonoTestChild : MonoTest
    {
        public override void Start()
        {
            Debug.Log("[MonoTestChild Start]");
        }
    }
}
