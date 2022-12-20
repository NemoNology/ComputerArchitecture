
namespace ЭВМ_Лаб_4__WF_
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
            this._mm = new System.Windows.Forms.DataGridView();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._L1 = new System.Windows.Forms.Label();
            this._cache = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cacheLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._L2 = new System.Windows.Forms.Label();
            this._key = new System.Windows.Forms.MaskedTextBox();
            this._addr = new System.Windows.Forms.MaskedTextBox();
            this.searchAddr = new System.Windows.Forms.Button();
            this.searchKey = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rewriteMM = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this._time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this._loadPlace = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this._loadEl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this._loadLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.newLine = new System.Windows.Forms.MaskedTextBox();
            this.changeLine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._mm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cache)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mm
            // 
            this._mm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._mm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._mm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DataGridViewTextBoxColumn11,
            this.DataGridViewTextBoxColumn12,
            this.DataGridViewTextBoxColumn13});
            this._mm.Location = new System.Drawing.Point(450, 47);
            this._mm.Name = "_mm";
            this._mm.Size = new System.Drawing.Size(322, 386);
            this._mm.TabIndex = 0;
            // 
            // DataGridViewTextBoxColumn11
            // 
            this.DataGridViewTextBoxColumn11.FillWeight = 50F;
            this.DataGridViewTextBoxColumn11.HeaderText = "№ строки";
            this.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11";
            this.DataGridViewTextBoxColumn11.ReadOnly = true;
            this.DataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewTextBoxColumn11.Width = 50;
            // 
            // DataGridViewTextBoxColumn12
            // 
            this.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn12.HeaderText = "Строка";
            this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            this.DataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn13
            // 
            this.DataGridViewTextBoxColumn13.FillWeight = 50F;
            this.DataGridViewTextBoxColumn13.HeaderText = "№ стр.";
            this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.ReadOnly = true;
            this.DataGridViewTextBoxColumn13.Width = 50;
            // 
            // _L1
            // 
            this._L1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._L1.AutoSize = true;
            this._L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._L1.Location = new System.Drawing.Point(120, 183);
            this._L1.Name = "_L1";
            this._L1.Size = new System.Drawing.Size(77, 31);
            this._L1.TabIndex = 1;
            this._L1.Text = "КЭШ";
            // 
            // _cache
            // 
            this._cache.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._cache.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._cache.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.cacheLine,
            this.tag});
            this._cache.Location = new System.Drawing.Point(12, 217);
            this._cache.Name = "_cache";
            this._cache.Size = new System.Drawing.Size(304, 216);
            this._cache.TabIndex = 2;
            this._cache.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._cache_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "№ строки";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // cacheLine
            // 
            this.cacheLine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cacheLine.HeaderText = "Строка";
            this.cacheLine.Name = "cacheLine";
            this.cacheLine.ReadOnly = true;
            // 
            // tag
            // 
            this.tag.FillWeight = 30F;
            this.tag.HeaderText = "Тег";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.Width = 30;
            // 
            // _L2
            // 
            this._L2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._L2.AutoSize = true;
            this._L2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._L2.Location = new System.Drawing.Point(575, 13);
            this._L2.Name = "_L2";
            this._L2.Size = new System.Drawing.Size(57, 31);
            this._L2.TabIndex = 3;
            this._L2.Text = "ОП";
            // 
            // _key
            // 
            this._key.Location = new System.Drawing.Point(12, 83);
            this._key.Mask = "0999";
            this._key.Name = "_key";
            this._key.Size = new System.Drawing.Size(165, 20);
            this._key.TabIndex = 4;
            // 
            // _addr
            // 
            this._addr.Location = new System.Drawing.Point(12, 27);
            this._addr.Mask = "0 0 0";
            this._addr.Name = "_addr";
            this._addr.Size = new System.Drawing.Size(165, 20);
            this._addr.TabIndex = 6;
            // 
            // searchAddr
            // 
            this.searchAddr.Location = new System.Drawing.Point(210, 25);
            this.searchAddr.Name = "searchAddr";
            this.searchAddr.Size = new System.Drawing.Size(106, 23);
            this.searchAddr.TabIndex = 8;
            this.searchAddr.Text = "Поиск по адресу";
            this.searchAddr.UseVisualStyleBackColor = true;
            this.searchAddr.Click += new System.EventHandler(this.searchAddr_Click);
            // 
            // searchKey
            // 
            this.searchKey.Location = new System.Drawing.Point(210, 81);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(106, 23);
            this.searchKey.TabIndex = 8;
            this.searchKey.Text = "Поиск по ключу";
            this.searchKey.UseVisualStyleBackColor = true;
            this.searchKey.Click += new System.EventHandler(this.searchKey_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Стр";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(58, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Строка";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(122, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Число";
            // 
            // rewriteMM
            // 
            this.rewriteMM.Location = new System.Drawing.Point(450, 18);
            this.rewriteMM.Name = "rewriteMM";
            this.rewriteMM.Size = new System.Drawing.Size(106, 23);
            this.rewriteMM.TabIndex = 8;
            this.rewriteMM.Text = "Перезаписать";
            this.rewriteMM.UseVisualStyleBackColor = true;
            this.rewriteMM.Click += new System.EventHandler(this.rewriteMM_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this._time,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this._loadPlace,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel5,
            this._loadEl,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this._loadLine});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "Затраченное время:";
            // 
            // _time
            // 
            this._time.Name = "_time";
            this._time.Size = new System.Drawing.Size(16, 17);
            this._time.Text = "...";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel2.Text = "ticks";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(85, 17);
            this.toolStripStatusLabel4.Text = "Загружено из:";
            // 
            // _loadPlace
            // 
            this._loadPlace.Name = "_loadPlace";
            this._loadPlace.Size = new System.Drawing.Size(16, 17);
            this._loadPlace.Text = "...";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel6.Text = "|";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(135, 17);
            this.toolStripStatusLabel5.Text = "Загруженный элемент:";
            // 
            // _loadEl
            // 
            this._loadEl.Name = "_loadEl";
            this._loadEl.Size = new System.Drawing.Size(16, 17);
            this._loadEl.Text = "...";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel7.Text = "|";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel8.Text = "Из строки:";
            // 
            // _loadLine
            // 
            this._loadLine.Name = "_loadLine";
            this._loadLine.Size = new System.Drawing.Size(16, 17);
            this._loadLine.Text = "...";
            // 
            // newLine
            // 
            this.newLine.Location = new System.Drawing.Point(12, 160);
            this.newLine.Mask = "0999.0999.0999.0999";
            this.newLine.Name = "newLine";
            this.newLine.Size = new System.Drawing.Size(165, 20);
            this.newLine.TabIndex = 4;
            // 
            // changeLine
            // 
            this.changeLine.Location = new System.Drawing.Point(210, 157);
            this.changeLine.Name = "changeLine";
            this.changeLine.Size = new System.Drawing.Size(106, 23);
            this.changeLine.TabIndex = 8;
            this.changeLine.Text = "Изменить строку";
            this.changeLine.UseVisualStyleBackColor = true;
            this.changeLine.Click += new System.EventHandler(this.changeLine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rewriteMM);
            this.Controls.Add(this.changeLine);
            this.Controls.Add(this.searchKey);
            this.Controls.Add(this.searchAddr);
            this.Controls.Add(this._addr);
            this.Controls.Add(this.newLine);
            this.Controls.Add(this._key);
            this.Controls.Add(this._L2);
            this.Controls.Add(this._cache);
            this.Controls.Add(this._L1);
            this.Controls.Add(this._mm);
            this.Name = "Form1";
            this.Text = "ЭВМ. Лаб-я 4";
            ((System.ComponentModel.ISupportInitialize)(this._mm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cache)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView _mm;
        private System.Windows.Forms.Label _L1;
        private System.Windows.Forms.DataGridView _cache;
        private System.Windows.Forms.Label _L2;
        private System.Windows.Forms.MaskedTextBox _key;
        private System.Windows.Forms.MaskedTextBox _addr;
        private System.Windows.Forms.Button searchAddr;
        private System.Windows.Forms.Button searchKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rewriteMM;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel _time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.MaskedTextBox newLine;
        private System.Windows.Forms.Button changeLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cacheLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.ToolStripStatusLabel _loadPlace;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel _loadEl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel _loadLine;
    }
}

