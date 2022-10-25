using SafeGameWinForms.Properties;
using System.Drawing;
using System.Windows.Forms;


namespace SafeGameWinForms
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOfWin = new System.Windows.Forms.Label();
            this.button29 = new System.Windows.Forms.Button();
            this.buttonHard = new System.Windows.Forms.Button();
            this.buttonMedium = new System.Windows.Forms.Button();
            this.buttonEasy = new System.Windows.Forms.Button();
            this.panel1.Controls.Add(this.labelOfWin);
            arrButtons = new Button[5, 5];
            int cellCounter = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    cellCounter++;
                    arrButtons[i, j] = new Button();
                    arrButtons[i, j].Top = j * 75 + 10;
                    arrButtons[i, j].Left = i * 75 + 190;
                    arrButtons[i, j].BackColor = Color.Red;
                    arrButtons[i, j].Image = Resources.boneSmallHorizontal;
                    arrButtons[i, j].Size = new Size(75, 75);
                    arrButtons[i, j].Click += ButtonAction_OnClick;
                    arrButtons[i, j].Tag = cellCounter;
                    this.panel1.Controls.Add(arrButtons[i, j]);
                }
            }
                this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SafeGameWinForms.Properties.Resources.background;
            this.panel1.Controls.Add(this.button29);
            this.panel1.Controls.Add(this.buttonHard);
            this.panel1.Controls.Add(this.buttonMedium);
            this.panel1.Controls.Add(this.buttonEasy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 394);
            this.panel1.TabIndex = 0;
            // 
            // labelOfWin
            // 
            this.labelOfWin.BackColor = System.Drawing.Color.Transparent;
            this.labelOfWin.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOfWin.ForeColor = System.Drawing.Color.Black;
            this.labelOfWin.Location = new System.Drawing.Point(190, 0);
            this.labelOfWin.Name = "labelOfWin";
            this.labelOfWin.Size = new System.Drawing.Size(378, 407);
            this.labelOfWin.TabIndex = 29;
            this.labelOfWin.Text = "SAFE IS OPEN!\r\nPRESS \"SHAKE\" \r\nTO PLAY AGAIN.\r\n";
            this.labelOfWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;            
            // 
            // button29
            // 
            this.button29.BackColor = System.Drawing.Color.Black;
            this.button29.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button29.ForeColor = System.Drawing.Color.White;
            this.button29.Location = new System.Drawing.Point(12, 164);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(171, 79);
            this.button29.TabIndex = 28;
            this.button29.Text = "SHAKE!";
            this.button29.UseVisualStyleBackColor = false;
            this.button29.Click += new System.EventHandler(this.ButtonShake_Click);
            // 
            // buttonHard
            // 
            this.buttonHard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonHard.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHard.Location = new System.Drawing.Point(573, 242);
            this.buttonHard.Name = "buttonHard";
            this.buttonHard.Size = new System.Drawing.Size(158, 60);
            this.buttonHard.TabIndex = 27;
            this.buttonHard.Text = "HARD";
            this.buttonHard.UseVisualStyleBackColor = false;
            // 
            // buttonMedium
            // 
            this.buttonMedium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonMedium.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMedium.Location = new System.Drawing.Point(573, 171);
            this.buttonMedium.Name = "buttonMedium";
            this.buttonMedium.Size = new System.Drawing.Size(158, 60);
            this.buttonMedium.TabIndex = 26;
            this.buttonMedium.Text = "MEDIUM";
            this.buttonMedium.UseVisualStyleBackColor = false;
            // 
            // buttonEasy
            // 
            this.buttonEasy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEasy.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEasy.Location = new System.Drawing.Point(573, 100);
            this.buttonEasy.Name = "buttonEasy";
            this.buttonEasy.Size = new System.Drawing.Size(158, 60);
            this.buttonEasy.TabIndex = 25;
            this.buttonEasy.Text = "EASY";
            this.buttonEasy.UseVisualStyleBackColor = false;
          
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 394);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonHard;
        private System.Windows.Forms.Button buttonMedium;
        private System.Windows.Forms.Button buttonEasy;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Label labelOfWin;
    }
}
