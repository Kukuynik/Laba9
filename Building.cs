using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba9
{
    public class Building
    {
        private static int numberStatic = 1; 
        private int _number; 
        private double _height; 
        private int _levelsCount;
        private int _apartmentsCount; 
        private int _entryCount; 
        

        public Building()
        {
            _number = numberStatic;
            NumberIncrement();
        }
        public Building(double height, int levelsCount,int apartmentCount,int entryCount )
        {
            _number = numberStatic;
            _height = height;
            _levelsCount = levelsCount;
            _apartmentsCount = apartmentCount;
            _entryCount = entryCount;
            NumberIncrement();
        }

        private static void NumberIncrement() 
        {
            numberStatic += 1;
        }

        public void setHeight(double height)
        {
            if (height > 0)
                _height = height;
        }

        public void setLevelsCount(int Count)
        {
            if (Count > 0)
                _levelsCount = Count;
        }

        public void setApartmentsCount(int Count)
        {
            if (Count > 0)
                _apartmentsCount = Count;
        }

        public void setEntryCount(int Count)
        {
            if (Count > 0)
                _entryCount = Count;
        }

        public int GetNumber()
        {
            return _number;
        }
        public double GetHeight()
        {
            return _height;
        }
        public int GetLevelsCount()
        {
            return _levelsCount;
        }
        public int GetApartmentsCount()
        {
            return _apartmentsCount;
        }

        public int GetEntryCount()
        {
            return _entryCount;
        }

        public double LevelsHeight() 
        {
            return _height / _levelsCount;
        }

        public double ApartmentsInLevel() 
        {
            return _apartmentsCount / _levelsCount;
        }

        public double ApartmensInEntry() 
        {
            return _apartmentsCount / _entryCount;
        }
    }
}
