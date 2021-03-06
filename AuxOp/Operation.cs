using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Threading;

namespace EasyOp
{
    public class Operation
    {
        [JsonProperty]
        public string OperationName { get; }

        [JsonProperty]
        public string ControlName { get; }

        [JsonProperty]
        public object Parameter { get; }

        [JsonProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        public Oprands Oprand { get; }

        [JsonProperty]
        public int WaitTime { get; set; }

        public Operation(string operationName, string controlName, object parameter, Oprands oprand, int waitTime = Operations.defaultWaitTime)
        {
            this.OperationName = operationName;
            this.ControlName = controlName;
            this.Parameter = parameter;
            this.Oprand = oprand;
            this.WaitTime = waitTime;
        }

        public void Perform()
        {
            Operations.GetAction(Oprand)(AuxOp.ControlsManager.Controls[ControlName], Parameter);
            Thread.Sleep(WaitTime);
        }
    }
}
