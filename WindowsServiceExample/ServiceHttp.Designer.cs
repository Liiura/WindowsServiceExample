﻿
namespace WindowsServiceExample
{
    partial class ServiceHttp
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.executingTimer = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.executingTimer)).BeginInit();
            // 
            // executingTimer
            // 
            this.executingTimer.Enabled = true;
            this.executingTimer.Interval = 120000D;
            this.executingTimer.Elapsed += new System.Timers.ElapsedEventHandler(this.executingTimer_ElapsedAsync);
            // 
            // ServiceHttp
            // 
            this.ServiceName = "Service1";
            ((System.ComponentModel.ISupportInitialize)(this.executingTimer)).EndInit();

        }

        #endregion

        private System.Timers.Timer executingTimer;
    }
}
