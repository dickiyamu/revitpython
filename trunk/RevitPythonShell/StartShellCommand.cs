﻿using Autodesk.Revit;

namespace RevitPythonShell
{
    /// <summary>
    /// An object of this class is instantiated every time the user clicks on the
    /// button for opening the shell.
    /// </summary>
    public class StartShellCommand: IExternalCommand
    {
        /// <summary>
        /// Open a window to let the user enter python code.
        /// </summary>
        /// <returns></returns>
        public IExternalCommand.Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {            
            var gui = new ScriptInput(commandData.Application);
            gui.Show();
            gui.BringToFront();
            return IExternalCommand.Result.Succeeded;
        }
    }
}
