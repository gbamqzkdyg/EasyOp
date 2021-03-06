using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace EasyOp
{
    public class MacroCollection
    {
        [JsonProperty]
        public readonly IDictionary<string, Macro> MacroTable = new Dictionary<string, Macro>();

        public Macro this[string macroName]
        {
            get => GetMacro(macroName);
        }

        private Macro GetMacro(string macroName)
        {
            if (!MacroTable.ContainsKey(macroName)) throw new KeyNotFoundException("Macro name not exists");
            return MacroTable[macroName];
        }

        public void CreateMacro(string name, bool overwrite = false)
        {
            if (MacroTable.ContainsKey(name))
            {
                if (!overwrite) throw new InvalidOperationException("Macro name already exists and not permitted to overwrite");
                else MacroTable[name].Clear();
            }
            else MacroTable[name] = new Macro(name);
        }

        public void ClearMacro(string name)
        {
            this.CreateMacro(name, true);
        }

        public void DeleteMacro(string name)
        {
            MacroTable.Remove(name);
        }
    }
}
