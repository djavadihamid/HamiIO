using UnityEngine;

namespace HamiIO
{
    public class test : MonoBehaviour
    {
        public void Start()
        {
            HamiModuleEnum.Write("Hello",new []{"hello","from","the","outside"});
        }
    }
}