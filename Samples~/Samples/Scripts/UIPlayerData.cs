using UnityEngine;
using TMPro;

namespace CharKole.GameServices.Samples
{
    public class UIPlayerData : MonoBehaviour
    {
        [SerializeField]
        private TextMeshProUGUI healthText;
        [SerializeField]
        private TextMeshProUGUI speedText;
        [SerializeField]
        private TextMeshProUGUI damageText;

        private void Update()
        {
            PlayerData playerData = Services.DataManager.GetPlayerData();
            healthText.text = "Health: " + playerData.health.ToString();
            speedText.text = "Speed: " + playerData.speed.ToString();
            damageText.text = "Damage: " + playerData.damage.ToString();
        }
    }
}
