using Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPublisher
{
    public class CloudMessage : ICloudMessage
    {
        public string InstanceId { get; set; }
    }
}