using ExitGames.Client.Photon;
using GorillaNetworking;
using Photon.Pun;
using Photon.Realtime;

namespace GorillaXS.Basics
{
    internal class PUNNotifications : MonoBehaviourPunCallbacks
    {
        public override void OnPlayerEnteredRoom(Player newPlayer)
        {
            Notifier.Notify("Player Joined", string.Format("{0} has joined the room", PlayFabAuthenticator.instance.GetSafety() ? newPlayer.DefaultName : newPlayer.NickName), timeout: 1.5f, AudioPath: "");
        }

        public override void OnPlayerLeftRoom(Player otherPlayer)
        {
            Notifier.Notify("Player Left", string.Format("{0} has left the room", PlayFabAuthenticator.instance.GetSafety() ? otherPlayer.DefaultName : otherPlayer.NickName), timeout: 1.5f, AudioPath: "");
        }

        public override void OnRoomPropertiesUpdate(Hashtable propertiesThatChanged)
        {
            Notifier.Notify("Room Update", "The room properties have been updated", Base64Icon: "warning");
        }
    }
}
