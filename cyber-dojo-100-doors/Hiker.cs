using System;
using System.Collections.Generic;
using System.Linq;

namespace cyber_dojo_100_doors
{
    public class Hiker
    {
        private List<Door> _doors;

        public Hiker(int numberOfDoors)
        {
            _doors = new List<Door>(numberOfDoors);
            for (int i = 1; i <= numberOfDoors; i++)
            {
                var door = new Door()
                {
                    Position = i,
                    State = DoorState.Closed
                };
                _doors.Add(door);
            }
        }

        public DoorsState Answer(int numberOfIterations)
        {
            int numberOfDoorsClosed = _doors.Count;
            int numberOfDoorsOpened = 0;
            for (int iteration = 1; iteration <= numberOfIterations; iteration++)
            {
                for (int position = iteration; position <= _doors.Count; position++)
                {
                    if (position % iteration == 0)
                    {
                        var door = _doors[position - 1];
                        if (door.State.Equals(DoorState.Closed))
                        {
                            door.State = DoorState.Opened;
                            numberOfDoorsOpened++;
                            numberOfDoorsClosed--;
                        }
                        else
                        {
                            door.State = DoorState.Closed;
                            numberOfDoorsOpened--;
                            numberOfDoorsClosed++;
                        }
                    }
                }
            }
            var result = new DoorsState()
            {
                Closed = numberOfDoorsClosed,
                Opened = numberOfDoorsOpened
            };

            return result;
        }
    }

    public class DoorsState
    {
        public int Closed { get; set; }
        public int Opened { get; set; }
    }

    public class Door
    {
        public int Position { get; set; }
        public DoorState State { get; set; }
    }

    public enum DoorState
    {
        Closed = 0,
        Opened = 1
    }
}
