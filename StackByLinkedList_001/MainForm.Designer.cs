namespace StackByLinkedList_001
{
    partial class MainForm
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stacksList = new System.Windows.Forms.ListBox();
            this.inputNumberTextBox = new System.Windows.Forms.TextBox();
            this.inputNumLabel = new System.Windows.Forms.Label();
            this.bufferLabel = new System.Windows.Forms.Label();
            this.bufferValueLabel = new System.Windows.Forms.Label();
            this.insertBtn = new System.Windows.Forms.Button();
            this.sourceStackLabel = new System.Windows.Forms.Label();
            this.targetStackLabel = new System.Windows.Forms.Label();
            this.srcStackHashCodeLabel = new System.Windows.Forms.Label();
            this.targetStackHashCodeLabel = new System.Windows.Forms.Label();
            this.popFromSourceBtn = new System.Windows.Forms.Button();
            this.pushToTargetBtn = new System.Windows.Forms.Button();
            this.setAsSourceStackBtn = new System.Windows.Forms.Button();
            this.setAsTargetBtn = new System.Windows.Forms.Button();
            this.addEmptyStackBtn = new System.Windows.Forms.Button();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(773, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // stacksList
            // 
            this.stacksList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stacksList.FormattingEnabled = true;
            this.stacksList.ItemHeight = 20;
            this.stacksList.Location = new System.Drawing.Point(12, 27);
            this.stacksList.Name = "stacksList";
            this.stacksList.Size = new System.Drawing.Size(749, 224);
            this.stacksList.TabIndex = 1;
            this.stacksList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.stacksList_DrawItem);
            // 
            // inputNumberTextBox
            // 
            this.inputNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumberTextBox.Location = new System.Drawing.Point(124, 267);
            this.inputNumberTextBox.Name = "inputNumberTextBox";
            this.inputNumberTextBox.Size = new System.Drawing.Size(166, 26);
            this.inputNumberTextBox.TabIndex = 2;
            // 
            // inputNumLabel
            // 
            this.inputNumLabel.AutoSize = true;
            this.inputNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputNumLabel.Location = new System.Drawing.Point(8, 270);
            this.inputNumLabel.Name = "inputNumLabel";
            this.inputNumLabel.Size = new System.Drawing.Size(106, 20);
            this.inputNumLabel.TabIndex = 3;
            this.inputNumLabel.Text = "Input Number";
            // 
            // bufferLabel
            // 
            this.bufferLabel.AutoSize = true;
            this.bufferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bufferLabel.Location = new System.Drawing.Point(528, 270);
            this.bufferLabel.Name = "bufferLabel";
            this.bufferLabel.Size = new System.Drawing.Size(57, 20);
            this.bufferLabel.TabIndex = 4;
            this.bufferLabel.Text = "Buffer:";
            // 
            // bufferValueLabel
            // 
            this.bufferValueLabel.AutoSize = true;
            this.bufferValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bufferValueLabel.Location = new System.Drawing.Point(585, 270);
            this.bufferValueLabel.Name = "bufferValueLabel";
            this.bufferValueLabel.Size = new System.Drawing.Size(0, 20);
            this.bufferValueLabel.TabIndex = 5;
            // 
            // insertBtn
            // 
            this.insertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.insertBtn.Location = new System.Drawing.Point(296, 257);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(226, 47);
            this.insertBtn.TabIndex = 6;
            this.insertBtn.Text = "Insert To Target Stack";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // sourceStackLabel
            // 
            this.sourceStackLabel.AutoSize = true;
            this.sourceStackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sourceStackLabel.Location = new System.Drawing.Point(12, 316);
            this.sourceStackLabel.Name = "sourceStackLabel";
            this.sourceStackLabel.Size = new System.Drawing.Size(109, 20);
            this.sourceStackLabel.TabIndex = 7;
            this.sourceStackLabel.Text = "Source Stack:";
            // 
            // targetStackLabel
            // 
            this.targetStackLabel.AutoSize = true;
            this.targetStackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetStackLabel.Location = new System.Drawing.Point(12, 336);
            this.targetStackLabel.Name = "targetStackLabel";
            this.targetStackLabel.Size = new System.Drawing.Size(104, 20);
            this.targetStackLabel.TabIndex = 8;
            this.targetStackLabel.Text = "Target Stack:";
            // 
            // srcStackHashCodeLabel
            // 
            this.srcStackHashCodeLabel.AutoSize = true;
            this.srcStackHashCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.srcStackHashCodeLabel.Location = new System.Drawing.Point(127, 316);
            this.srcStackHashCodeLabel.Name = "srcStackHashCodeLabel";
            this.srcStackHashCodeLabel.Size = new System.Drawing.Size(0, 20);
            this.srcStackHashCodeLabel.TabIndex = 9;
            // 
            // targetStackHashCodeLabel
            // 
            this.targetStackHashCodeLabel.AutoSize = true;
            this.targetStackHashCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.targetStackHashCodeLabel.Location = new System.Drawing.Point(127, 336);
            this.targetStackHashCodeLabel.Name = "targetStackHashCodeLabel";
            this.targetStackHashCodeLabel.Size = new System.Drawing.Size(0, 20);
            this.targetStackHashCodeLabel.TabIndex = 10;
            // 
            // popFromSourceBtn
            // 
            this.popFromSourceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.popFromSourceBtn.Location = new System.Drawing.Point(296, 310);
            this.popFromSourceBtn.Name = "popFromSourceBtn";
            this.popFromSourceBtn.Size = new System.Drawing.Size(226, 46);
            this.popFromSourceBtn.TabIndex = 11;
            this.popFromSourceBtn.Text = "Pop From Source Stack";
            this.popFromSourceBtn.UseVisualStyleBackColor = true;
            this.popFromSourceBtn.Click += new System.EventHandler(this.popFromSourceBtn_Click);
            // 
            // pushToTargetBtn
            // 
            this.pushToTargetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pushToTargetBtn.Location = new System.Drawing.Point(532, 310);
            this.pushToTargetBtn.Name = "pushToTargetBtn";
            this.pushToTargetBtn.Size = new System.Drawing.Size(226, 46);
            this.pushToTargetBtn.TabIndex = 12;
            this.pushToTargetBtn.Text = "Push To Target";
            this.pushToTargetBtn.UseVisualStyleBackColor = true;
            this.pushToTargetBtn.Click += new System.EventHandler(this.pushToTargetBtn_Click);
            // 
            // setAsSourceStackBtn
            // 
            this.setAsSourceStackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setAsSourceStackBtn.Location = new System.Drawing.Point(296, 370);
            this.setAsSourceStackBtn.Name = "setAsSourceStackBtn";
            this.setAsSourceStackBtn.Size = new System.Drawing.Size(226, 46);
            this.setAsSourceStackBtn.TabIndex = 13;
            this.setAsSourceStackBtn.Text = "Set As Source Stack";
            this.setAsSourceStackBtn.UseVisualStyleBackColor = true;
            this.setAsSourceStackBtn.Click += new System.EventHandler(this.setAsSourceStackBtn_Click);
            // 
            // setAsTargetBtn
            // 
            this.setAsTargetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setAsTargetBtn.Location = new System.Drawing.Point(532, 370);
            this.setAsTargetBtn.Name = "setAsTargetBtn";
            this.setAsTargetBtn.Size = new System.Drawing.Size(226, 46);
            this.setAsTargetBtn.TabIndex = 14;
            this.setAsTargetBtn.Text = "Set As Target Stack";
            this.setAsTargetBtn.UseVisualStyleBackColor = true;
            this.setAsTargetBtn.Click += new System.EventHandler(this.setAsTargetBtn_Click);
            // 
            // addEmptyStackBtn
            // 
            this.addEmptyStackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEmptyStackBtn.Location = new System.Drawing.Point(12, 370);
            this.addEmptyStackBtn.Name = "addEmptyStackBtn";
            this.addEmptyStackBtn.Size = new System.Drawing.Size(226, 46);
            this.addEmptyStackBtn.TabIndex = 15;
            this.addEmptyStackBtn.Text = "Add Empty Stack";
            this.addEmptyStackBtn.UseVisualStyleBackColor = true;
            this.addEmptyStackBtn.Click += new System.EventHandler(this.addEmptyStackBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 428);
            this.Controls.Add(this.addEmptyStackBtn);
            this.Controls.Add(this.setAsTargetBtn);
            this.Controls.Add(this.setAsSourceStackBtn);
            this.Controls.Add(this.pushToTargetBtn);
            this.Controls.Add(this.popFromSourceBtn);
            this.Controls.Add(this.targetStackHashCodeLabel);
            this.Controls.Add(this.srcStackHashCodeLabel);
            this.Controls.Add(this.targetStackLabel);
            this.Controls.Add(this.sourceStackLabel);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.bufferValueLabel);
            this.Controls.Add(this.bufferLabel);
            this.Controls.Add(this.inputNumLabel);
            this.Controls.Add(this.inputNumberTextBox);
            this.Controls.Add(this.stacksList);
            this.Controls.Add(this.mainMenuStrip);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ListBox stacksList;
        private System.Windows.Forms.TextBox inputNumberTextBox;
        private System.Windows.Forms.Label inputNumLabel;
        private System.Windows.Forms.Label bufferLabel;
        private System.Windows.Forms.Label bufferValueLabel;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Label sourceStackLabel;
        private System.Windows.Forms.Label targetStackLabel;
        private System.Windows.Forms.Label srcStackHashCodeLabel;
        private System.Windows.Forms.Label targetStackHashCodeLabel;
        private System.Windows.Forms.Button popFromSourceBtn;
        private System.Windows.Forms.Button pushToTargetBtn;
        private System.Windows.Forms.Button setAsSourceStackBtn;
        private System.Windows.Forms.Button setAsTargetBtn;
        private System.Windows.Forms.Button addEmptyStackBtn;
    }
}

