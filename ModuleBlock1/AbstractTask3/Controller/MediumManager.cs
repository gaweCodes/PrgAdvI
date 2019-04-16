using System.Collections.Generic;
using System.Linq;
using AbstractTask3.Model;

namespace AbstractTask3.Controller
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
        public object[] GetAllMedia()
        {
            var data = new object[_mediumList.Count];
            for (var index = 0; index < _mediumList.Count; index++)
                data[index] = _mediumList[index].Print();
            return data;
        }
        public object[] GetAllCompactDiscs()
        {
            var allCds = _mediumList.Where(c => c is Cd).ToList();
            var data = new object[allCds.Count];
            for (var index = 0; index < allCds.Count; index++)
                data[index] = ((Cd)allCds[index]).Print();
            return data;
        }
        public object[] GetAllDigitalVideoDiscs()
        {
            var allDvd = _mediumList.Where(d => d is Dvd).ToList();
            var data = new object[allDvd.Count];
            for (var index = 0; index < allDvd.Count; index++)
                    data[index] = ((Dvd)allDvd[index]).Print();
            return data;
        }
    }
}
