using UnityEngine;
using UnityEngine.UI;

namespace CharKole.GameServices.Samples
{
    public class UIPlayerData : MonoBehaviour
    {
        [SerializeField]
        private Text healthText;
        [SerializeField]
        private Text speedText;
        [SerializeField]
        private Text damageText;

        private void Update()
        {
            PlayerData playerData = Services.DataManager.GetPlayerData();
            healthText.text = "Health: " + playerData.health.ToString();
            speedText.text = "Speed: " + playerData.speed.ToString();
            damageText.text = "Damage: " + playerData.damage.ToString();
        }
    }
}
