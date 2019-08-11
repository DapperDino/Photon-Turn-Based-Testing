using Photon.Pun;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace TurnBased
{
    public class PlayerNameInput : MonoBehaviour
    {
        [Required] [SerializeField] private TMP_InputField nameInputField = null;
        [Required] [SerializeField] private Button continueButton = null;

        private const string PlayerNamePrefKey = "PlayerName";

        private void Start() => SetUpInputField();

        private void SetUpInputField()
        {
            if (!PlayerPrefs.HasKey(PlayerNamePrefKey)) { return; }

            string defaultName = string.Empty;

            defaultName = PlayerPrefs.GetString(PlayerNamePrefKey);

            nameInputField.text = defaultName;
            SetPlayerName(defaultName);
        }

        public void SetPlayerName(string name)
        {
            continueButton.interactable = !string.IsNullOrEmpty(name);
        }

        public void SavePlayerName()
        {
            string playerName = nameInputField.text;

            PhotonNetwork.NickName = playerName;

            PlayerPrefs.SetString(PlayerNamePrefKey, playerName);
        }
    }
}
