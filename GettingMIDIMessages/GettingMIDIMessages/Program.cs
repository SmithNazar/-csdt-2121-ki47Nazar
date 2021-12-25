using System;
using Melanchall;
using Melanchall.DryWetMidi.Multimedia;

namespace GettingMIDIMessages
{
    public class ProgramMidi
    {
        private static IInputDevice _inputDevice;

        static string noteOnHold;
        static string noteUnHold;

        static void Main(string[] args)
        {
            _inputDevice = InputDevice.GetByIndex(0);
            _inputDevice.EventReceived += OnEventReceived;
            _inputDevice.StartEventsListening();

            Console.WriteLine("Input device is listening for events. Press any key to exit...");
            Console.ReadKey();

            (_inputDevice as IDisposable)?.Dispose();
        }

        private static void OnEventReceived(object sender, MidiEventReceivedEventArgs e)
        {
            var midiDevice = (MidiDevice)sender;
            Console.WriteLine($"Event received from '{midiDevice.Name}' at {DateTime.Now}: {e.Event}");
            noteOnHold = e.Event.ToString();
            Console.WriteLine(noteOnHold);
        }
    }
}
