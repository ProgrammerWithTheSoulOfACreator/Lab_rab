
namespace App_3
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.новыйАвторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйИздательскийДомToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новоеМестоРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяНаучнаяСтепеньToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйТипРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйUDCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column1,
            this.Column12,
            this.Column13,
            this.Column10,
            this.Column7,
            this.Column5,
            this.Column9,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(13, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1416, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Научная работа";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия и имя автора";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Дата создания";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 150;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Тип работы";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Количество страниц";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Издательский дом";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Цитируемость";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ДОИ";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 150;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "УДК";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Где-то тут пагинация";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить публикацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(220, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Удалить публикацию";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйАвторToolStripMenuItem,
            this.новыйИздательскийДомToolStripMenuItem,
            this.новоеМестоРаботыToolStripMenuItem,
            this.новаяНаучнаяСтепеньToolStripMenuItem,
            this.новыйТипРаботыToolStripMenuItem,
            this.новыйUDCToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1446, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // новыйАвторToolStripMenuItem
            // 
            this.новыйАвторToolStripMenuItem.Name = "новыйАвторToolStripMenuItem";
            this.новыйАвторToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.новыйАвторToolStripMenuItem.Text = "Новый автор";
            this.новыйАвторToolStripMenuItem.Click += new System.EventHandler(this.новыйАвторToolStripMenuItem_Click);
            // 
            // новыйИздательскийДомToolStripMenuItem
            // 
            this.новыйИздательскийДомToolStripMenuItem.Name = "новыйИздательскийДомToolStripMenuItem";
            this.новыйИздательскийДомToolStripMenuItem.Size = new System.Drawing.Size(237, 29);
            this.новыйИздательскийДомToolStripMenuItem.Text = "Новый издательский дом";
            this.новыйИздательскийДомToolStripMenuItem.Click += new System.EventHandler(this.новыйИздательскийДомToolStripMenuItem_Click);
            // 
            // новоеМестоРаботыToolStripMenuItem
            // 
            this.новоеМестоРаботыToolStripMenuItem.Name = "новоеМестоРаботыToolStripMenuItem";
            this.новоеМестоРаботыToolStripMenuItem.Size = new System.Drawing.Size(201, 29);
            this.новоеМестоРаботыToolStripMenuItem.Text = "Новое место работы";
            this.новоеМестоРаботыToolStripMenuItem.Click += new System.EventHandler(this.новоеМестоРаботыToolStripMenuItem_Click);
            // 
            // новаяНаучнаяСтепеньToolStripMenuItem
            // 
            this.новаяНаучнаяСтепеньToolStripMenuItem.Name = "новаяНаучнаяСтепеньToolStripMenuItem";
            this.новаяНаучнаяСтепеньToolStripMenuItem.Size = new System.Drawing.Size(218, 29);
            this.новаяНаучнаяСтепеньToolStripMenuItem.Text = "Новая научная степень";
            this.новаяНаучнаяСтепеньToolStripMenuItem.Click += new System.EventHandler(this.новаяНаучнаяСтепеньToolStripMenuItem_Click);
            // 
            // новыйТипРаботыToolStripMenuItem
            // 
            this.новыйТипРаботыToolStripMenuItem.Name = "новыйТипРаботыToolStripMenuItem";
            this.новыйТипРаботыToolStripMenuItem.Size = new System.Drawing.Size(183, 29);
            this.новыйТипРаботыToolStripMenuItem.Text = "Новый тип работы";
            this.новыйТипРаботыToolStripMenuItem.Click += new System.EventHandler(this.новыйТипРаботыToolStripMenuItem_Click);
            // 
            // новыйUDCToolStripMenuItem
            // 
            this.новыйUDCToolStripMenuItem.Name = "новыйUDCToolStripMenuItem";
            this.новыйUDCToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
            this.новыйUDCToolStripMenuItem.Text = "Новый УДК";
            this.новыйUDCToolStripMenuItem.Click += new System.EventHandler(this.новыйUDCToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(492, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(301, 34);
            this.button3.TabIndex = 5;
            this.button3.Text = "Просмотр/изменение авторов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 560);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Главная";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новыйАвторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйИздательскийДомToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новоеМестоРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новаяНаучнаяСтепеньToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйТипРаботыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйUDCToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}

