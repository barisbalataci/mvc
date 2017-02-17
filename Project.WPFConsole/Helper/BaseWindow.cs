using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Project.WPFConsole.Helper
{
    class BaseWindow:Window
    {
        protected void RunValidatableCode(Action action)
        {
            string message = "";
            try
            {
                action.Invoke();
            }
            catch (ValidationException exception)
            {
                foreach (var validationFailure in exception.Errors)
                {
                    message += validationFailure.ErrorMessage + "[" + validationFailure.AttemptedValue + "]" + "\n";
                }
                MessageBox.Show(message);
            }
        }
    }
}
