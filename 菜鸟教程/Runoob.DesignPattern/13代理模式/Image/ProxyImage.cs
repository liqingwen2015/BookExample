namespace _13代理模式.Image
{
    internal class ProxyImage : IImage
    {
        private readonly RealImage _realImage;

        public ProxyImage(string fileName)
        {
            _realImage = new RealImage(fileName);
        }

        public void Display()
        {
            _realImage.Display();
        }
    }
}