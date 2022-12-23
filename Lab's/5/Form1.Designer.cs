
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this._mm = new System.Windows.Forms.DataGridView();
            this._L1 = new System.Windows.Forms.Label();
            this._cache = new System.Windows.Forms.DataGridView();
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
            this.newLine1 = new System.Windows.Forms.MaskedTextBox();
            this.changeLine = new System.Windows.Forms.Button();
            this.newLine2 = new System.Windows.Forms.MaskedTextBox();
            this.newLine3 = new System.Windows.Forms.MaskedTextBox();
            this.newLine4 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cacheLine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this._mm.Size = new System.Drawing.Size(372, 478);
            this._mm.TabIndex = 0;
            this._mm.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._mm_CellContentDoubleClick);
            // 
            // _L1
            // 
            this._L1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._L1.AutoSize = true;
            this._L1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._L1.Location = new System.Drawing.Point(133, 208);
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
            this._cache.Location = new System.Drawing.Point(12, 242);
            this._cache.Name = "_cache";
            this._cache.Size = new System.Drawing.Size(318, 283);
            this._cache.TabIndex = 2;
            this._cache.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._cache_CellContentDoubleClick);
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
            this._key.Location = new System.Drawing.Point(12, 21);
            this._key.Mask = "0999.0999.0999.0999";
            this._key.Name = "_key";
            this._key.Size = new System.Drawing.Size(206, 20);
            this._key.TabIndex = 4;
            this._key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _addr
            // 
            this._addr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._addr.Location = new System.Drawing.Point(12, 85);
            this._addr.Mask = "0 0 0";
            this._addr.Name = "_addr";
            this._addr.Size = new System.Drawing.Size(206, 26);
            this._addr.TabIndex = 6;
            this._addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchAddr
            // 
            this.searchAddr.Location = new System.Drawing.Point(224, 86);
            this.searchAddr.Name = "searchAddr";
            this.searchAddr.Size = new System.Drawing.Size(106, 26);
            this.searchAddr.TabIndex = 8;
            this.searchAddr.Text = "Поиск по адресу";
            this.searchAddr.UseVisualStyleBackColor = true;
            this.searchAddr.Click += new System.EventHandler(this.searchAddr_Click);
            // 
            // searchKey
            // 
            this.searchKey.Location = new System.Drawing.Point(224, 18);
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
            this.label1.Location = new System.Drawing.Point(17, 114);
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
            this.label2.Location = new System.Drawing.Point(67, 114);
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
            this.label3.Location = new System.Drawing.Point(147, 114);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 531);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(834, 22);
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
            // newLine1
            // 
            this.newLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newLine1.Location = new System.Drawing.Point(12, 154);
            this.newLine1.Mask = "0999";
            this.newLine1.Name = "newLine1";
            this.newLine1.Size = new System.Drawing.Size(47, 26);
            this.newLine1.TabIndex = 4;
            this.newLine1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // changeLine
            // 
            this.changeLine.Location = new System.Drawing.Point(224, 154);
            this.changeLine.Name = "changeLine";
            this.changeLine.Size = new System.Drawing.Size(106, 26);
            this.changeLine.TabIndex = 8;
            this.changeLine.Text = "Изменить строку";
            this.changeLine.UseVisualStyleBackColor = true;
            this.changeLine.Click += new System.EventHandler(this.changeLine_Click);
            // 
            // newLine2
            // 
            this.newLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newLine2.Location = new System.Drawing.Point(65, 154);
            this.newLine2.Mask = "0999";
            this.newLine2.Name = "newLine2";
            this.newLine2.Size = new System.Drawing.Size(47, 26);
            this.newLine2.TabIndex = 4;
            this.newLine2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newLine3
            // 
            this.newLine3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newLine3.Location = new System.Drawing.Point(118, 154);
            this.newLine3.Mask = "0999";
            this.newLine3.Name = "newLine3";
            this.newLine3.Size = new System.Drawing.Size(47, 26);
            this.newLine3.TabIndex = 4;
            this.newLine3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // newLine4
            // 
            this.newLine4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newLine4.Location = new System.Drawing.Point(171, 154);
            this.newLine4.Mask = "0999";
            this.newLine4.Name = "newLine4";
            this.newLine4.Size = new System.Drawing.Size(47, 26);
            this.newLine4.TabIndex = 4;
            this.newLine4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle28;
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
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cacheLine.DefaultCellStyle = dataGridViewCellStyle29;
            this.cacheLine.HeaderText = "Строка";
            this.cacheLine.Name = "cacheLine";
            this.cacheLine.ReadOnly = true;
            // 
            // tag
            // 
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tag.DefaultCellStyle = dataGridViewCellStyle30;
            this.tag.FillWeight = 40F;
            this.tag.HeaderText = "Тег";
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            this.tag.Width = 40;
            // 
            // DataGridViewTextBoxColumn11
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle25;
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
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridViewTextBoxColumn12.DefaultCellStyle = dataGridViewCellStyle26;
            this.DataGridViewTextBoxColumn12.HeaderText = "Строка";
            this.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12";
            this.DataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn13
            // 
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridViewTextBoxColumn13.DefaultCellStyle = dataGridViewCellStyle27;
            this.DataGridViewTextBoxColumn13.FillWeight = 50F;
            this.DataGridViewTextBoxColumn13.HeaderText = "№ стр.";
            this.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13";
            this.DataGridViewTextBoxColumn13.ReadOnly = true;
            this.DataGridViewTextBoxColumn13.Width = 50;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 553);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rewriteMM);
            this.Controls.Add(this.changeLine);
            this.Controls.Add(this.searchKey);
            this.Controls.Add(this.searchAddr);
            this.Controls.Add(this._addr);
            this.Controls.Add(this.newLine4);
            this.Controls.Add(this.newLine3);
            this.Controls.Add(this.newLine2);
            this.Controls.Add(this.newLine1);
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
        private System.Windows.Forms.MaskedTextBox newLine1;
        private System.Windows.Forms.Button changeLine;
        private System.Windows.Forms.ToolStripStatusLabel _loadPlace;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel _loadEl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel _loadLine;
        private System.Windows.Forms.MaskedTextBox newLine2;
        private System.Windows.Forms.MaskedTextBox newLine3;
        private System.Windows.Forms.MaskedTextBox newLine4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cacheLine;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn13;
    }
}

