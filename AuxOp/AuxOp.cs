using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace EasyOp
{
    public static class AuxOp
    {
        public static class ControlsManager
        {
            internal enum RegistrationState
            {
                NotRegistered,
                Registering,
                Registered,
            }

            internal static RegistrationState state = RegistrationState.NotRegistered;

            internal static IDictionary<string, object> Controls { get; } = new Dictionary<string, object>();

            public static void BeginRegisterControls()
            {
                state = RegistrationState.Registering;
            }

            public static void EndRegisterControls()
            {
                state = RegistrationState.Registered;
            }

            public static void RegisterControl(string controlName, object control)
            {
                if (state != RegistrationState.Registering) throw new InvalidOperationException("Control registration not begins");
                Controls[controlName] = control;
            }

            public static bool RegistrationFinished()
            {
                return state == RegistrationState.Registered;
            }
        }

        public static string Version { get; } = "0.0.1";

        private static string macroFileName = null;

        private static readonly JsonSerializer js = new JsonSerializer();

        private static MacroCollection macros;

        public static MacroCollection Macros
        {
            get
            {
                return AuxOp.ControlsManager.RegistrationFinished() ? macros : throw new InvalidOperationException("Control registration not finished");
            }
        }

        public static void CreateMacros()
        {
            macros = new MacroCollection();
        }

        public static void LoadMacrosFromFile(string fileName)
        {
            macroFileName = fileName;
            using (JsonTextReader jr = new JsonTextReader(new StreamReader(fileName)))
            {
                macros = js.Deserialize<MacroCollection>(jr);
            }
        }

        public static void SaveMacrosToFile()
        {
            if (macroFileName == null) throw new InvalidOperationException("No default file name");
            SaveMacrosToFile(macroFileName);
        }

        public static void SaveMacrosToFile(string fileName)
        {
            using (JsonTextWriter jw = new JsonTextWriter(new StreamWriter(fileName)))
            {
                js.Serialize(jw, macros);
            }
        }

        public static void OpenForm()
        {
            new AuxOpForm().Show();
        }
    }
}
