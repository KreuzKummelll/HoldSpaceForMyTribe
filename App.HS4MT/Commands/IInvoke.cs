// Created by Andrew McLane
// 10thmagicbridge@gmail.com
using System;
using System.Collections.Generic;

namespace Commands
{

    /// <summary>
    /// Invoker sends request to one or many commands it is associated with
    /// </summary>
    public interface IInvoke
    {

         ICommand _onStart { get; }
        ICommand _onFinish { get; }

        Dictionary<string, ICommand> iCommands { get; }


        public void SetOnStart(ICommand command);
        //{
        //    this._onStart = command;
        //}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="command"></param>
        public void SetOnFinish(ICommand command);
        //{
        //    this._onFinish = command;
        //}

        public void SetCommand(string name, ICommand command);


        ///<summary>
        /// The Invoker does not depend on concrete command or receiver classes.
        /// The Invoker passes a request to a receiver indirectly, by executing a
        /// command.
        /// </summary>
        public void DoSomethingImportant();
        //{
        //    Console.WriteLine("Invoker: Does anybody want something done before I begin?");
        //    if (this._onStart is ICommand)
        //    {
        //        this._onStart.Execute();
        //    }

        //    Console.WriteLine("Invoker: ...Doing something really important");

        //    Console.WriteLine("Invoker: Does anybody want something done after I finish?");

        //    if (this._onFinish is ICommand)
        //    {
        //        this._onFinish.Execute();
        //    }
        //}
    }
}
