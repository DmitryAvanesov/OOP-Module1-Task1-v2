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
            this.addSawmillButton = new System.Windows.Forms.Button();
            this.inputBuildingName = new System.Windows.Forms.TextBox();
            this.addColonyButton = new System.Windows.Forms.Button();
            this.addGoldmineButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resourcesPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // coloniesPanel
            // 
            this.coloniesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.coloniesPanel.Location = new System.Drawing.Point(638, 75);
            this.coloniesPanel.Name = "coloniesPanel";
            this.coloniesPanel.Size = new System.Drawing.Size(620, 764);
            this.coloniesPanel.TabIndex = 1;
            // 
            // buildingsPanel
            // 
            this.buildingsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buildingsPanel.Location = new System.Drawing.Point(1264, 75);
            this.buildingsPanel.Name = "buildingsPanel";
            this.buildingsPanel.Size = new System.Drawing.Size(620, 764);
            this.buildingsPanel.TabIndex = 2;
            // 
            // inputPlanetName
            // 
            this.inputPlanetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputPlanetName.Location = new System.Drawing.Point(12, 12);
            this.inputPlanetName.Name = "inputPlanetName";
            this.inputPlanetName.Size = new System.Drawing.Size(364, 34);
            this.inputPlanetName.TabIndex = 3;
            this.inputPlanetName.Text = "Planet\'s name";
            // 
            // addPlanetButton
            // 
            this.addPlanetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPlanetButton.Location = new System.Drawing.Point(382, 12);
            this.addPlanetButton.Name = "addPlanetButton";
            this.addPlanetButton.Size = new System.Drawing.Size(250, 34);
            this.addPlanetButton.TabIndex = 6;
            this.addPlanetButton.Text = "Discover new planet";
            this.addPlanetButton.UseVisualStyleBackColor = true;
            this.addPlanetButton.Click += new System.EventHandler(this.AddPlanetButton_Click);
            // 
            // planetsPanel
            // 
            this.planetsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.planetsPanel.Location = new System.Drawing.Point(12, 75);
            this.planetsPanel.Name = "planetsPanel";
            this.planetsPanel.Size = new System.Drawing.Size(620, 764);
            this.planetsPanel.TabIndex = 0;
            // 
            // inputColonyName
            // 
            this.inputColonyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputColonyName.Location = new System.Drawing.Point(638, 12);
            this.inputColonyName.Name = "inputColonyName";
            this.inputColonyName.Size = new System.Drawing.Size(364, 34);
            this.inputColonyName.TabIndex = 8;
            this.inputColonyName.Text = "Colony\'s name";
            // 
            // addSawmillButton
            // 
            this.addSawmillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSawmillButton.Location = new System.Drawing.Point(1709, 12);
            this.addSawmillButton.Name = "addSawmillButton";
            this.addSawmillButton.Size = new System.Drawing.Size(175, 34);
            this.addSawmillButton.TabIndex = 16;
            this.addSawmillButton.Text = "Add sawmill";
            this.addSawmillButton.UseVisualStyleBackColor = true;
            this.addSawmillButton.Click += new System.EventHandler(this.AddSawmillButton_Click);
            // 
            // inputBuildingName
            // 
            this.inputBuildingName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputBuildingName.Location = new System.Drawing.Point(1264, 12);
            this.inputBuildingName.Name = "inputBuildingName";
            this.inputBuildingName.Size = new System.Drawing.Size(258, 34);
            this.inputBuildingName.TabIndex = 13;
            this.inputBuildingName.Text = "Building\'s name";
            // 
            // addColonyButton
            // 
            this.addColonyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addColonyButton.Location = new System.Drawing.Point(1008, 12);
            this.addColonyButton.Name = "addColonyButton";
            this.addColonyButton.Size = new System.Drawing.Size(250, 34);
            this.addColonyButton.TabIndex = 11;
            this.addColonyButton.Text = "Add colony";
            this.addColonyButton.UseVisualStyleBackColor = true;
            this.addColonyButton.Click += new System.EventHandler(this.AddColonyButton_Click);
            // 
            // addGoldmineButton
            // 
            this.addGoldmineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addGoldmineButton.Location = new System.Drawing.Point(1528, 12);
            this.addGoldmineButton.Name = "addGoldmineButton";
            this.addGoldmineButton.Size = new System.Drawing.Size(175, 34);
            this.addGoldmineButton.TabIndex = 17;
            this.addGoldmineButton.Text = "Add goldmine";
            this.addGoldmineButton.UseVisualStyleBackColor = true;
            this.addGoldmineButton.Click += new System.EventHandler(this.AddGoldmineButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1554, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "50 gold | 30 wood";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1739, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "20 gold | 100 wood";
            // 
            // resourcesPanel
            // 
            this.resourcesPanel.Location = new System.Drawing.Point(12, 845);
            this.resourcesPanel.Name = "resourcesPanel";
            this.resourcesPanel.Size = new System.Drawing.Size(1872, 178);
            this.resourcesPanel.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1035);
            this.Controls.Add(this.resourcesPanel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addGoldmineButton);
            this.Controls.Add(this.addSawmillButton);
            this.Controls.Add(this.inputBuildingName);
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
        private System.Windows.Forms.Button addSawmillButton;
        private System.Windows.Forms.TextBox inputBuildingName;
        private System.Windows.Forms.Button addColonyButton;
        private System.Windows.Forms.Button addGoldmineButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel resourcesPanel;
    }
}

