using System.Linq;
using HurricaneVR.Framework.Core.Player;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace HurricaneVR.TechDemo.Scripts
{
    public class DemoManualTeleport : MonoBehaviour
    {
        public Transform PositionOne;
        public Transform PositionTwo;
        public HVRTeleporter Teleporter { get; set; }

        public void Start()
        {
            Teleporter = GameObject.FindObjectsOfType<HVRTeleporter>().FirstOrDefault(e => e.gameObject.activeInHierarchy);
        }

        public void GoToOne()
        {
            if (Teleporter && PositionOne)
            {   
                SceneManager.LoadScene(1);
                //Teleporter.Teleport(PositionOne.position, PositionOne.forward);
            }
        }

        public void GoToTwo()
        {
            if (Teleporter && PositionTwo)
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
