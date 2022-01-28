using UnityEngine;
using UnityEngine.UI;

public class GameUI : MonoBehaviour
{
    [SerializeField] Text _level;

    public void UpdatePanel(int level)
        => _level.text = level.ToString();
}
