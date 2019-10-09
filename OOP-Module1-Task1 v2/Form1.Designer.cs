namespace OOP_Module1_Task1_v2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.coloniesPanel = new System.Windows.Forms.Panel();
            this.buildingsPanel = new System.Windows.Forms.Panel();
            this.inputPlanetName = new System.Windows.Forms.TextBox();
            this.addPlanetButton = new System.Windows.Forms.Button();
            this.planetsPanel = new System.Windows.Forms.Panel();
            this.inputColonyName = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.addColonyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coloniesPanel
            // 
            this.coloniesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.coloniesPanel.Location = new System.Drawing.Point(638, 47);
            this.coloniesPanel.Name = "coloniesPanel";
            this.coloniesPanel.Size = new System.Drawing.Size(620, 976);
            this.coloniesPanel.TabIndex = 1;
            // 
            // buildingsPanel
            // 
            this.buildingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buildingsPanel.Location = new System.Drawing.Point(1264, 47);
            this.buildingsPanel.Name = "buildingsPanel";
            this.buildingsPanel.Size = new System.Drawing.Size(620, 976);
            this.buildingsPanel.TabIndex = 2;
            // 
            // inputPlanetName
            // 
            this.inputPlanetName.Location = new System.Drawing.Point(12, 15);
            this.inputPlanetName.Name = "inputPlanetName";
            this.inputPlanetName.Size = new System.Drawing.Size(414, 22);
            this.inputPlanetName.TabIndex = 3;
            this.inputPlanetName.Text = "Planet\'s name";
            // 
            // addPlanetButton
            // 
            this.addPlanetButton.Location = new System.Drawing.Point(432, 11);
            this.addPlanetButton.Name = "addPlanetButton";
            this.addPlanetButton.Size = new System.Drawing.Size(200, 30);
            this.addPlanetButton.TabIndex = 6;
            this.addPlanetButton.Text = "Discover new planet";
            this.addPlanetButton.UseVisualStyleBackColor = true;
            this.addPlanetButton.Click += new System.EventHandler(this.AddPlanetButton_Click);
            // 
            // planetsPanel
            // 
            this.planetsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.planetsPanel.Location = new System.Drawing.Point(12, 47);
            this.planetsPanel.Name = "planetsPanel";
            this.planetsPanel.Size = new System.Drawing.Size(620, 976);
            this.planetsPanel.TabIndex = 0;
            // 
            // inputColonyName
            // 
            this.inputColonyName.Location = new System.Drawing.Point(638, 15);
            this.inputColonyName.Name = "inputColonyName";
            this.inputColonyName.Size = new System.Drawing.Size(414, 22);
            this.inputColonyName.TabIndex = 8;
            this.inputColonyName.Text = "Colony\'s name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1669, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(85, 22);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1659, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = ";";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1760, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Add planet";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(1574, 12);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(85, 22);
            this.textBox5.TabIndex = 14;
            this.textBox5.Text = "0";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1264, 12);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(304, 22);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "Planet\'s name";
            // 
            // addColonyButton
            // 
            this.addColonyButton.Location = new System.Drawing.Point(1058, 11);
            this.addColonyButton.Name = "addColonyButton";
            this.addColonyButton.Size = new System.Drawing.Size(200, 30);
            this.addColonyButton.TabIndex = 11;
            this.addColonyButton.Text = "Add colony";
            this.addColonyButton.UseVisualStyleBackColor = true;
            this.addColonyButton.Click += new System.EventHandler(this.AddColonyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.addColonyButton);
            this.Controls.Add(this.inputColonyName);
            this.Controls.Add(this.addPlanetButton);
            this.Controls.Add(this.inputPlanetName);
            this.Controls.Add(this.buildingsPanel);
            this.Controls.Add(this.coloniesPanel);
            this.Controls.Add(this.planetsPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel coloniesPanel;
        private System.Windows.Forms.Panel buildingsPanel;
        private System.Windows.Forms.TextBox inputPlanetName;
        private System.Windows.Forms.Button addPlanetButton;
        private System.Windows.Forms.Panel planetsPanel;
        private System.Windows.Forms.TextBox inputColonyName;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button addColonyButton;
    }
}

