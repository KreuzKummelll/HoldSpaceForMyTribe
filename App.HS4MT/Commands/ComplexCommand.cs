// Created by Andrew McLane
// 10thmagicbridge@gmail.com
using System;
namespace Commands
{
    public class ComplexCommand : ICommand
    {

        private IReceive _receiver;

        // Context Data that is unique to each command.

        private string _a;
        private string _b;

        public ComplexCommand(IReceive reciever, string a, string b)
        {
            this._receiver = reciever;
            this._a = a;
            this._b = b;
        }

        public void Execute()
        {
            Console.WriteLine("Complex Command: Complex stuff should be done by a receiver object.");

            this._receiver.React(this._a);
        }


    }


    
}
