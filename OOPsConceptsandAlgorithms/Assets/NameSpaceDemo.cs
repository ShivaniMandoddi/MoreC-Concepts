using UnityEngine;

namespace MyNewNamespace
{
    [System.Serializable]  // Making whole class as serializable field
    public class MyNameSpaceClass
    {
        public int playerSpeed;
        public float playerRotation;
        public bool isAlive;
        public string names;
        public static void MyPrint()
        {
            Debug.Log("Shivani");
        }
    }
    namespace MyUI
    {
        public class MyUIClass
        {
            public static void MyPrintUI()
            {
                Debug.Log("My Print Ui");
            }
        }
    }
}