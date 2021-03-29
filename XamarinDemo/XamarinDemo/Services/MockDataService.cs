using System;
using System.Collections.Generic;
using System.Text;
using XamarinDemo.Models;

namespace XamarinDemo.Services
{
    public class MockDataService : IDataService
    {
        private static List<Preset> presets = new List<Preset>{
            new Preset(){
                Name = "Work out",
                Intervals = new List<Interval>{
                    new Interval { Name = "Warm Up", Duration = TimeSpan.FromSeconds(60)},
                    new Interval { Name = "Pushups", Duration = TimeSpan.FromSeconds(120)},
                    new Interval { Name = "Rest", Duration = TimeSpan.FromSeconds(20)},
                    new Interval { Name = "Crunches", Duration = TimeSpan.FromSeconds(120)},
                    new Interval { Name = "Rest", Duration = TimeSpan.FromSeconds(20)},
                    new Interval { Name = "Squats", Duration = TimeSpan.FromSeconds(90)},
                    new Interval { Name = "Cooldown", Duration = TimeSpan.FromSeconds(60)}
                }
            },
            new Preset(){
                Name = "Jogging",
                Intervals = new List<Interval>{
                    new Interval { Name = "Warm Up", Duration = TimeSpan.FromMinutes(5)},
                    new Interval { Name = "Run", Duration = TimeSpan.FromMinutes(15)},
                    new Interval { Name = "Rest", Duration = TimeSpan.FromMinutes(5)},
                    new Interval { Name = "Run", Duration = TimeSpan.FromMinutes(20)},
                    new Interval { Name = "Rest", Duration = TimeSpan.FromMinutes(5)},
                    new Interval { Name = "Run", Duration = TimeSpan.FromMinutes(15)},
                    new Interval { Name = "Cooldown", Duration = TimeSpan.FromMinutes(20)}
                }
            }

        };

        public event Action DataUpdateEvent = () => { };

        public IList<Preset> GetPresets()
        {
            return presets;
        }

        public void AddPreset(Preset preset)
        {
            presets.Add(preset);
            DataUpdateEvent();
        }

        public void DeletePreset(Preset preset)
        {
            presets.Remove(preset);
            DataUpdateEvent();
        }


        public void UpdatePreset(Preset preset)
        {
            // Doesn't have to do anything
            DataUpdateEvent();
        }
    }
}
