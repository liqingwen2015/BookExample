namespace _20观察者模式.Observer
{
    internal abstract class BaseObserver
    {
        protected Subject Subject;

        //protected BaseObserver(Subject subject)
        //{
        //    Subject = subject;
        //}

        public abstract void Update(int state);
    }
}