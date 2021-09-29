// Created by Andrew McLane
// 10thmagicbridge@gmail.com
using System;
namespace Commands
{
    public class SimpleCommand: ICommand
    {

        private string _payload = string.Empty;

        public SimpleCommand(string payload)
        {
            this._payload = payload;
        }

        public virtual void Execute()
        {
            Console.WriteLine($"SimpleCommand: See, I can do simple things, like printing this ({this._payload}) the console.");
        }
    }
}
 