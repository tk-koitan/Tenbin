using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KoitanLib
{
    static class KoitanDebugExtensions
    {
        public static void TestExtensions(this MonoBehaviour mono)
        {
            KoitanDebug.DisplayBox("a", mono);
        }

        public static void Display(this float value, MonoBehaviour mono)
        {
            KoitanDebug.DisplayBox(value.ToString(), mono);
        }
    }
}
