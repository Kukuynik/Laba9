using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    public class Building
    {
        static uint _counter = 1;
        
        uint _idBuilding;
        float _height;
        uint _floor;
        uint _flat;
        uint _entrance;
        float _floorHeight;
        uint _flatOnEntrance;
        uint _flatOnFloor;

        public void Add(float height, uint floor, uint flat, uint entrance)
        {
            _idBuilding = CounterPlus(_counter);
            _height = height;
            _floor = floor;
            _flat = flat;
            _entrance = entrance;
        }
        public void floorHeight()
        {
            _floorHeight = _height / _height;
        }
        public void flatOnEntrance()
        {
            _flatOnEntrance = _flat / _entrance;
        }
        public void flatOnFloor()
        {
            _flatOnFloor = _flatOnEntrance / _floor;
        }
        public uint CounterPlus(uint counter)
        {
            return counter++;
        }
    }
}
