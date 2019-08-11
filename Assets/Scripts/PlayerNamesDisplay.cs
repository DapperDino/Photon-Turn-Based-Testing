using Photon.Pun;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;

namespace TurnBased
{
    public class PlayerNamesDisplay : MonoBehaviour
    {
        [Required] [SerializeField] private TextMeshProUGUI myNameText = null;
        [Required] [SerializeField] private TextMeshProUGUI opponentNameText = null;

        private void Start()
        {
            myNameText.text = PhotonNetwork.NickName;
            opponentNameText.text = PhotonNetwork.PlayerListOthers[0].NickName;
        }
    }
}
