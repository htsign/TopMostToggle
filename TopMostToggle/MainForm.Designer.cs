using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MyApp
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.reload = new System.Windows.Forms.Button();
            this.selfPinning = new System.Windows.Forms.CheckBox();
            this.help = new System.Windows.Forms.Button();
            this.pinningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.processId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.top = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.windowState = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.processesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComboBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinningBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoGenerateColumns = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.processId,
            this.top,
            this.windowState,
            this.title});
            this.dgv.DataSource = this.processesBindingSource;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 21;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(584, 333);
            this.dgv.TabIndex = 0;
            this.dgv.TabStop = false;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            this.dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            this.dgv.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_CellMouseClick);
            // 
            // reload
            // 
            this.reload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reload.Location = new System.Drawing.Point(483, 340);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(75, 22);
            this.reload.TabIndex = 1;
            this.reload.Text = "再読込";
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.reload_Click);
            // 
            // selfPinning
            // 
            this.selfPinning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selfPinning.Appearance = System.Windows.Forms.Appearance.Button;
            this.selfPinning.AutoSize = true;
            this.selfPinning.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.pinningBindingSource, "TopMost", true));
            this.selfPinning.Location = new System.Drawing.Point(0, 340);
            this.selfPinning.Name = "selfPinning";
            this.selfPinning.Size = new System.Drawing.Size(30, 22);
            this.selfPinning.TabIndex = 2;
            this.selfPinning.Text = "pin";
            this.selfPinning.UseVisualStyleBackColor = true;
            this.selfPinning.CheckedChanged += new System.EventHandler(this.selfPinning_CheckedChanged);
            // 
            // help
            // 
            this.help.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.help.Location = new System.Drawing.Point(558, 340);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(25, 22);
            this.help.TabIndex = 3;
            this.help.Text = "?";
            this.help.UseVisualStyleBackColor = true;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // pinningBindingSource
            // 
            this.pinningBindingSource.DataSource = typeof(MyApp.MainForm);
            // 
            // name
            // 
            this.name.DataPropertyName = "Name";
            this.name.HeaderText = "プロセス名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 79;
            // 
            // processId
            // 
            this.processId.DataPropertyName = "ProcessId";
            this.processId.HeaderText = "プロセスID";
            this.processId.Name = "processId";
            this.processId.ReadOnly = true;
            this.processId.Width = 78;
            // 
            // top
            // 
            this.top.DataPropertyName = "TopMost";
            this.top.HeaderText = "最前面";
            this.top.Name = "top";
            this.top.Width = 47;
            // 
            // windowState
            // 
            this.windowState.DataPropertyName = "WindowState";
            this.windowState.DataSource = this.processesBindingSource;
            this.windowState.DisplayMember = "WindowState";
            this.windowState.HeaderText = "状態";
            this.windowState.Name = "windowState";
            this.windowState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.windowState.ValueMember = "WindowState";
            this.windowState.Width = 39;
            // 
            // processesBindingSource
            // 
            this.processesBindingSource.DataSource = typeof(MyApp.ProcessInfoList);
            this.processesBindingSource.Sort = "Name ASC";
            // 
            // title
            // 
            this.title.DataPropertyName = "Title";
            this.title.HeaderText = "タイトル";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 65;
            // 
            // dataGridViewComboBoxColumn1
            // 
            this.dataGridViewComboBoxColumn1.DataPropertyName = "WindowState";
            this.dataGridViewComboBoxColumn1.HeaderText = "状態";
            this.dataGridViewComboBoxColumn1.Name = "dataGridViewComboBoxColumn1";
            this.dataGridViewComboBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComboBoxColumn1.Width = 39;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.help);
            this.Controls.Add(this.selfPinning);
            this.Controls.Add(this.reload);
            this.Controls.Add(this.dgv);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "TopMostToggle";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinningBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv;
        private Button reload;
        private BindingSource processesBindingSource;
        private CheckBox selfPinning;
        private BindingSource pinningBindingSource;
        private Button help;
        private DataGridViewComboBoxColumn dataGridViewComboBoxColumn1;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn processId;
        private DataGridViewCheckBoxColumn top;
        private DataGridViewComboBoxColumn windowState;
        private DataGridViewTextBoxColumn title;
    }
}

