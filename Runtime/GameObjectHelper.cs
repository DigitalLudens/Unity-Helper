using UnityEngine;

namespace beio.Helper
{
    public static partial class GameObjectHelper
    {
        public static void Destory(this GameObject obj)
        {
            if (Application.isPlaying) GameObject.Destroy(obj);
            else GameObject.DestroyImmediate(obj);
        }
        public static void SetActive(this Behaviour behaviour, bool active)
        {
            if (behaviour == null) return;
            behaviour.gameObject.SetActive(active);
        }
    }
}