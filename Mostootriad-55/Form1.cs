using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mostootriad_55
{
    public partial class Form1 : Form
    {
        public int clickDropDown = 0;
        public Form1()
        {
            InitializeComponent();
            this.toolStripButton1.MouseEnter += new System.EventHandler(this.toolStripButton1_MouseEnter);
            this.toolStripButton1.MouseLeave += new System.EventHandler(this.toolStripButton1_MouseLeave);

            this.toolStripButton2.MouseEnter += new System.EventHandler(this.toolStripButton2_MouseEnter);
            this.toolStripButton2.MouseLeave += new System.EventHandler(this.toolStripButton2_MouseLeave);

            this.toolStripButton3.MouseEnter += new System.EventHandler(this.toolStripButton3_MouseEnter);
            this.toolStripButton3.MouseLeave += new System.EventHandler(this.toolStripButton3_MouseLeave);

            this.toolStripDropDownButton1.MouseEnter += new System.EventHandler(this.toolStripDropDownButton1_MouseEnter);
            this.toolStripDropDownButton1.MouseLeave += new System.EventHandler(this.toolStripDropDownButton1_MouseLeave);
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_MouseDropDownOpen);
            this.toolStripDropDownButton1.DropDown.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.toolStripDropDownButton1_Clolsed);

            this.toolStripDropDownButton2.MouseEnter += new System.EventHandler(this.toolStripDropDownButton2_MouseEnter);
            this.toolStripDropDownButton2.MouseLeave += new System.EventHandler(this.toolStripDropDownButton2_MouseLeave);
            this.toolStripDropDownButton2.Click += new System.EventHandler(this.toolStripDropDownButton2_MouseDropDownOpen);
            this.toolStripDropDownButton2.DropDown.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.toolStripDropDownButton2_Clolsed);

            Data.EventHandlerComboBoxDocumentSellers = new Data.MyEventComboBoxDocument(ChildActivate);
            Data.EventHandlerComboBoxDocument = new Data.MyEventComboBoxDocument(ChildActivate);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedIndexChanged);
        }
        /// <summary>
        /// ToolBar Button1 Connect
        /// </summary>
        private void toolStripButton1_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton1.BackgroundImage = null;
            toolStripButton1.Image= ((System.Drawing.Image)(Properties.Resources.connect));   
        }
        private void toolStripButton1_MouseLeave(object sender, EventArgs e)
        {
           toolStripButton1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.connect));
           toolStripButton1.Image = null;
        }
        /// <summary>
        /// ToolBar Button2 Company
        /// </summary>
        private void toolStripButton2_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton2.BackgroundImage = null;
            toolStripButton2.Image = ((System.Drawing.Image)(Properties.Resources._1));
        }
        private void toolStripButton2_MouseLeave(object sender, EventArgs e)
        {
            toolStripButton2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1));
            toolStripButton2.Image = null;
        }
         /// <summary>
        /// ToolBar Button3 Object
        /// </summary>
        private void toolStripButton3_MouseEnter(object sender, EventArgs e)
        {
            toolStripButton3.BackgroundImage = null;
            toolStripButton3.Image= ((System.Drawing.Image)(Properties.Resources.wheel));   
        }
        private void toolStripButton3_MouseLeave(object sender, EventArgs e)
        {
           toolStripButton3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.wheel));
           toolStripButton3.Image = null;
        }
        /// <summary>
        /// ToolBar Button Add documents
        /// </summary>
        private void toolStripDropDownButton1_MouseEnter(object sender, EventArgs e)
        {
            Image Add_diasbled = ((System.Drawing.Image)(Properties.Resources.document_add_icon));
            toolStripDropDownButton1.BackgroundImage = null;       
            toolStripDropDownButton1.Image = Add_diasbled;
        }
        private void toolStripDropDownButton1_MouseLeave(object sender, EventArgs e)
        {
            Image Add_diasbled = ((System.Drawing.Image)(Properties.Resources.document_add_icon));
            if (clickDropDown > 0)
            {
                toolStripDropDownButton1.BackgroundImage = null;
                toolStripDropDownButton1.Image = Add_diasbled;
                clickDropDown = 0;
            }
            else
            {
                toolStripDropDownButton1.BackgroundImage = Add_diasbled;
                toolStripDropDownButton1.Image = null;
            }    
        }
        private void toolStripDropDownButton1_MouseDropDownOpen(object sender, EventArgs e)
        {
            clickDropDown++;
        }
        private void toolStripDropDownButton1_Clolsed(object sender, EventArgs e)
        {
            Image Add_diasbled = ((System.Drawing.Image)(Properties.Resources.document_add_icon));
            toolStripDropDownButton1.BackgroundImage = Add_diasbled;
            toolStripDropDownButton1.Image = null;
        }
        /// <end> ///
        ////////////
        /// /// <summary>
        /// ToolBar Button Scan documents
        /// </summary>
        private void toolStripDropDownButton2_MouseEnter(object sender, EventArgs e)
        {
            Image Add_diasbled = ((System.Drawing.Image)(Properties.Resources.blue_scanner));
            toolStripDropDownButton2.BackgroundImage = null;
            toolStripDropDownButton2.Image = Add_diasbled;
        }
        private void toolStripDropDownButton2_MouseLeave(object sender, EventArgs e)
        {
            Image Add_diasbled = ((System.Drawing.Image)(Properties.Resources.blue_scanner));
            if (clickDropDown > 0)
            {
                toolStripDropDownButton2.BackgroundImage = null;
                toolStripDropDownButton2.Image = Add_diasbled;
                clickDropDown = 0;
            }
            else
            {
                toolStripDropDownButton2.BackgroundImage = Add_diasbled;
                toolStripDropDownButton2.Image = null;
            }
        }
        private void toolStripDropDownButton2_MouseDropDownOpen(object sender, EventArgs e)
        {
            clickDropDown++;
        }
        private void toolStripDropDownButton2_Clolsed(object sender, EventArgs e)
        {
            Image Add_diasbled = ((System.Drawing.Image)(Properties.Resources.blue_scanner));
            toolStripDropDownButton2.BackgroundImage = Add_diasbled;
            toolStripDropDownButton2.Image = null;
        }
        /// <end> ///
        /////////////
        void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                MdiChildren[0].Activate();
            }
            if (toolStripComboBox1.SelectedIndex == 1)
            {
                MdiChildren[1].Activate();
            }
        }
        private void ChildActivate(int i)
        {
            if (i > 0)
            {
                toolStripComboBox1.SelectedIndex = 1;
            }
            else { toolStripComboBox1.SelectedIndex = 0; }
        }
        private void NotifyAboutClosedChildForm(object sender, FormClosedEventArgs args)
        {
            if (mdlData.WindowChildCustomer == false && mdlData.WindowChildSellers == false)
            {
                //редактироватьToolStripMenuItem.Visible = false;
                видToolStripMenuItem.Visible = false;
                AddToolStripMenuItem.Enabled = false;
                OpenToolStripMenuItem.Enabled = false;

                toolStripDropDownButton1.Enabled = false;
                toolStripDropDownButton1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.document_add_icon_disabled));
                toolStripDropDownButton1.Image = null;

                toolStripButton2.Enabled = false;
                toolStripButton2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1_disabled));
                toolStripButton2.Image = null;

                toolStripButton3.Enabled = false;
                toolStripButton3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.wheel2));
                toolStripButton3.Image = null;

                toolStripComboBox1.Enabled = false;
                toolStripComboBox1.Items.Clear();
            }
            if (mdlData.WindowChildCustomer == false && mdlData.WindowChildSellers == true)
            {
                toolStripComboBox1.Items.RemoveAt(0);
            }
            if (mdlData.WindowChildSellers == false && mdlData.WindowChildCustomer == true)
            {
                toolStripComboBox1.Items.RemoveAt(1);
            }
        }
        private void HorizontallyTileMyWindows(object sender, System.EventArgs e)
        {
            // Tile all child forms horizontally.
            HorizToolStripMenuItem.CheckState = CheckState.Checked;
            VerticToolStripMenuItem.CheckState = CheckState.Unchecked;
            CascadToolStripMenuItem.CheckState = CheckState.Unchecked;
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void VerticallyTileMyWindows(object sender, System.EventArgs e)
        {
            // Tile all child forms vertically.
            HorizToolStripMenuItem.CheckState = CheckState.Unchecked;
            VerticToolStripMenuItem.CheckState = CheckState.Checked;
            CascadToolStripMenuItem.CheckState = CheckState.Unchecked;
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void CascadeMyWindows(object sender, System.EventArgs e)
        {
            // Cascade all MDI child windows.
            HorizToolStripMenuItem.CheckState = CheckState.Unchecked;
            VerticToolStripMenuItem.CheckState = CheckState.Unchecked;
            CascadToolStripMenuItem.CheckState = CheckState.Checked;
            this.LayoutMdi(MdiLayout.Cascade);
        }
        //Объявление глобальных виртуальных таблиц
        public DataTable TabCustomer = new DataTable();
        public DataTable TabSellers = new DataTable();
        public DataTable TabObject = new DataTable();
        public DataTable TabCompany = new DataTable();
        //Процедура заполнения виртуальных таблиц данными из базы данных
        private void InnerTableFill(string TabName, ref DataTable Tab, string Key = "")
        {
            Tab.Clear();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = mdlData.cnn.CreateCommand();
            cmd.Connection = mdlData.cnn;
            if (Key != "")
            {
                cmd.CommandText = "Select * from [" + TabName + "] order by [" + Key + "]";
            }
            else
            {
                cmd.CommandText = "Select * from [" + TabName + "]";
            }
            da.SelectCommand = cmd; //Передаем SQL-запрос в адаптер
            da.Fill(Tab); //Заполняем таблицу
        }
        // Процедура заполнения пустыми множествами коллекций по 
        // количеству сторк соответствующих таблиц баз данных
        private void CreateCollection()
        {
            mdlData.colCompany.Clear();
            IList<clsCompany> cCompany = new List<clsCompany>();
            for (int i = 1; i <= TabCompany.Rows.Count; i++)
            {
                clsCompany D = new clsCompany();
                cCompany.Add(D);
            }
            mdlData.colCompany = cCompany;
            mdlData.colSellers.Clear();
            IList<clsSellers> cSellers = new List<clsSellers>();
            for (int i = 1; i <= TabSellers.Rows.Count; i++)
            {
                clsSellers D = new clsSellers();
                cSellers.Add(D);
            }
            mdlData.colSellers = cSellers;
            mdlData.colCustomer.Clear();
            IList<clsCustomer> cCustomer = new List<clsCustomer>();
            for (int i = 1; i <= TabCustomer.Rows.Count; i++)
            {
                clsCustomer D = new clsCustomer();
                cCustomer.Add(D);
            }
            mdlData.colCustomer = cCustomer;
            mdlData.colObject.Clear();
            IList<clsObject> cObject = new List<clsObject>();
            for (int i = 1; i <= TabObject.Rows.Count; i++)
            {
                clsObject D = new clsObject();
                cObject.Add(D);
            }
            mdlData.colObject = cObject;
        }
        private void настройкиSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting Form = new Setting();
            Form.Owner = this;
            Form.ShowDialog();
        }
        //Процедура связи созданных коллекций. Заполняем коллекции.
        private void LinkingCollection()
        {
            //Заполняем коллекцию Компании
            for (int i = 1; i <= mdlData.colCompany.Count; i++)
            {
                mdlData.colCompany[i - 1].Initialize(TabCompany, i - 1);
            }
            //Заполняем коллекцию Объекты
            for (int i = 1; i <= mdlData.colObject.Count; i++)
            {
                mdlData.colObject[i - 1].Initialize(TabObject, i - 1);
            }
            //Заполняем коллекцию продавцы
            for (int i = 1; i <= mdlData.colSellers.Count; i++)
            {
                mdlData.colSellers[i - 1].Initialize(TabSellers, i - 1);
            }
            //Заполняем коллекцию покупатели
            for (int i = 1; i <= mdlData.colCustomer.Count; i++)
            {
                mdlData.colCustomer[i - 1].Initialize(TabCustomer, i - 1);
            }
        }      
        private void Form1_Load(object sender, EventArgs e)
        {       
            toolStripDropDownButton1.Enabled = false;
            toolStripDropDownButton1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.document_add_icon_disabled));
            toolStripDropDownButton1.Image = null;

            toolStripDropDownButton2.Enabled = false;
            toolStripDropDownButton2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.blue_scanner_disabled));
            toolStripDropDownButton2.Image = null;

            toolStripButton2.Enabled = false;
            toolStripButton2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1_disabled));
            toolStripButton2.Image = null;

            toolStripButton3.Enabled = false;
            toolStripButton3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.wheel2));
            toolStripButton3.Image = null;

            toolStripComboBox1.Enabled = false;
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Закрыть программу?", "Внимание",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.Exit();
            else
                return;
        }
        private void соединениеСБДToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdlData.ready = true;
            mdlData.CounterClear();
            mdlData.ConnectDataBase();
            if (mdlData.WindowChildCustomer == true || mdlData.WindowChildSellers == true)
            {
                MessageBox.Show("База уже загружена. Сначала закройте все окна.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }     
            //Проверяем есть ли таблицы в базе данных путем их последовательного открытия
            SqlCommand cmd = mdlData.cnn.CreateCommand();
            try
            {
                cmd.CommandText = "SELECT * FROM object";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM company";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM customer";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT * FROM sellers";
                cmd.ExecuteNonQuery();
                /*cmd.CommandText = "BACKUP DATABASE mo55 TO DISK = 'c:\\mo55documents\\mo55_" + DateTime.Now.ToString("ddMMyyyy--HH-mm-ss") + ".bak'";
                cmd.ExecuteNonQuery();*/
            }
            //В случае возникновения хотя бы одной ошибки, фиксируем ее
            catch (SqlException ex)
            {
                statusStrip1.Items.Clear();
                statusStrip1.Items.Add(DateTime.Now.ToLongTimeString() + ": " + ex.Message);
                mdlData.ready = false;
            }
            //Если все прошло успешно
            if (mdlData.ready != false)
            {
                редактироватьToolStripMenuItem.Visible = true;
                видToolStripMenuItem.Visible = true;
                //SaveToolStripMenuItem.Enabled = true;
                AddToolStripMenuItem.Enabled = true;
                OpenToolStripMenuItem.Enabled = true;

                toolStripDropDownButton1.Enabled = true;
                toolStripDropDownButton1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.document_add_icon));
                toolStripDropDownButton1.Image = null;

                toolStripDropDownButton2.Enabled = true;
                toolStripDropDownButton2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.blue_scanner));
                toolStripDropDownButton2.Image = null;

                toolStripButton2.Enabled = true;
                toolStripButton2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources._1));
                toolStripButton2.Image = null;

                toolStripButton3.Enabled = true;
                toolStripButton3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.wheel));
                toolStripButton3.Image = null;

                toolStripComboBox1.Enabled = true;

                InnerTableFill("Customer", ref TabCustomer); InnerTableFill("Sellers", ref TabSellers);
                InnerTableFill("Company", ref TabCompany); InnerTableFill("Object", ref TabObject);
                statusStrip1.Items.Add(DateTime.Now.ToLongTimeString() + ConsoleMessageBox.LoadDBTrue);
                CreateCollection();
                LinkingCollection();
                statusStrip1.Items.Clear();
                statusStrip1.Items.Add(DateTime.Now.ToLongTimeString() + ConsoleMessageBox.LoadCollTrue);
                mdlData.cnn.Close();
                statusStrip1.Items.Clear();
                statusStrip1.Items.Add(DateTime.Now.ToLongTimeString() + ConsoleMessageBox.SessionClose);

                toolStripComboBox1.Items.Add("Покупатели");
                toolStripComboBox1.Items.Add("Продавцы");

                DocCustomerPdf new2MDIChild = new DocCustomerPdf();
                new2MDIChild.MdiParent = this;
                new2MDIChild.FormClosed += new FormClosedEventHandler(NotifyAboutClosedChildForm);             
                new2MDIChild.Show();
                
                DocPdf newMDIChild = new DocPdf();
                newMDIChild.MdiParent = this;
                newMDIChild.FormClosed += new FormClosedEventHandler(NotifyAboutClosedChildForm);     
                newMDIChild.Show();

                HorizontallyTileMyWindows(sender, e);
            }
            else { statusStrip1.Items.Add(DateTime.Now.ToLongTimeString() + ConsoleMessageBox.LoadDBFalse); }
        }
        //Добавление компании
        private void CompanyAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCompany Form = new AddCompany();
            Form.Owner = this;
            Form.Show();
            Data.EventHandlerCompany();
            Data.EventHandlerCompanySellers();
        }
        private void объектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddObject Form = new AddObject();
            Form.Owner = this;
            Form.Show();
        }
        private void покупательToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdlData.StatusAdd = false;
            AddCustomer Form = new AddCustomer();
            Form.Owner = this;
            Form.Show();
            if (mdlData.StatusAdd != false)
            {
                Data.EventHandler(addI.Value,addI.Value_ObjectN,addI.Value_Client,addI.Value_Performer);
            }
        }
        private void продавецToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mdlData.StatusAdd = false;
            AddSellers Form = new AddSellers();
            Form.Owner = this;
            Form.Show();
            if (mdlData.StatusAdd != false)
            {
                Data.EventHandlerSellers(addI.Value, addI.Value_ObjectN, addI.Value_Client, addI.Value_Performer);
            }
        }
        private void HorizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HorizontallyTileMyWindows(sender, e);
        }
        private void VerticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerticallyTileMyWindows(sender, e);
        }
        private void CascadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CascadeMyWindows(sender, e);
        }
        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void параметрыSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting Form = new Setting();
            Form.Owner = this;
            Form.ShowDialog();
        }
        private void настройкаПапкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettingFolder Form = new frmSettingFolder();
            Form.Owner = this;
            Form.ShowDialog();
        }

        private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Object Form = new Object();
            Form.Owner = this;
            Form.Show();
        }
        private void компанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyOpen Form = new CompanyOpen();
            Form.Owner = this;
            Form.Show();
            Data.EventHandlerCompany();
            Data.EventHandlerCompanySellers();
        }
        private void мО55БухгалтерияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About Form = new About();
            Form.Owner = this;
            Form.Show();
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            соединениеСБДToolStripMenuItem_Click(sender, e);
        }
        private void продавцыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            продавецToolStripMenuItem_Click(sender, e);
        }
        private void покупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            покупательToolStripMenuItem_Click(sender, e);
        }
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
          //...
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            компанииToolStripMenuItem_Click(sender, e);
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            объектыToolStripMenuItem_Click(sender, e);
        }
        private void покупателиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ScanSelectCustomerValue Form = new ScanSelectCustomerValue();
            Form.Owner = this;
            Form.ShowDialog();
            if (mdlData.StatusAdd != false)
            {
                Data.EventHandler(addI.Value, addI.Value_ObjectN, addI.Value_Client, addI.Value_Performer);
                mdlData.DeleteFileScan();
            }
        }
        private void продавцыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ScanSelectSellersValue Form = new ScanSelectSellersValue();
            Form.Owner = this;
            Form.ShowDialog();
            if (mdlData.StatusAdd != false)
            {
                Data.EventHandlerSellers(addI.Value, addI.Value_ObjectN, addI.Value_Client, addI.Value_Performer);
                mdlData.DeleteFileScan();
            }
        }
    }
}
