using System;
using System.Collections;
using System.Collections.Generic;

namespace libhakyn.Command
{
    public class CommandDelegates
    {
        // Map of delegate objects to their command bytes
        private static Hashtable InitializedDelegates = new Hashtable();

        // Get whether a command has been initialized
        public static bool CommandInitialized(byte b)
        {
            return InitializedDelegates.Contains(b);
        }

        // Get the actual command delegate
        public static object getInitializedDelegate(byte b)
        {
            // Make sure it's initialized
            if (CommandInitialized(b))
            {
                // Return the delegate
                return InitializedDelegates[b];
            }
            // Not initialized, throw exception
            throw new ArgumentException("Command " + b.ToString() + " not initialized");
        }

        // Update Position Delegate
        public delegate void UpdatePositionDelegate(List<object> parameters);
        // Position update callable member
        private static UpdatePositionDelegate UpdatePosition;
        // Set position update
        public static void SetUpdatePositionDelagate(UpdatePositionDelegate up)
        {
            UpdatePosition = up;
            //InitializedDelegates.Add((byte)0x01);
            InitializedDelegates.Add((byte)0x01, UpdatePosition);
        }

        // Spanw Monster Delegate
        public delegate void SpawnMonsterDelegate(List<object> parameters);
        // Spawn Monster callable member
        private static SpawnMonsterDelegate SpawnMonster;
        // Set Monster spawn
        public static void SetSpawnMonsterDelegate(SpawnMonsterDelegate sm)
        {
            SpawnMonster = sm;
            InitializedDelegates.Add((byte)0x02, SpawnMonster);
        }
    }
}
