using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EasyOp
{
    internal static class Operations
    {
        public const int defaultWaitTime = 500;

        private static IDictionary<Oprands, Action<object, object>> OpActionTable { get; } = new Dictionary<Oprands, Action<object, object>>();

        internal static Action<object, object> GetAction(Oprands oprand)
        {
            return OpActionTable.ContainsKey(oprand) ? OpActionTable[oprand] : CreateOp(oprand);
        }

        private static Action<object, object> CreateOp(Oprands oprand)
        {
            Action<object, object> action = null;
            switch (oprand)
            {
                case Oprands.ButtonClick:
                    action = (control, _) => (control as Button).PerformClick();
                    break;
                case Oprands.ToolStripMenuItemClick:
                    action = (control, _) => (control as ToolStripMenuItem).PerformClick();
                    break;
                case Oprands.RadioButtonClick:
                    action = (control, _) => (control as RadioButton).PerformClick();
                    break;
                case Oprands.TextBoxSetText:
                    action = (control, parameter) => (control as TextBox).Text = (string)parameter;
                    break;
                case Oprands.CheckBoxCheck:
                    action = (control, parameter) => (control as CheckBox).Checked = (bool)parameter;
                    break;
                case Oprands.ComboBoxSelectItem:
                    action = (control, parameter) => (control as ComboBox).SelectedItem = parameter;
                    break;
                case Oprands.ComboBoxSelectIndex:
                    action = (control, parameter) => (control as ComboBox).SelectedIndex = (int)parameter;
                    break;
                default:
                    throw new NotImplementedException("Operation not implemented");
            }
            OpActionTable[oprand] = action;
            return action;
        }

        private static IDictionary<Type, HashSet<Oprands>> TypeOpsTable { get; } = new Dictionary<Type, HashSet<Oprands>>();

        internal static HashSet<Oprands> GetOps(Type type)
        {
            return TypeOpsTable.ContainsKey(type) ? TypeOpsTable[type] : Operations.CreateOps(type);
        }

        private static HashSet<Oprands> CreateOps(Type type)
        {
            HashSet<Oprands> set = new HashSet<Oprands>();
            if (type == typeof(Button))
            {
                set.Add(Oprands.ButtonClick);
            }
            else if (type == typeof(ToolStripMenuItem))
            {
                set.Add(Oprands.ToolStripMenuItemClick);
            }
            else if (type == typeof(RadioButton))
            {
                set.Add(Oprands.RadioButtonClick);
            }
            else if (type == typeof(TextBox))
            {
                set.Add(Oprands.TextBoxSetText);
            }
            else if (type == typeof(ComboBox))
            {
                set.Add(Oprands.ComboBoxSelectItem);
                set.Add(Oprands.ComboBoxSelectIndex);
            }
            else if (type == typeof(CheckBox))
            {
                set.Add(Oprands.CheckBoxCheck);
            }
            TypeOpsTable[type] = set;
            return set;
        }
    }
}
