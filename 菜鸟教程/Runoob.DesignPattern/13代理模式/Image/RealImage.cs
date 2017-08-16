#region

using System;

#endregion

namespace _13代理模式.Image
{
    internal class RealImage : IImage
    {
        public RealImage(string fileName)
        {
            FileName = fileName;
            LoadFromDisk(fileName);
        }

        public string FileName { get; set; }

        public void Display()
        {
            Console.WriteLine($"{nameof(Display)}: {FileName}");
        }

        private void LoadFromDisk(string fileName)
        {
            Console.WriteLine($"Loading: {fileName}");
        }
    }
}