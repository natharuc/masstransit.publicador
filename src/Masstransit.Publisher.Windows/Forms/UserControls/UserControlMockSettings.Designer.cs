﻿namespace Masstransit.Publisher.Windows.Forms.UserControls
{
    partial class UserControlMockSettings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel = new Panel();
            labelValueInfo = new Label();
            checkBoxAwaysChange = new CheckBox();
            checkBoxIgnore = new CheckBox();
            linkLabelRemove = new LinkLabel();
            labelValue = new Label();
            textBoxValue = new TextBox();
            labelName = new Label();
            textBoxName = new TextBox();
            comboBoxType = new ComboBox();
            labelType = new Label();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel
            // 
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(labelType);
            panel.Controls.Add(comboBoxType);
            panel.Controls.Add(labelValueInfo);
            panel.Controls.Add(checkBoxAwaysChange);
            panel.Controls.Add(checkBoxIgnore);
            panel.Controls.Add(linkLabelRemove);
            panel.Controls.Add(labelValue);
            panel.Controls.Add(textBoxValue);
            panel.Controls.Add(labelName);
            panel.Controls.Add(textBoxName);
            panel.Dock = DockStyle.Fill;
            panel.Location = new Point(0, 0);
            panel.Name = "panel";
            panel.Size = new Size(212, 210);
            panel.TabIndex = 2;
            // 
            // labelValueInfo
            // 
            labelValueInfo.AutoSize = true;
            labelValueInfo.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            labelValueInfo.ForeColor = SystemColors.ControlDarkDark;
            labelValueInfo.Location = new Point(8, 143);
            labelValueInfo.Name = "labelValueInfo";
            labelValueInfo.Size = new Size(184, 13);
            labelValueInfo.TabIndex = 17;
            labelValueInfo.Text = "If empty, the value will be random.";
            // 
            // checkBoxAwaysChange
            // 
            checkBoxAwaysChange.AutoSize = true;
            checkBoxAwaysChange.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxAwaysChange.Location = new Point(8, 171);
            checkBoxAwaysChange.Name = "checkBoxAwaysChange";
            checkBoxAwaysChange.Size = new Size(167, 19);
            checkBoxAwaysChange.TabIndex = 16;
            checkBoxAwaysChange.Text = "Regenerate before sending";
            checkBoxAwaysChange.UseVisualStyleBackColor = true;
            checkBoxAwaysChange.CheckedChanged += checkBoxAwaysChange_CheckedChanged;
            // 
            // checkBoxIgnore
            // 
            checkBoxIgnore.AutoSize = true;
            checkBoxIgnore.Location = new Point(137, 98);
            checkBoxIgnore.Name = "checkBoxIgnore";
            checkBoxIgnore.Size = new Size(60, 19);
            checkBoxIgnore.TabIndex = 15;
            checkBoxIgnore.Text = "Ignore";
            checkBoxIgnore.UseVisualStyleBackColor = true;
            checkBoxIgnore.CheckedChanged += checkBoxIgnore_CheckedChanged;
            // 
            // linkLabelRemove
            // 
            linkLabelRemove.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabelRemove.AutoSize = true;
            linkLabelRemove.LinkColor = Color.Brown;
            linkLabelRemove.Location = new Point(150, 9);
            linkLabelRemove.Margin = new Padding(2, 0, 2, 0);
            linkLabelRemove.Name = "linkLabelRemove";
            linkLabelRemove.Size = new Size(47, 15);
            linkLabelRemove.TabIndex = 14;
            linkLabelRemove.TabStop = true;
            linkLabelRemove.Text = "remove";
            linkLabelRemove.TextAlign = ContentAlignment.MiddleRight;
            linkLabelRemove.LinkClicked += linkLabelRemover_LinkClicked;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(8, 99);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(35, 15);
            labelValue.TabIndex = 5;
            labelValue.Text = "Value";
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(8, 117);
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(189, 23);
            textBoxValue.TabIndex = 4;
            textBoxValue.TextChanged += textBoxValue_TextChanged;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(8, 55);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(8, 73);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(189, 23);
            textBoxName.TabIndex = 2;
            // 
            // comboBoxType
            // 
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(8, 29);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(189, 23);
            comboBoxType.TabIndex = 18;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Location = new Point(8, 11);
            labelType.Name = "labelType";
            labelType.Size = new Size(31, 15);
            labelType.TabIndex = 19;
            labelType.Text = "Type";
            labelType.Click += label1_Click;
            // 
            // UserControlMockSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel);
            Margin = new Padding(0);
            Name = "UserControlMockSettings";
            Size = new Size(212, 210);
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel;
        private Label labelName;
        private TextBox textBoxName;
        private Label labelValue;
        private TextBox textBoxValue;
        private LinkLabel linkLabelRemove;
        private CheckBox checkBoxIgnore;
        private CheckBox checkBoxAwaysChange;
        private Label labelValueInfo;
        private Label labelType;
        private ComboBox comboBoxType;
    }
}
