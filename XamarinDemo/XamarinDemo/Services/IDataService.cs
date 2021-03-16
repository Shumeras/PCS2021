using System;
using System.Collections.Generic;
using System.Text;
using XamarinDemo.Models;

namespace XamarinDemo.Services
{
    public interface IDataService
    {
        IList<Preset> GetPresets();

        void AddPreset(Preset preset);
        void DeletePreset(Preset preset); //GUID
        void UpdatePreset(Preset preset);



    }
}
