using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Events
{
    public class IntegrationEvent
    {
        [JsonProperty]
        public Guid Id { get; private set; }

        [JsonProperty]
        public DateTime CreateDate { get; private set; }

        public IntegrationEvent()
        {

        }

        [JsonConstructor]
        public IntegrationEvent(Guid id
            , DateTime createDate)
        {
            Id = id;
            CreateDate = createDate;
        }
    }
}
