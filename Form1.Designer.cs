namespace dinnerparty
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.CheckboxFancyDec = new System.Windows.Forms.CheckBox();
            this.healthyOption = new System.Windows.Forms.CheckBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(58, 47);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // CheckboxFancyDec
            // 
            this.CheckboxFancyDec.AutoSize = true;
            this.CheckboxFancyDec.Location = new System.Drawing.Point(58, 92);
            this.CheckboxFancyDec.Name = "CheckboxFancyDec";
            this.CheckboxFancyDec.Size = new System.Drawing.Size(115, 17);
            this.CheckboxFancyDec.TabIndex = 1;
            this.CheckboxFancyDec.Text = "Fancy Decorations";
            this.CheckboxFancyDec.UseVisualStyleBackColor = true;
            this.CheckboxFancyDec.CheckedChanged += new System.EventHandler(this.fancyDec_CheckedChanged);
            // 
            // healthyOption
            // 
            this.healthyOption.AutoSize = true;
            this.healthyOption.Location = new System.Drawing.Point(58, 125);
            this.healthyOption.Name = "healthyOption";
            this.healthyOption.Size = new System.Drawing.Size(96, 17);
            this.healthyOption.TabIndex = 2;
            this.healthyOption.Text = "Healthy Option";
            this.healthyOption.UseVisualStyleBackColor = true;
            this.healthyOption.CheckedChanged += new System.EventHandler(this.healthyOption_CheckedChanged);
            // 
            // costLabel
            // 
            this.costLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.costLabel.Location = new System.Drawing.Point(58, 155);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(100, 23);
            this.costLabel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of people";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.healthyOption);
            this.Controls.Add(this.CheckboxFancyDec);
            this.Controls.Add(this.numericUpDown1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox CheckboxFancyDec;
        private System.Windows.Forms.CheckBox healthyOption;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

