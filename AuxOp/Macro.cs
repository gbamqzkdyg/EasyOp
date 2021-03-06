using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EasyOp
{
    public class Macro
    {
        [JsonProperty]
        public string Name { get; }

        [JsonProperty]
        public HashSet<string> OpNames { get; } = new HashSet<string>();

        [JsonProperty]
        public List<Operation> Ops { get; }

        public void Add(string operationName, Oprands oprand, string controlName, object parameter, int waitTime = Operations.defaultWaitTime)
        {
            this.Add(new Operation(operationName, controlName, parameter, oprand, waitTime));
        }

        public Macro(string name)
        {
            this.Name = name;
            this.Ops = new List<Operation>();
            Ops.Add(new Operation("NoOp", "N/A", "N/A", Oprands.NoOp, 0));
        }

        public void Add(Operation op)
        {
            if (OpNames.Contains(op.OperationName)) throw new InvalidOperationException("Operation name already exists");
            this.Ops.Add(op);
            this.OpNames.Add(op.OperationName);
        }

        public Operation Delete(string operationName)
        {
            if (!OpNames.Remove(operationName)) throw new KeyNotFoundException("Operation name not exists");
            Operation op = this.GetOperation(operationName);
            Ops.Remove(op);
            return op;
        }

        public void Clear()
        {
            this.OpNames.Clear();
            this.Ops.Clear();
        }

        public void Perform()
        {
            foreach (var op in Ops) op.Perform();
        }

        public Operation GetOperation(string operationName)
        {
            return Ops.Find(o => o.OperationName == operationName);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
