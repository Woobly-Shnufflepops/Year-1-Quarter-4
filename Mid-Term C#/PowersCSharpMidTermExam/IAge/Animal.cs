using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAgeSpace
{
    // Question 14
    public class Animal:IAnimal
    {
        private string _imageFilename;
        private string _voiceFilename;
        private int _id;

        public string imageFileName { get { return _imageFilename; } }
        public string voiceFileName { get { return _voiceFilename; } }
        public int id { get { return _id; } }

        public void Voice()
        {
            
        }

        public void Draw()
        {

        }

        public Animal(string ImageFileName, string VoiceFileName, int ID)
        {
            _imageFilename = ImageFileName;
            _voiceFilename = VoiceFileName;
            _id = ID;
        }
    }
}
