namespace OldPhone
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblOutput = new Label();
            txtInput = new TextBox();
            btnProcess = new Button();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Location = new Point(29, 9);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(328, 54);
            lblOutput.TabIndex = 2;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(29, 70);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(328, 27);
            txtInput.TabIndex = 13;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(29, 103);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(94, 29);
            btnProcess.TabIndex = 14;
            btnProcess.Text = "Process";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 340);
            Controls.Add(btnProcess);
            Controls.Add(txtInput);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Old Phone";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnProcess;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
    }
}
