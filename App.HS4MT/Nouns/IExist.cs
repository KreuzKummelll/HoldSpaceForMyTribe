// Created by Andrew McLane
// 10thmagicbridge@gmail.com
using System;
namespace Nouns
{
    public interface IExist<T>
    {
        string i_Properties { get; }

        T CastAsSelf();
    }
}
