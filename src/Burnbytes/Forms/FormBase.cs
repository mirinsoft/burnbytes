﻿using System;
using System.Windows.Forms;

namespace Burnbytes
{
    public partial class FormBase : Form
    {
        // Events

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);

            Application.Idle -= Application_Idle;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            OnLocalize();
        }

        // Concstructors

        public FormBase() => Application.Idle += Application_Idle;

        public FormBase(Form owner) : this() => Owner = owner;

        // Methods

        protected virtual void OnLocalize() => Text = Application.ProductName;

        protected virtual void OnApplicationIdle() { }

        // EventHandlers

        private void Application_Idle(object sender, EventArgs e) => OnApplicationIdle();
    }
}
