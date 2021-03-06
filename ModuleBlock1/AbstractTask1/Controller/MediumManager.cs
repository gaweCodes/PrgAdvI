﻿using System.Collections.Generic;
using System.Linq;
using AbstractTask1.Model;

namespace AbstractTask1.Controller
{
    public class MediumManager
    {
        private readonly List<Medium> _mediumList;
        public MediumManager()
        {
            _mediumList = new List<Medium>();
        }
        public void AddMedium(Medium medium)
        {
            _mediumList.Add(medium);
        }
        public object[] GetAllCompactDiscs()
        {
            var allCds = _mediumList.Where(c => c is Cd).ToList();
            var data = new object[allCds.Count];
            for (var index = 0; index < allCds.Count; index++)
                data[index] = allCds[index].Print();
            return data;
        }
        public object[] GetAllDigitalVideoDiscs()
        {
            var allDvd = _mediumList.Where(d => d is Dvd).ToList();
            var data = new object[allDvd.Count];
            for (var index = 0; index < allDvd.Count; index++)
                    data[index] = allDvd[index].Print();
            return data;
        }
    }
}
