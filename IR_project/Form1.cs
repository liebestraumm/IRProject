using System;
using System.Windows.Forms;
using System.Diagnostics;
using IR_project.cls;

namespace IR_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Log;
        System.Collections.ArrayList ResultSet;
        int ResultInPage = 10;
        Searching searching;
        SaveResults SaveResults;
        int QueryID = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            collectionPathLBL.Text = ShowBrowsingDialog();
            if (collectionPathLBL.Text != string.Empty)
                indexBTN.Enabled = true;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (searchTXT.Text == string.Empty)
                return;

            indexBTN.Enabled = false;
            collBTN.Enabled = false;
            nextBTN.Enabled = true;
            preBTN.Enabled = true;
                        

            PageLBL.Text = "1";
            pageCountLBL.Text = "1";

            txtbx.Text = Log="";

            Init init = new Init();
            init.setCollectionPath(collectionPathLBL.Text);
            init.setIndexPath(indexPathLBL.Text);

            Stopwatch stopwatch = Stopwatch.StartNew();

            Indexing idx = new Indexing(init);

            stopwatch.Stop();

            Stopwatch watch2 = Stopwatch.StartNew();
            searching = new Searching(init, idx.getluceneIndexDirectory(), searchTXT.Text, (++QueryID).ToString());
            stopwatch.Stop();

            Log += "Indexing has been completed suceessfully in " + stopwatch.ElapsedMilliseconds+ " Milliseconds\n";
            Log += "Searching has been completed suceessfully in " + watch2.ElapsedMilliseconds + " Milliseconds";
            Log += searching.Log + "\nResult in page: "+ ResultInPage+
                "\r\n=========================================";

            SaveResults = new SaveResults(searching);

            //txtbx.Text += idx.Output;

            ResultSet = searching.GetResultSet();
            txtbx.Text = Log + ResultStrBuilder(1);
            pageCountLBL.Text = GetPageCount().ToString();

            if (savinResultsLBL.Text != string.Empty)
            {
                resPathBTN.Enabled = false;
                if (ResultSet.Count != 0)
                    resBTN.Enabled = true;
            }
            else {
                resPathBTN.Enabled = true;
            }

   
        }

        private int GetPageCount() {
            return Convert.ToInt32(Math.Ceiling((float)ResultSet.Count / ResultInPage));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            indexPathLBL.Text = ShowBrowsingDialog();
            if (indexPathLBL.Text != string.Empty)
                goBTN.Enabled = true;
                resPathBTN.Enabled = false;
            //Log += "Index directory is : " + INDEX_PATH + "\r\n";
        }

        private string ShowBrowsingDialog() {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            System.Windows.Forms.DialogResult dlgRes= dlg.ShowDialog();

            if (dlgRes == DialogResult.Cancel)
                return String.Empty;

            return dlg.SelectedPath;

            /*
                        // Create OpenFileDialog 
            OpenFileDialog dlg = new OpenFileDialog();

            // Set filter for file extension and default file extension 
           // dlg.DefaultExt = ".png";
           // dlg.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";

            dlg.ShowDialog();

            COLLECTION_PATH = dlg.FileName;
            
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int pagenum = Int32.Parse(PageLBL.Text) + 1;
            string str= ResultStrBuilder(pagenum);
            if (pagenum<= GetPageCount())
            {
                txtbx.Text = Log + str;
                PageLBL.Text = pagenum.ToString();
            }
        }

        private void txtbx_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.FileName = "MyIR_Result";
            dlg.DefaultExt = "txt";
            dlg.ValidateNames = true;
            dlg.Filter = "Text file|*.txt";
            System.Windows.Forms.DialogResult IsSaved = dlg.ShowDialog();

            if (IsSaved == DialogResult.OK)
            {
                savinResultsLBL.Text= dlg.FileName;
                if (searchTXT.Text != string.Empty)
                  resBTN.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SaveResults.Save(savinResultsLBL.Text);
            MessageBox.Show("Current result has been saved");
            resPathBTN.Enabled = false;
            resBTN.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int pagenum = Int32.Parse(PageLBL.Text) - 1;
            if (pagenum != 0) {
                txtbx.Text = Log + ResultStrBuilder(pagenum);
                PageLBL.Text = pagenum.ToString();
            }
        }

        private string ResultStrBuilder(int PageNumber)
        {
            string res="";
            int ResultSetCount = ResultSet.Count;

            int max_i = PageNumber * ResultInPage;

            if (ResultSetCount < max_i)
                max_i = ResultSetCount;

            int min_i = (PageNumber-1)* ResultInPage;

            for (int i=min_i; i < max_i;i++)
            {
                res+= "\r\n"+ResultSet[i]+
                "\r\n--------------------------------------------------------\r\n";
            }
            return res;
        }
    }
}
