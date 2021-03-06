﻿namespace Game
{
    partial class GameForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.GameTick = new System.Windows.Forms.Timer(this.components);
            this.Render = new System.Windows.Forms.Timer(this.components);
            this.Collision = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GameTick
            // 
            this.GameTick.Interval = 1;
            this.GameTick.Tick += new System.EventHandler(this.GameTick_Tick);
            // 
            // Render
            // 
            this.Render.Interval = 1;
            this.Render.Tick += new System.EventHandler(this.Render_Tick);
            // 
            // Collision
            // 
            this.Collision.Interval = 1;
            this.Collision.Tick += new System.EventHandler(this.Collision_Tick);
            // 
            // GameForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.DoubleBuffered = true;
            this.Name = "GameForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameFrm_keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameFrm_keyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer GameTick;
        private System.Windows.Forms.Timer Render;
        private System.Windows.Forms.Timer Collision;
    }
}

