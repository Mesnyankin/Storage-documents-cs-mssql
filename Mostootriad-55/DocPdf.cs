//////////////////////////////////////////////////////////////
/*DataGridViewLinkColumn act = new DataGridViewLinkColumn();
          act.ActiveLinkColor = Color.White;
          act.LinkBehavior = LinkBehavior.SystemDefault;
          act.LinkColor = Color.Blue;
          act.HeaderText = "Акты";
          act.TrackVisitedState = true;
          act.VisitedLinkColor = Color.YellowGreen;
          act.DataPropertyName = "pdf_act";
          act.Name = "Акты";
          act.UseColumnTextForLinkValue = true;
          act.Text = "Открыть Акты";
          dataGridView1.Columns.Add(act);*/
/////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mostootriad_55
{
    public partial class DocPdf : Form
    {
        int pageSize = 15; // размер страницы(колличество записей)
        int pageNumber = 0;
        int pgNum = 1;
        public int idClient, idPerformer;
        public bool filterClientPerformer = false, filterClient = false, filterPerformer = false, filterDog = false, filterDate = false, filterDataClientPerformer = false;
        public DocPdf()
        {
            InitializeComponent();
            Data.EventHandlerSellers = new Data.MyEvent(dataGridViewAddRow);
            Data.EventHandlerCompanySellers = new Data.MyEventCompany(comboBoxUpdate);
        }
        // Процедура очистки DataGrid;
        public void clear()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectAll();
            dataGridView1.ClearSelection();
            dataGridView1.Columns.Clear();
        }
        public void UpdateSourceGrid()
        {
            clear();
            PrintColumns();
            PrintCollection();
        }
        private void DocPdf_Activated(object sender, EventArgs e)
        {
            if(mdlData.WindowChildCustomer == true)
            {
                addI.Value_ComboBoxDocument = 1;
                Data.EventHandlerComboBoxDocumentSellers(addI.Value_ComboBoxDocument);
            }
            else
            {
                addI.Value_ComboBoxDocument = 0;
                Data.EventHandlerComboBoxDocumentSellers(addI.Value_ComboBoxDocument);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = e.RowIndex;
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == 6)
                {
                    if (dataGridView1.Rows[row].Cells[7].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[7].Value.ToString() != "")
                    {
                        System.Diagnostics.Process.Start(dataGridView1.Rows[row].Cells[7].Value.ToString());
                    }
                }
                if (e.ColumnIndex == 8)
                {
                    if (dataGridView1.Rows[row].Cells[9].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[9].Value.ToString() != "")
                    {
                        System.Diagnostics.Process.Start(dataGridView1.Rows[row].Cells[9].Value.ToString());
                    }
                }
                if (e.ColumnIndex == 10)
                {
                    if (dataGridView1.Rows[row].Cells[11].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[11].Value.ToString() != "")
                    {
                        System.Diagnostics.Process.Start(dataGridView1.Rows[row].Cells[11].Value.ToString());
                    }
                }
                if (e.ColumnIndex == 12)
                {
                    if (dataGridView1.Rows[row].Cells[13].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[13].Value.ToString() != "")
                    {
                        System.Diagnostics.Process.Start(dataGridView1.Rows[row].Cells[13].Value.ToString());
                    }
                }
                if (e.ColumnIndex == 14)
                {
                    if (dataGridView1.Rows[row].Cells[15].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[15].Value.ToString() != "")
                    {
                        System.Diagnostics.Process.Start(dataGridView1.Rows[row].Cells[15].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не могу открыть файл: " + ex.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dataGridView1_MouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = e.RowIndex;
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == 6)
                {
                    if (dataGridView1.Rows[row].Cells[7].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[7].Value.ToString() != "")
                    {
                        dataGridView1.Rows[row].Cells[6].Style.Font = new Font(dataGridView1.Font, FontStyle.Regular);
                        dataGridView1.Cursor = Cursors.Hand;
                    }
                }
                if (e.ColumnIndex == 8)
                {
                    if (dataGridView1.Rows[row].Cells[9].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[9].Value.ToString() != "")
                    {
                        dataGridView1.Rows[row].Cells[8].Style.Font = new Font(dataGridView1.Font, FontStyle.Regular);
                        dataGridView1.Cursor = Cursors.Hand;
                    }
                }
                if (e.ColumnIndex == 10)
                {
                    if (dataGridView1.Rows[row].Cells[11].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[11].Value.ToString() != "")
                    {
                        dataGridView1.Rows[row].Cells[10].Style.Font = new Font(dataGridView1.Font, FontStyle.Regular);
                        dataGridView1.Cursor = Cursors.Hand;
                    }
                }
                if (e.ColumnIndex == 12)
                {
                    if (dataGridView1.Rows[row].Cells[13].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[13].Value.ToString() != "")
                    {
                        dataGridView1.Rows[row].Cells[12].Style.Font = new Font(dataGridView1.Font, FontStyle.Regular);
                        dataGridView1.Cursor = Cursors.Hand;
                    }
                }
                if (e.ColumnIndex == 14)
                {
                    if (dataGridView1.Rows[row].Cells[15].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[15].Value.ToString() != "")
                    {
                        dataGridView1.Rows[row].Cells[14].Style.Font = new Font(dataGridView1.Font, FontStyle.Regular);
                        dataGridView1.Cursor = Cursors.Hand;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_MouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int row;
            row = e.RowIndex;
            try
            {
                if (e.RowIndex < 0)
                    return;
                if (e.ColumnIndex == 6)
                {
                    if (dataGridView1.Rows[row].Cells[7].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[7].Value.ToString() != "")
                    {
                        dataGridView1.Rows[row].Cells[6].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
                        dataGridView1.Cursor = Cursors.Default;
                    }
                }
                if (e.ColumnIndex == 8)
                {
                    if (dataGridView1.Rows[row].Cells[9].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[9].Value.ToString() != "")
                    {
                        dataGridView1.Rows[row].Cells[8].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
                        dataGridView1.Cursor = Cursors.Default;
                    }
                }
                if (e.ColumnIndex == 10)
                {
                    if (dataGridView1.Rows[row].Cells[11].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[11].Value.ToString() != "")
                    {
                        dataGridView1.Rows[row].Cells[10].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
                        dataGridView1.Cursor = Cursors.Default;
                    }
                }
                if (e.ColumnIndex == 12)
                {
                    if (dataGridView1.Rows[row].Cells[13].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[13].Value.ToString() != "")
                    {
                        dataGridView1.Rows[row].Cells[12].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
                        dataGridView1.Cursor = Cursors.Default;
                    }
                }
                if (e.ColumnIndex == 14)
                {
                    if (dataGridView1.Rows[row].Cells[15].Value == null) { return; }
                    if (dataGridView1.Rows[row].Cells[15].Value.ToString() != "")
                    {
                        dataGridView1.Rows[row].Cells[14].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
                        dataGridView1.Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                var v = dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString();
                int row;
                row = e.RowIndex;
                EditSellers FormEdit = new EditSellers();
                FormEdit.Owner = this;
                FormEdit.ID = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);
                FormEdit.NameObj = dataGridView1.Rows[row].Cells[1].Value.ToString();
                FormEdit.NameClient = dataGridView1.Rows[row].Cells[2].Value.ToString();
                FormEdit.NamePerformer = dataGridView1.Rows[row].Cells[3].Value.ToString();
                FormEdit.Show();
                //запоминаешь индекс выделенной строки
                int currIndex = 0;
                currIndex = dataGridView1.CurrentRow.Index;
                //Обновляем DataGrid
                if (mdlData.statusEdit != false)
                {
                    UpdateSourceGrid();
                    mdlData.statusEdit = false;
                }
                //После обновления возвращаем индекс:
                dataGridView1.ClearSelection();
                dataGridView1.Rows[currIndex].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = currIndex;
            }
        }
        //Процедура вывода в DataGridView заполненных коллекций
        private void PrintColumns()
        {
            dataGridView1.Columns.Add("ID", "№");
            dataGridView1.Columns.Add("ObjectN", "Объект");
            dataGridView1.Columns.Add("Client", "Заказчик");
            dataGridView1.Columns.Add("Performer", "Исполнитель");
            dataGridView1.Columns.Add("ContractNumber", "Номер основания");
            dataGridView1.Columns.Add("dateDoc", "Дата");
            dataGridView1.Columns.Add("pdf_kc", "КС-2/КС-3");
            dataGridView1.Columns.Add("link_kc", "КС-2/КС-3"); //скрыт 7 - столбец
            dataGridView1.Columns.Add("pdf_invoice", "Счет-фактура");
            dataGridView1.Columns.Add("link_invoice", "Счет-фактура");// скрыт 9 - столбец
            dataGridView1.Columns.Add("pdf_dog", "Основание");
            dataGridView1.Columns.Add("link_dog", "ссылка_дог");//скрыт 11-столбец
            dataGridView1.Columns.Add("pdf_consignment", "Накладные");
            dataGridView1.Columns.Add("link_consignment", "ссылка_Накладные");//скрыт 13-столбец
            dataGridView1.Columns.Add("pdf_act", "Акты");
            dataGridView1.Columns.Add("link_act", "ссылка_акты");//скрыт 15-столбец
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.OrangeRed;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.DimGray;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.BlueViolet;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[5].DefaultCellStyle.ForeColor = Color.OrangeRed;
            dataGridView1.Columns[6].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[8].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[10].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[12].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[14].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[13].Visible = false;
            dataGridView1.Columns[15].Visible = false;
        }
        public void dataGridViewAddRow(int i, string ObjectN, string Client, string Performer)
        {
            int row = i - 1;
            string value_kc, value_invoice, value_dog, value_consignment, value_act;
            if (mdlData.colSellers[row].pdf_kc == "" || mdlData.colSellers[row].pdf_kc == null)
            {
                value_kc = mdlData.LoadDisable;
            }
            else { value_kc = mdlData.LoadKc; }
            if (mdlData.colSellers[row].pdf_invoice == "" || mdlData.colSellers[row].pdf_invoice == null)
            {
                value_invoice = mdlData.LoadDisable;
            }
            else { value_invoice = mdlData.LoadInvoice; }
            if (mdlData.colSellers[row].pdf_dog == "" || mdlData.colSellers[row].pdf_dog == null)
            {
                value_dog = mdlData.LoadDisable;
            }
            else { value_dog = mdlData.LoadDog; }
            if (mdlData.colSellers[row].pdf_consignment == "" || mdlData.colSellers[row].pdf_consignment == null)
            {
                value_consignment = mdlData.LoadDisable;
            }
            else { value_consignment = mdlData.LoadСonsignment; }
            if (mdlData.colSellers[row].pdf_act == "" || mdlData.colSellers[row].pdf_act == null)
            {
                value_act = mdlData.LoadDisable;
            }
            else { value_act = mdlData.LoadAct; }
            dataGridView1.Rows.Add(mdlData.colSellers[row].ID,
                                     ObjectN,
                                     Client,
                                     Performer,
                                     mdlData.colSellers[row].ContractNumber,
                                     Convert.ToDateTime(mdlData.colSellers[row].dateDoc).ToString("dd MMMM yyyy"),
                                     value_kc,
                                     mdlData.colSellers[row].pdf_kc,
                                     value_invoice,
                                     mdlData.colSellers[row].pdf_invoice,
                                     value_dog,
                                     mdlData.colSellers[row].pdf_dog,
                                     value_consignment,
                                     mdlData.colSellers[row].pdf_consignment,
                                     value_act,
                                     mdlData.colSellers[row].pdf_act);
            row = dataGridView1.RowCount - 1;
            if (dataGridView1.Rows[row].Cells[6].Value.ToString() == mdlData.LoadDisable)
            {
                dataGridView1.Rows[row].Cells[6].Style.ForeColor = Color.Black;
                dataGridView1.Rows[row].Cells[6].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else
            {
                dataGridView1.Rows[row].Cells[6].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
            }
            if (dataGridView1.Rows[row].Cells[8].Value.ToString() == mdlData.LoadDisable)
            {
                dataGridView1.Rows[row].Cells[8].Style.ForeColor = Color.Black;
                dataGridView1.Rows[row].Cells[8].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else
            {
                dataGridView1.Rows[row].Cells[8].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
            }
            if (dataGridView1.Rows[row].Cells[10].Value.ToString() == mdlData.LoadDisable)
            {
                dataGridView1.Rows[row].Cells[10].Style.ForeColor = Color.Black;
                dataGridView1.Rows[row].Cells[10].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else
            {
                dataGridView1.Rows[row].Cells[10].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
            }

            if (dataGridView1.Rows[row].Cells[12].Value.ToString() == mdlData.LoadDisable)
            {
                dataGridView1.Rows[row].Cells[12].Style.ForeColor = Color.Black;
                dataGridView1.Rows[row].Cells[12].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else
            {
                dataGridView1.Rows[row].Cells[12].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
            }

            if (dataGridView1.Rows[row].Cells[14].Value.ToString() == mdlData.LoadDisable)
            {
                dataGridView1.Rows[row].Cells[14].Style.ForeColor = Color.Black;
                dataGridView1.Rows[row].Cells[14].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            else
            {
                dataGridView1.Rows[row].Cells[14].Style.Font = new Font(dataGridView1.Font, FontStyle.Underline);
            }
            if (mdlData.StatusAdd != false)
            {
                mdlData.StatusAdd = false;
                UpdateSourceGrid();
                PageInfoBox();
            }
        }
        private void PageInfoBox()
        {
            int allpg;
            double allPageDbl = (double)mdlData.colSellers.Count / pageSize;
            int it = (int)allPageDbl;
            double fract = allPageDbl - it;
            if (fract != 0)
            {
                allpg = it + 1;
            }
            else { allpg = it; }
            label9.Text = allpg.ToString();
        }
        private void PrintCollection()
        {
            string ObjectN, Client, Performer;
            ObjectN = ""; Client = ""; Performer = "";
            //Выводим коллекцию покупателей
            if (filterClientPerformer != true && filterClient != true && filterPerformer != true && filterDog != true && filterDate != true && filterDataClientPerformer != true)
            {
                label6.Visible = true; label7.Visible = true; label8.Visible = true; label9.Visible = true;
                btnBack.Visible = true;
                btnNext.Visible = true;
                label6.Text = pgNum.ToString();
                int start = 1 + pageNumber;
                int end = pageSize + pageNumber;
                if (end >= mdlData.colSellers.Count)
                {
                    end = mdlData.colSellers.Count; btnNext.Enabled = false;
                }
                else { btnNext.Enabled = true; }
                if (start == 1)
                {
                    btnBack.Enabled = false;
                }
                else { btnBack.Enabled = true; }
                for (int i = start; i <= end; i++)
                {
                    for (int j = 0; j < mdlData.colObject.Count; j++)
                    {
                        if (mdlData.colObject[j].ID == mdlData.colSellers[i - 1].ObjectN)
                        {
                            ObjectN = mdlData.colObject[j].Name;
                        }
                    }
                    for (int j = 0; j < mdlData.colCompany.Count; j++)
                    {
                        if (mdlData.colCompany[j].ID == mdlData.colSellers[i - 1].Client)
                        {
                            Client = mdlData.colCompany[j].Name;
                        }
                        if (mdlData.colCompany[j].ID == mdlData.colSellers[i - 1].Performer)
                        {
                            Performer = mdlData.colCompany[j].Name;
                        }
                    }
                    dataGridViewAddRow(i, ObjectN, Client, Performer);
                }
            }
            else
            {
                label6.Visible = false; label7.Visible = false; label8.Visible = false; label9.Visible = false;
                btnBack.Enabled = false;
                btnNext.Enabled = false;


                for (int i = 1; i <= mdlData.colSellers.Count; i++)
                {
                    for (int j = 0; j < mdlData.colObject.Count; j++)
                    {
                        if (mdlData.colObject[j].ID == mdlData.colSellers[i - 1].ObjectN)
                        {
                            ObjectN = mdlData.colObject[j].Name;
                        }
                    }
                    if (filterClientPerformer != false)
                    {
                        if (mdlData.colSellers[i - 1].Client == idClient && mdlData.colSellers[i - 1].Performer == idPerformer)
                        {
                            for (int j = 0; j < mdlData.colCompany.Count; j++)
                            {
                                if (mdlData.colCompany[j].ID == idClient)
                                {
                                    Client = mdlData.colCompany[j].Name;
                                }
                                if (mdlData.colCompany[j].ID == idPerformer)
                                {
                                    Performer = mdlData.colCompany[j].Name;
                                }
                            }
                            dataGridViewAddRow(i, ObjectN, Client, Performer);
                        }
                    }
                    if (filterClient != false)
                    {
                        if (mdlData.colSellers[i - 1].Client == idClient)
                        {
                            for (int j = 0; j < mdlData.colCompany.Count; j++)
                            {
                                if (mdlData.colCompany[j].ID == idClient)
                                {
                                    Client = mdlData.colCompany[j].Name;
                                }
                                if (mdlData.colCompany[j].ID == mdlData.colSellers[i - 1].Performer)
                                {
                                    Performer = mdlData.colCompany[j].Name;
                                }
                            }
                            dataGridViewAddRow(i, ObjectN, Client, Performer);
                        }
                    }
                    if (filterPerformer != false)
                    {
                        if (mdlData.colSellers[i - 1].Performer == idPerformer)
                        {
                            for (int j = 0; j < mdlData.colCompany.Count; j++)
                            {
                                if (mdlData.colCompany[j].ID == idPerformer)
                                {
                                    Performer = mdlData.colCompany[j].Name;
                                }
                                if (mdlData.colCompany[j].ID == mdlData.colSellers[i - 1].Client)
                                {
                                    Client = mdlData.colCompany[j].Name;
                                }
                            }
                            dataGridViewAddRow(i, ObjectN, Client, Performer);
                        }
                    }
                    if (filterDog != false)
                    {
                        if (mdlData.colSellers[i - 1].ContractNumber == textBox1.Text)
                        {
                            for (int j = 0; j < mdlData.colCompany.Count; j++)
                            {
                                if (mdlData.colCompany[j].ID == mdlData.colSellers[i - 1].Client)
                                {
                                    Client = mdlData.colCompany[j].Name;
                                }
                                if (mdlData.colCompany[j].ID == mdlData.colSellers[i - 1].Performer)
                                {
                                    Performer = mdlData.colCompany[j].Name;
                                }
                            }
                            dataGridViewAddRow(i, ObjectN, Client, Performer);
                        }
                    }
                    if (filterDate != false)
                    {
                        DateTime dataIn = new DateTime();
                        DateTime dataOut = new DateTime();
                        DateTime dataSellers = new DateTime();
                        dataIn = Convert.ToDateTime(textBox2.Text);
                        dataOut = Convert.ToDateTime(textBox3.Text);
                        dataSellers = Convert.ToDateTime(mdlData.colSellers[i - 1].dateDoc);
                        if (dataSellers >= dataIn && dataSellers <= dataOut)
                        {
                            for (int j = 0; j < mdlData.colCompany.Count; j++)
                            {
                                if (mdlData.colCompany[j].ID == mdlData.colSellers[i - 1].Client)
                                {
                                    Client = mdlData.colCompany[j].Name;
                                }
                                if (mdlData.colCompany[j].ID == mdlData.colSellers[i - 1].Performer)
                                {
                                    Performer = mdlData.colCompany[j].Name;
                                }
                            }
                            dataGridViewAddRow(i, ObjectN, Client, Performer);
                        }
                    }
                    if (filterDataClientPerformer != false)
                    {
                        DateTime dataIn = new DateTime();
                        DateTime dataOut = new DateTime();
                        DateTime dataSerrers = new DateTime();
                        dataIn = Convert.ToDateTime(textBox2.Text);
                        dataOut = Convert.ToDateTime(textBox3.Text);
                        dataSerrers = Convert.ToDateTime(mdlData.colSellers[i - 1].dateDoc);
                        if (mdlData.colSellers[i - 1].Client == idClient && mdlData.colSellers[i - 1].Performer == idPerformer)
                        {
                            if (dataSerrers >= dataIn && dataSerrers <= dataOut)
                            {
                                for (int j = 0; j < mdlData.colCompany.Count; j++)
                                {
                                    if (mdlData.colCompany[j].ID == idClient)
                                    {
                                        Client = mdlData.colCompany[j].Name;
                                    }
                                    if (mdlData.colCompany[j].ID == idPerformer)
                                    {
                                        Performer = mdlData.colCompany[j].Name;
                                    }
                                }
                                dataGridViewAddRow(i, ObjectN, Client, Performer);
                            }
                        }
                    }
                }
            }
            
            if (dataGridView1.Rows.Count < 1)
            {
                btnEdit.Enabled = false; btnDel.Enabled = false;
                MessageBox.Show("Ничего не найдено!", "Поиск документа", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (dataGridView1.Rows.Count >= 1)
            {
                btnEdit.Enabled = true; btnDel.Enabled = true;
            }
        }
        private void comboBoxUpdate()
        {
            List<string> Company = new List<string>();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            for (int i = 0; i < mdlData.colCompany.Count; i++)
            {
                Company.Add(mdlData.colCompany[i].Name);
                Company.Sort();
            }
            for (int i = 0; i < Company.Count; i++)
            {
                comboBox1.Items.Add(Company[i]);
                comboBox2.Items.Add(Company[i]);
            }
        }
        private void comboBox1_MouseClick(object sender, EventArgs e)
        {
            //...
        }
        private void comboBox2_MouseClick(object sender, EventArgs e)
        {
           //...
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBox1.Text = ""; comboBox2.Text = "";
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = "";
        }

        private void btnDataFrom_Click(object sender, EventArgs e)
        {
            frmKalendarSellers fKalen = new frmKalendarSellers(this);
            fKalen.Owner = this;
            fKalen.ShowDialog();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            pgNum--;
            pageNumber = pageNumber - pageSize;
            if ((1 + pageNumber) <= 0) { pageNumber = 0; return; }
            UpdateSourceGrid();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pgNum++;
            pageNumber = pageNumber + pageSize;
            if ((1 + pageNumber) > mdlData.colSellers.Count)
            {
                if (dataGridView1.Rows.Count == pageSize)
                {
                    pageNumber = mdlData.colSellers.Count; return;
                }
                if (dataGridView1.Rows.Count < pageSize)
                {
                    pageNumber = mdlData.colSellers.Count - (dataGridView1.Rows.Count - pageSize); return;
                }
            }
            UpdateSourceGrid();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string iRowString;
                int row;
                iRowString = dataGridView1.SelectedRows[selectedRowCount - 1].Index.ToString();
                row = Convert.ToInt32(iRowString.ToString());
                EditSellers FormEdit = new EditSellers();
                FormEdit.Owner = this;
                FormEdit.ID = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);
                FormEdit.NameObj = dataGridView1.Rows[row].Cells[1].Value.ToString();
                FormEdit.NameClient = dataGridView1.Rows[row].Cells[2].Value.ToString();
                FormEdit.NamePerformer = dataGridView1.Rows[row].Cells[3].Value.ToString();
                FormEdit.Show();
                //запоминаешь индекс выделенной строки
                int currIndex = 0;
                currIndex = dataGridView1.CurrentRow.Index;
                //Обновляем DataGrid
                if (mdlData.statusEdit != false)
                {
                    UpdateSourceGrid();
                    //dataGridView1.Rows[row].DataGridView.Update();
                    mdlData.statusEdit = false;
                }
                //После обновления возвращаем индекс:
                dataGridView1.ClearSelection();
                dataGridView1.Rows[currIndex].Selected = true;
                dataGridView1.FirstDisplayedScrollingRowIndex = currIndex;
            }
        }
        /// <summary>
        /// Процедура удаления строки
        /// </summary>
        private void DataGridViewDeleleRow(int row)
        {
            int ID;
            ID = Convert.ToInt32(dataGridView1.Rows[row].Cells[0].Value);
            for (int j = 0; j < mdlData.colSellers.Count; j++)
            {
                if (mdlData.colSellers[j].ID == ID)
                {
                    mdlData.colSellers.Remove(mdlData.colSellers[j]);
                }
            }
            mdlData.ready = true;
            mdlData.ConnectDataBase();
            SqlCommand cmd = mdlData.cnn.CreateCommand();
            cmd.CommandText = "DELETE FROM sellers WHERE ID = '" + ID + "'";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Данные удаленны!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mdlData.cnn.Close();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string iRowString;
                int row;
                iRowString = dataGridView1.SelectedRows[selectedRowCount - 1].Index.ToString();
                row = Convert.ToInt32(iRowString.ToString());
                var result = MessageBox.Show("Вы уверены что хотите удалить данные?", "Внимание",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                    return;
                try
                {
                    DataGridViewDeleleRow(row);
                    //Обновляем DataGrid
                    UpdateSourceGrid();
                    PageInfoBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось удалить запись: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Процедура поиска по фильтрам
        /// </summary>
        private void btnFind_Click(object sender, EventArgs e)
        {
            clear(); PrintColumns();
            //Условие Заказчик - Исполнитель
            if (comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                //Поиск id компании заказчика и исполнителя по имени компании
                for (int k = 0; k < mdlData.colCompany.Count; k++)
                {
                    if (mdlData.colCompany[k].Name == comboBox1.Text)
                    {
                        idClient = mdlData.colCompany[k].ID;
                    }
                    if (mdlData.colCompany[k].Name == comboBox2.Text)
                    {
                        idPerformer = mdlData.colCompany[k].ID;
                    }
                }
                filterClientPerformer = true;
                PrintCollection();
                filterClientPerformer = false;
            }
            //Условие Заказчик
            if (comboBox1.Text != "" && comboBox2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                //Поиск id компании заказчика и исполнителя по имени компании
                for (int k = 0; k < mdlData.colCompany.Count; k++)
                {
                    if (mdlData.colCompany[k].Name == comboBox1.Text)
                    {
                        idClient = mdlData.colCompany[k].ID;
                    }
                }
                filterClient = true;
                PrintCollection();
                filterClient = false;
            }
            //Условие Исполнитель
            if (comboBox1.Text == "" && comboBox2.Text != "" && textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                //Поиск id компании заказчика и исполнителя по имени компании
                for (int k = 0; k < mdlData.colCompany.Count; k++)
                {
                    if (mdlData.colCompany[k].Name == comboBox2.Text)
                    {
                        idPerformer = mdlData.colCompany[k].ID;
                    }
                }
                filterPerformer = true;
                PrintCollection();
                filterPerformer = false;
            }
            //Условие Договор
            if (comboBox1.Text == "" && comboBox2.Text == "" && textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == "")
            {
                filterDog = true;
                PrintCollection();
                filterDog = false;
            }
            //Условие Дата
            if (comboBox1.Text == "" && comboBox2.Text == "" && textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "")
            {
                filterDate = true;
                PrintCollection();
                filterDate = false;
            }
            if ((comboBox1.Text == "" && comboBox2.Text == "" && textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "") || (comboBox1.Text == "" && comboBox2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != "")
               || (comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text == "" && textBox2.Text != "" && textBox3.Text == "") || (comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text == "" && textBox2.Text == "" && textBox3.Text != ""))
            {
                MessageBox.Show("Заполните дату в интервале", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Условие заказчик - исполнитель - дата
            if (comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "")
            {
                //Поиск id компании заказчика и исполнителя по имени компании
                for (int k = 0; k < mdlData.colCompany.Count; k++)
                {
                    if (mdlData.colCompany[k].Name == comboBox1.Text)
                    {
                        idClient = mdlData.colCompany[k].ID;
                    }
                    if (mdlData.colCompany[k].Name == comboBox2.Text)
                    {
                        idPerformer = mdlData.colCompany[k].ID;
                    }
                }
                filterDataClientPerformer = true;
                PrintCollection();
                filterDataClientPerformer = false;
            }
            //Условия все фильтры пусты
            if (comboBox1.Text == "" && comboBox2.Text == "" && textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                PrintCollection();
            }
            if ((comboBox1.Text != "" && comboBox2.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") || (comboBox1.Text == "" && comboBox2.Text == "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                || (comboBox1.Text == "" && comboBox2.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "") || (comboBox1.Text != "" && comboBox2.Text == "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                || (comboBox1.Text != "" && comboBox2.Text == "" && textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "") || (comboBox1.Text == "" && comboBox2.Text != "" && textBox1.Text == "" && textBox2.Text != "" && textBox3.Text != "")
                || (comboBox1.Text != "" && comboBox2.Text == "" && textBox1.Text != "" && textBox2.Text == "" && textBox3.Text == ""))
            {
                MessageBox.Show("Данное сочетание фильтров не предусмотрено ", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void SetText(string text)
        {
            if (textBox3.Text != "" && textBox2.Text != "")
            {
                textBox2.Text = "";
                textBox3.Text = "";
            }
            if (textBox2.Text == "")
            {
                textBox2.Text = text;
            }
            else { textBox3.Text = text; }
        }
        private void DocPdf_SizeChanged(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(this.Width, this.Height);
        }
        private void DocPdf_Load(object sender, EventArgs e)
        {
            UpdateSourceGrid();
            PageInfoBox();
            comboBoxUpdate();
            mdlData.WindowChildSellers = true;
        }     
        private void DocPdf_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mdlData.StatusAdd != false)
            {
                mdlData.StatusAdd = false;
            }
            if (MessageBox.Show("Закрыть окно Продавцы?", "Внимание",
            MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else { mdlData.WindowChildSellers = false; }
        }
    }
}