using System.Windows.Forms;

namespace MyApp
{
    public class DataGridViewComboBoxCellEx : DataGridViewComboBoxCell
    {
        protected override void OnClick(DataGridViewCellEventArgs e)
        {
            var dgv = DataGridView;
            dgv.CurrentCell = dgv[e.ColumnIndex, e.RowIndex];

            if (GetValue(e.RowIndex) != Value)
            {
                Value = GetValue(e.RowIndex);
                SetValue(e.RowIndex, Value);
            }

            base.OnClick(e);
        }
    }

    public class DataGridViewComboBoxColumnEx : DataGridViewComboBoxColumn
    {
        //public DataGridViewComboBoxColumnEx()
        //{
        //    this.DefaultHeaderCellType = typeof(DataGridViewComboBoxCellEx);
        //}
    }
}
