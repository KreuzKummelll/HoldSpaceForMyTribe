// Created by Andrew McLane
// 10thmagicbridge@gmail.com
using System;


namespace Commands
{
    public abstract class Manipulator<T>: IReceive 
    {

        private T _objectA;

        
        public Manipulator(T objectToManipulate)
        {
            this._objectA = objectToManipulate;
        }

        public abstract void React(object a);
        public abstract void Receive(object a);
    }

    public abstract class DualManipulator<T,U>: IReceive
    {
        private T _objectA;
        private U _objectB;

        public   DualManipulator(T a, U b)
        {
            this._objectA = a;
            this._objectB = b;
        }

        public abstract void Receive(object payload);
        public abstract void React(object payload);
    }
    public abstract class TripleManipulator<T, U, V> : IReceive
    {
        private T _objectA;
        private U _objectB;
        private V _objectC;

        public TripleManipulator(T a, U b, V c)
        {
            this._objectA = a;
            this._objectB = b;
            this._objectC = c;
        }

        public abstract void Receive(object payload);
        public abstract void React(object payload);
    }
}
