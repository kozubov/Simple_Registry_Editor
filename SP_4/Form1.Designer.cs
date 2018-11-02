namespace SP_4
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
            this.listBox_AutoRun = new System.Windows.Forms.ListBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_AutoRun
            // 
            this.listBox_AutoRun.BackColor = System.Drawing.SystemColors.Control;
            this.listBox_AutoRun.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox_AutoRun.FormattingEnabled = true;
            this.listBox_AutoRun.ItemHeight = 19;
            this.listBox_AutoRun.Location = new System.Drawing.Point(11, 35);
            this.listBox_AutoRun.Name = "listBox_AutoRun";
            this.listBox_AutoRun.Size = new System.Drawing.Size(168, 308);
            this.listBox_AutoRun.TabIndex = 0;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button_Add.Location = new System.Drawing.Point(200, 211);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(170, 55);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Add Prog to AutoRun";
            this.button_Add.UseVisualStyleBackColor = true;
            // 
            // button_Remove
            // 
            this.button_Remove.Font = new System.Drawing.Font("Tahoma", 10F);
            this.button_Remove.Location = new System.Drawing.Point(200, 281);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(170, 55);
            this.button_Remove.TabIndex = 3;
            this.button_Remove.Text = "Remove Prog from AutoRun";
            this.button_Remove.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Programms in AutoRun";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listBox_AutoRun);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoRun Registry Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_AutoRun;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
    }
}

