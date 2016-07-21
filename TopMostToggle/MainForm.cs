using System;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp
{
    public partial class MainForm : Form
    {
        private BindingList<ProcessInfo> processes;

        public MainForm()
        {
            InitializeComponent();

            Load += async (sender, e) => await GetProcessesAsync();
            dgv.DataBindingComplete += (sender, e) => dgv.ClearSelection();
        }
        
        private async Task GetProcessesAsync()
        {
            var procs = await Task.Run(() => new ProcessInfoList());
            procs.Remove(procs.Single(p => p.Handle == Handle));
            processesBindingSource.DataSource = processes = procs;
        }

        private void ShowHelp()
        {
            const string helpMessage = @"
・「最前面」チェックボックスをクリックで
　各ウィンドウの「常に最前面に表示」状態を切り替えます。

・各列をダブルクリックすると各ウィンドウをアクティブにします。

・状態は
　「Normal」	が 標準
　「Minimized」	が 最小化
　「Maximized」	が 最大化 にそれぞれ対応し、
　切り替えた後に他のボタン等をクリックすることで反映されます。

・画面左下の「pin」をON/OFFすると
　本プログラム自体の「常に最前面に表示」状態を切り替えます。
　最前面表示した他のアプリケーションの後ろに
　隠れてしまうことがあるため、OFFにするのは推奨しません。
　デフォルトはONです。

・プログラムを新しく起動したり終了したりで
　Windowsが管理しているウィンドウ数に変化があった場合、
　画面右下の「再読込」をクリックすることで最新の状態を反映します。

※複数のプログラムが「常に最前面に表示」状態の場合は、
　より後にアクティブになったウィンドウが前面に表示されます。
";
            MessageBox.Show(helpMessage.Trim(), "ヘルプ");
        }

        private async Task ReloadAsync() => await GetProcessesAsync();

        private void dgv_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var self = sender as DataGridView;

            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            if (self.Columns[e.ColumnIndex].DataPropertyName == nameof(WindowState))
            {
                var cell = self[e.ColumnIndex, e.RowIndex] as DataGridViewComboBoxCell;
                cell.DataSource = (WindowState[])Enum.GetValues(typeof(WindowState));
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var self = sender as DataGridView;

            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            if (self.Columns[e.ColumnIndex].DataPropertyName == nameof(TopMost))
            {
                var @checked = (bool)self[e.ColumnIndex, e.RowIndex].Value;
                processes[e.RowIndex].TopMost = !@checked;
                TopMost = selfPinning.Checked;
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            processes[e.RowIndex].TopMost = processes[e.RowIndex].TopMost; // 再代入によって最前面に
        }

        private void selfPinning_CheckedChanged(object sender, EventArgs e)
            => TopMost = (sender as CheckBox).Checked;

        private void help_Click(object sender, EventArgs e) => ShowHelp();

        private async void reload_Click(object sender, EventArgs e) => await ReloadAsync();
    }
}
