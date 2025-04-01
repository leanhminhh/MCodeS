namespace BookManV2
{
    partial class BookView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookView));
            toolStrip1 = new ToolStrip();
            toolStripButtonTest = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            numericUpDownPages = new NumericUpDown();
            numericUpDownYear = new NumericUpDown();
            textBoxISBN = new TextBox();
            textBoxPublisher = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxTitle = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButtonTest, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonTest
            // 
            toolStripButtonTest.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButtonTest.Image = (Image)resources.GetObject("toolStripButtonTest.Image");
            toolStripButtonTest.ImageTransparentColor = Color.Magenta;
            toolStripButtonTest.Name = "toolStripButtonTest";
            toolStripButtonTest.Size = new Size(29, 24);
            toolStripButtonTest.Text = "toolStripButton1";
            toolStripButtonTest.Click += toolStripButtonTest_Click_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(29, 24);
            toolStripButton3.Text = "toolStripButton3";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox1);
            splitContainer1.Size = new Size(800, 401);
            splitContainer1.SplitterDistance = 502;
            splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(499, 397);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDownPages);
            groupBox1.Controls.Add(numericUpDownYear);
            groupBox1.Controls.Add(textBoxISBN);
            groupBox1.Controls.Add(textBoxPublisher);
            groupBox1.Controls.Add(textBoxAuthor);
            groupBox1.Controls.Add(textBoxTitle);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(288, 400);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // numericUpDownPages
            // 
            numericUpDownPages.Location = new Point(85, 200);
            numericUpDownPages.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownPages.Name = "numericUpDownPages";
            numericUpDownPages.Size = new Size(89, 27);
            numericUpDownPages.TabIndex = 11;
            // 
            // numericUpDownYear
            // 
            numericUpDownYear.Location = new Point(85, 167);
            numericUpDownYear.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            numericUpDownYear.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            numericUpDownYear.Name = "numericUpDownYear";
            numericUpDownYear.Size = new Size(89, 27);
            numericUpDownYear.TabIndex = 10;
            numericUpDownYear.Value = new decimal(new int[] { 1990, 0, 0, 0 });
            // 
            // textBoxISBN
            // 
            textBoxISBN.Location = new Point(85, 134);
            textBoxISBN.Name = "textBoxISBN";
            textBoxISBN.Size = new Size(160, 27);
            textBoxISBN.TabIndex = 9;
            // 
            // textBoxPublisher
            // 
            textBoxPublisher.Location = new Point(85, 101);
            textBoxPublisher.Name = "textBoxPublisher";
            textBoxPublisher.Size = new Size(160, 27);
            textBoxPublisher.TabIndex = 8;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(85, 68);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(160, 27);
            textBoxAuthor.TabIndex = 7;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(85, 35);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(160, 27);
            textBoxTitle.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 207);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 5;
            label6.Text = "Pages";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 174);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 4;
            label5.Text = "Year";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 141);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "ISBN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 108);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Publisher";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 75);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Authors";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // BookView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Name = "BookView";
            Text = "Book Manager";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPages).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBoxISBN;
        private TextBox textBoxPublisher;
        private TextBox textBoxAuthor;
        private TextBox textBoxTitle;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownPages;
        private NumericUpDown numericUpDownYear;
        private ToolStripButton toolStripButtonTest;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}
