using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFirMidNotes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void WaveCalculationIsCorrect_A()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act
            
            var result = notes.WaveFormer(notes.A);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 440.00f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_Af()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.A_S);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 466.16f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_B()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.B);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 493.88f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_C()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.C);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 261.63f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_Cf()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.C_S);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 277.18f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_D()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.D);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 293.66f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_Df()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.D_S);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 311.13f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_E()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.E);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 329.63f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_F()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.F);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 349.23f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_Ff()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.F_S);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 369.99f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_G()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.G);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 392.00f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
        [TestMethod]
        public void WaveCalculationIsCorrect_Gf()
        {
            //Arange

            var notes = new MidNotes.MidNotes();
            //Act

            var result = notes.WaveFormer(notes.G_S);

            const int SampleRate = 44100;
            const short BitsPerSample = 16;

            short[] Testwave = new short[SampleRate];
            byte[] bynaryWave = new byte[SampleRate * sizeof(short)];
            float frequency = 415.30f;

            for (int i = 0; i < SampleRate; i++)
            {
                Testwave[i] = Convert.ToInt16(short.MaxValue * Math.Sin(((Math.PI * 2 * frequency) / SampleRate) * i));
            }

            //Assert
            Assert.IsTrue(Enumerable.SequenceEqual<short>(result, Testwave));
        }
    }
}
