using System;
using System.Windows.Forms;
using System.Drawing;

namespace PROGPOEP2
{
    public partial class Form1 : Form
    {
        private Chatbot chatbot;

        public Form1()
        {
            InitializeComponent();

            // Picture
            PictureBox pic = new PictureBox();

             

            pic.SizeMode = PictureBoxSizeMode.StretchImage;

            pic.Width = 200;
            pic.Height = 200;

            pic.Left = 20;
            pic.Top = 20;

            this.Controls.Add(pic);

            // Form background
            this.BackColor = Color.FromArgb(18, 18, 18);

            // Chat area
            rtbChat.BackColor = Color.FromArgb(37, 37, 38);
            rtbChat.ForeColor = Color.White;
            rtbChat.BorderStyle = BorderStyle.None;
            rtbChat.Font = new Font("Segoe UI", 11);

            // Input box
            txtInput.BackColor = Color.FromArgb(50, 50, 50);
            txtInput.ForeColor = Color.White;
            txtInput.BorderStyle = BorderStyle.FixedSingle;
            txtInput.Font = new Font("Segoe UI", 10);

            // Send button
            btnSend.BackColor = Color.Green;
            btnSend.ForeColor = Color.White;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btnSend.Text = "➤";

            // Voice button
            btnVoice.BackColor = Color.DarkSlateGray;
            btnVoice.ForeColor = Color.White;
            btnVoice.FlatStyle = FlatStyle.Flat;
            btnVoice.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            chatbot = new Chatbot();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string userInput = txtInput.Text;

            rtbChat.SelectionAlignment = HorizontalAlignment.Right;
            rtbChat.SelectionBackColor = Color.DarkGreen;
            rtbChat.AppendText("You: " + userInput + Environment.NewLine);

            string response = chatbot.GetResponse(userInput);

            rtbChat.SelectionAlignment = HorizontalAlignment.Left;
            rtbChat.SelectionBackColor = Color.DimGray;
            rtbChat.AppendText("Bot: " + response + Environment.NewLine + Environment.NewLine);

            txtInput.Clear();
        }

        private void btnVoice_Click(object sender, EventArgs e)
        {
            chatbot.SpeakLastResponse();
        }
    }
}


