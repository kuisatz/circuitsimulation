﻿using System;

namespace CircuitSimulation.UI.Commands
{
    public class EditPasteCommand : CommandBase
    {
        private readonly MainForm mainForm;

        public EditPasteCommand(MainForm mainForm)
        {
            this.mainForm = mainForm;
        }

        public override bool IsEnabled
        {
            get { return false; }
        }

        public override string HelpText
        {
            get { return "Paste selected element."; }
        }

        public override void Execute()
        {
        }
    }
}