using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Design_partern.Singleton.Partern
{
    public class Test
    {
        private Test() { }
        private static Test _instance = null;
        private static object ob = new object();
        public static Test GetInstance()
        {
            if (_instance == null)
            {
                lock (ob)
                {
                    if (_instance == null)
                        _instance = new Test();
                }
            }
            return _instance;
        }
    }

    public class Test2
    {
        private static Test2 _instance = new Test2();
        private Test2() { }
        static Test2() { }
        public static Test2 GetInstance()
        {
            return _instance;
        }
    }

    public class Test3
    {
        public static Test3 GetInstance()
        {
            return INNNNN._instance;
        }

        public static Test3 GGG()
        {
            return null;
        }
        private class INNNNN
        {
            static INNNNN() { }
            internal static Test3 _instance = new Test3();
        }
    }
}
