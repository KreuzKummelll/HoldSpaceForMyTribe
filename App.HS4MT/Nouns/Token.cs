// Created by Andrew McLane
// 10thmagicbridge@gmail.com
using System;
using System.Collections.Generic;
using Commands;
using Newtonsoft.Json;

namespace Nouns
{
    public abstract class Token: IExist<Token>, IReceive
    {
        public string i_Properties { get; private set; } = String.Empty;
        private Dictionary<string, object> i_dictionary { get; } = new Dictionary<string, object>();

        public Token(string propertiesJson)
        {
            this.i_Properties = propertiesJson;

        }


        public Token CastAsSelf()
        {
            this.i_Properties = $@"{this.i_Properties}";
            Token token = JsonConvert.DeserializeObject<Token>(this.i_Properties);
            return token;
        }

        public abstract void Receive(object a);
        public abstract void React(object a);
    }
}
