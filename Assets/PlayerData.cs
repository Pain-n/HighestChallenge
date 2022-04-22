using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float[] position;
    public bool Terminal1Complete;
    public bool Terminal2Complete;
    public bool Terminal3Complete;
    public bool Terminal4Complete;
    public bool Terminal5Complete;
    public bool Terminal6Complete;
    public bool TerminalServerComplete;
    public bool TerminalMaskComplete;

    public PlayerData(DoorController player)
    {
        Terminal1Complete = player.Terminal1Complete;
        Terminal2Complete = player.Terminal2Complete;
        Terminal3Complete = player.Terminal3Complete;
        Terminal4Complete = player.Terminal4Complete;
        Terminal5Complete = player.Terminal5Complete;
        Terminal6Complete = player.Terminal6Complete;
        TerminalServerComplete = player.TerminalServerComplete;
        TerminalMaskComplete = player.TerminalMaskComplete;
        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;
    }
}
