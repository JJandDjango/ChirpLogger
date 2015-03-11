using ICities;
using UnityEngine;

using System.Collections.Generic;

using ChirpLogger;

namespace ChirpLoggerExample
{
	public class DebugChirperTest : IUserMod {
		public string Name {
      get { return "Chirp Logger Example"; }
		}
		public string Description {
			get { return "Example project using the ChirpLogger tool"; }
		}
	}

  public class ChirperExp : IChirperExtension
  {

    public void OnCreated(IChirper chirper)
    {
      ChirpLog.Info("Chirp Logger Example Online");
      ChirpLog.Debug(DumpAllGameObjects());
    }

    public void OnMessagesUpdated()
    {

    }

    public void OnNewMessage(IChirperMessage message)
    {
      ChirpLog.Info("Chirper chirped: " + message.ToString());
    }

    public void OnReleased()
    {
      ChirpLog.Info("Chirp Logger Example Offline");
      ChirpLog.Flush();
    }

    public void OnUpdate()
    {
      
    }

    public string DumpAllGameObjects()
    {
      List<GameObject> allObjects = new List<GameObject>( GameObject.FindObjectsOfType<GameObject>() );
      List<GameObject> roots = new List<GameObject>();

      string result = "";

      foreach(GameObject obj in allObjects)
      {
        result += obj.name + "\n";
      }

      return result;
    }
  }
}
