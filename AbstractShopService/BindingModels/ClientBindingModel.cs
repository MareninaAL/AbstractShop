﻿using System.Runtime.Serialization;

namespace AbstractShopService.BindingModels
{
    [DataContract]
    public class ClientBindingModel
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string ClientFIO { get; set; }
    }
}
