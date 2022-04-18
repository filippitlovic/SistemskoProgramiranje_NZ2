
namespace SistemskoProgramiranjeNZ2
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
            this.btn_word = new System.Windows.Forms.Button();
            this.btn_tskMngr = new System.Windows.Forms.Button();
            this.btn_notepad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_word
            // 
            this.btn_word.Location = new System.Drawing.Point(213, 161);
            this.btn_word.Name = "btn_word";
            this.btn_word.Size = new System.Drawing.Size(75, 23);
            this.btn_word.TabIndex = 0;
            this.btn_word.Text = "Word";
            this.btn_word.UseVisualStyleBackColor = true;
            this.btn_word.Click += new System.EventHandler(this.btn_word_Click);
            // 
            // btn_tskMngr
            // 
            this.btn_tskMngr.Location = new System.Drawing.Point(325, 160);
            this.btn_tskMngr.Name = "btn_tskMngr";
            this.btn_tskMngr.Size = new System.Drawing.Size(111, 23);
            this.btn_tskMngr.TabIndex = 1;
            this.btn_tskMngr.Text = "TaskManager";
            this.btn_tskMngr.UseVisualStyleBackColor = true;
            this.btn_tskMngr.Click += new System.EventHandler(this.btn_tskMngr_Click);
            // 
            // btn_notepad
            // 
            this.btn_notepad.Location = new System.Drawing.Point(461, 160);
            this.btn_notepad.Name = "btn_notepad";
            this.btn_notepad.Size = new System.Drawing.Size(75, 23);
            this.btn_notepad.TabIndex = 2;
            this.btn_notepad.Text = "Notepad";
            this.btn_notepad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_notepad.UseVisualStyleBackColor = true;
            this.btn_notepad.Click += new System.EventHandler(this.btn_notepad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_notepad);
            this.Controls.Add(this.btn_tskMngr);
            this.Controls.Add(this.btn_word);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_word;
        private System.Windows.Forms.Button btn_tskMngr;
        private System.Windows.Forms.Button btn_notepad;
    }
}

