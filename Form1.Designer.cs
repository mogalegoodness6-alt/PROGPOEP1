using System;
using System.Windows.Forms;

namespace PROGPOEP2
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            rtbChat = new RichTextBox();
            txtInput = new TextBox();
            btnSend = new Button();
            btnVoice = new Button();
            SuspendLayout();
             
            rtbChat.Location = new Point(52, 29);
            rtbChat.Name = "rtbChat";
            rtbChat.Size = new Size(697, 309);
            rtbChat.TabIndex = 0;
            rtbChat.Text = "";
             
            txtInput.Location = new Point(52, 375);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(300, 27);
            txtInput.TabIndex = 1;
             
            btnSend.Location = new Point(441, 378);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 40);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
             
            btnVoice.Location = new Point(567, 378);
            btnVoice.Name = "btnVoice";
            btnVoice.Size = new Size(94, 40);
            btnVoice.TabIndex = 3;
            btnVoice.Text = "Voice";
            btnVoice.UseVisualStyleBackColor = true;
            btnVoice.Click += btnVoice_Click;
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbChat);
            Controls.Add(txtInput);
            Controls.Add(btnSend);
            Controls.Add(btnVoice);
            Name = "Form1";
            Text = "Cybersecurity Chatbot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbChat;
        private TextBox txtInput;
        private Button btnSend;
        private Button btnVoice;
    }
}