namespace Example.PropertyCascade
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bsViewModel = new System.Windows.Forms.BindingSource(this.components);
            this.bsCombo1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.bsCombo2 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.avalancheControl1 = new Example.PropertyCascade.AvalancheControl();
            ((System.ComponentModel.ISupportInitialize)(this.bsViewModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCombo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCombo2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsViewModel, "SelectedValue1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBox1.DataSource = this.bsCombo1;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(284, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // bsViewModel
            // 
            this.bsViewModel.DataSource = typeof(Example.PropertyCascade.Form1ViewModel);
            // 
            // bsCombo1
            // 
            this.bsCombo1.DataSource = typeof(Example.PropertyCascade.MyBusinessStuff1);
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsViewModel, "SelectedValue2", true));
            this.comboBox2.DataSource = this.bsCombo2;
            this.comboBox2.DisplayMember = "Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 59);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(284, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // bsCombo2
            // 
            this.bsCombo2.DataSource = typeof(Example.PropertyCascade.MyBusinessStuff2);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsViewModel, "CalculatedValue", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(12, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(284, 20);
            this.textBox1.TabIndex = 3;
            // 
            // avalancheControl1
            // 
            this.avalancheControl1.Location = new System.Drawing.Point(12, 125);
            this.avalancheControl1.Name = "avalancheControl1";
            this.avalancheControl1.Size = new System.Drawing.Size(280, 26);
            this.avalancheControl1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 205);
            this.Controls.Add(this.avalancheControl1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsViewModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCombo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCombo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource bsViewModel;
        private System.Windows.Forms.BindingSource bsCombo1;
        private System.Windows.Forms.BindingSource bsCombo2;
        private System.Windows.Forms.TextBox textBox1;
        private AvalancheControl avalancheControl1;
    }
}

