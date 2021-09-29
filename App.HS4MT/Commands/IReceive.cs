// Created by Andrew McLane
// 10thmagicbridge@gmail.com
using System;
namespace Commands
{

    public interface IReceive
    {
        public abstract void Receive(object a);
        public abstract void React(object a);
    }
}
