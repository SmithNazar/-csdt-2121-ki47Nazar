using Melanchall.DryWetMidi.Multimedia;
using System;

namespace MIDIDID
{
    public class ProgramMidid
    {
        private static IInputDevice _inputDevice;

        public string noteOnHold { get; set; }

        public void StartListeting()
        {
            _inputDevice = InputDevice.GetByIndex(0);
            _inputDevice.EventReceived += OnEventReceived;
            _inputDevice.StartEventsListening();
            
            (_inputDevice as IDisposable)?.Dispose();
        }

        public void OnEventReceived(object sender, MidiEventReceivedEventArgs e)
        {
            var midiDevice = (MidiDevice)sender;
            noteOnHold = e.Event.ToString();
            //Console.WriteLine($"Event received from '{midiDevice.Name}' at {DateTime.Now}: {e.Event}");
        }
    }
}
