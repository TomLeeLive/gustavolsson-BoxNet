using System;

namespace BoxNet
{
    public static class NetworkSettings
    {
        private static string gameAppId = null;

        public static string GameAppId
        {
            get
            {
                if (gameAppId == null)
                {
                    throw new InvalidOperationException($"The {nameof(NetworkSettings)}.{nameof(GameAppId)} must be set to a unique id for your game at start-up for BoxNet to function.");
                }
                return gameAppId;
                /*
                // Get guid
                if (gameAppId == string.Empty)
                {
                    var assembly = System.Reflection.Assembly.GetAssembly(Game.Instance.GetType());
                    if (assembly != null)
                    {
                        var guidObjs = assembly.GetCustomAttributes(typeof(System.Runtime.InteropServices.GuidAttribute), false);
                        if (guidObjs != null && guidObjs.Length > 0)
                        {
                            gameAppId = ((System.Runtime.InteropServices.GuidAttribute)guidObjs[0]).Value;
                        }
                    }
                }

                // No guid?
                if (gameAppId == string.Empty)
                {
                    gameAppId = "MonoGameApp";
                }

                return gameAppId;
                */
            }
            set { gameAppId = value; }
        }

        public static int Port = 14242;
        public static string MasterServerAddress = "127.0.0.1";
        public static int MasterServerPort = 14243;
        public static TimeSpan MasterServerRegistrationInterval = TimeSpan.FromSeconds(60.0);
        public static string MasterServerPayload = string.Empty;
    }
}
