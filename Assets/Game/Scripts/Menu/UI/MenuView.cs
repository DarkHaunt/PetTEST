using UnityEngine;
using UnityEngine.UI;

namespace Game.Scripts.Menu.UI
{
    public class MenuView : MonoBehaviour
    {
        [field: SerializeField] public Button CreateButton { get; private set; }
        [field: SerializeField] public Button JoinButton { get; private set; }
        [field: SerializeField] public Button ExitButton { get; private set; }
    }
}