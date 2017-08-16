namespace _01Iterator.Abstract
{
    internal interface IIterator
    {
        bool HasNext();

        object Next();
    }
}