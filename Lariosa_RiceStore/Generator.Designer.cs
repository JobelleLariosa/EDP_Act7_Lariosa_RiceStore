
namespace Lariosa_RiceStore
{
    partial class Generator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Generator));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.Rice_Variety = new System.Windows.Forms.Button();
            this.Rice_Stock = new System.Windows.Forms.Button();
            this.Supplier = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.Panel();
            this.User = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.DataVisualization = new System.Windows.Forms.Button();
            this.VariRice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.VariRice_Logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label6 = new System.Windows.Forms.Label();
            this.Dashboard1 = new System.Windows.Forms.Button();
            this.dataGridViewTotalValue = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView_TotalValue = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            this.content.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VariRice_Logo)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TotalValue)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(690, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(190)))), ((int)(((byte)(41)))));
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(251, 79);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 322);
            this.panel3.TabIndex = 33;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.button5);
            this.panel6.Controls.Add(this.dataGridViewTotalValue);
            this.panel6.Controls.Add(this.button2);
            this.panel6.Controls.Add(this.chart3);
            this.panel6.Location = new System.Drawing.Point(8, 40);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(657, 265);
            this.panel6.TabIndex = 1;
            this.panel6.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(543, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generate Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chart3.BorderlineColor = System.Drawing.Color.DarkGray;
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            this.chart3.Location = new System.Drawing.Point(-5, 0);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Name = "Profit_Varity";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(333, 229);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Value";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(26, 531);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 46);
            this.button1.TabIndex = 14;
            this.button1.Text = "Report Generator";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.btncustomer.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncustomer.Location = new System.Drawing.Point(26, 271);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(195, 46);
            this.btncustomer.TabIndex = 13;
            this.btncustomer.Text = "Customers";
            this.btncustomer.UseVisualStyleBackColor = false;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // Rice_Variety
            // 
            this.Rice_Variety.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.Rice_Variety.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rice_Variety.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rice_Variety.Location = new System.Drawing.Point(26, 427);
            this.Rice_Variety.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Rice_Variety.Name = "Rice_Variety";
            this.Rice_Variety.Size = new System.Drawing.Size(195, 46);
            this.Rice_Variety.TabIndex = 12;
            this.Rice_Variety.Text = "Order Rice";
            this.Rice_Variety.UseVisualStyleBackColor = false;
            this.Rice_Variety.Click += new System.EventHandler(this.Rice_Variety_Click);
            // 
            // Rice_Stock
            // 
            this.Rice_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.Rice_Stock.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rice_Stock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Rice_Stock.Location = new System.Drawing.Point(26, 375);
            this.Rice_Stock.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Rice_Stock.Name = "Rice_Stock";
            this.Rice_Stock.Size = new System.Drawing.Size(195, 46);
            this.Rice_Stock.TabIndex = 11;
            this.Rice_Stock.Text = "Rice Stock and Varieties";
            this.Rice_Stock.UseVisualStyleBackColor = false;
            this.Rice_Stock.Click += new System.EventHandler(this.Rice_Stock_Click);
            // 
            // Supplier
            // 
            this.Supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.Supplier.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Supplier.Location = new System.Drawing.Point(26, 323);
            this.Supplier.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Supplier.Name = "Supplier";
            this.Supplier.Size = new System.Drawing.Size(195, 46);
            this.Supplier.TabIndex = 10;
            this.Supplier.Text = "Supplier";
            this.Supplier.UseVisualStyleBackColor = false;
            this.Supplier.Click += new System.EventHandler(this.Supplier_Click);
            // 
            // btnSales
            // 
            this.btnSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.btnSales.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSales.Location = new System.Drawing.Point(26, 219);
            this.btnSales.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(195, 46);
            this.btnSales.TabIndex = 9;
            this.btnSales.Text = "Sales";
            this.btnSales.UseVisualStyleBackColor = false;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(41)))));
            this.content.Controls.Add(this.User);
            this.content.Controls.Add(this.button3);
            this.content.Controls.Add(this.button1);
            this.content.Controls.Add(this.btncustomer);
            this.content.Controls.Add(this.Rice_Variety);
            this.content.Controls.Add(this.Rice_Stock);
            this.content.Controls.Add(this.Supplier);
            this.content.Controls.Add(this.btnSales);
            this.content.Controls.Add(this.DataVisualization);
            this.content.Controls.Add(this.VariRice);
            this.content.Controls.Add(this.panel2);
            this.content.Dock = System.Windows.Forms.DockStyle.Left;
            this.content.Location = new System.Drawing.Point(0, 0);
            this.content.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(244, 648);
            this.content.TabIndex = 31;
            this.content.Paint += new System.Windows.Forms.PaintEventHandler(this.content_Paint);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.User.Font = new System.Drawing.Font("Cambria", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(32, 182);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(117, 25);
            this.User.TabIndex = 40;
            this.User.Text = "_______________";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.button3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(26, 583);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 46);
            this.button3.TabIndex = 39;
            this.button3.Text = "User Management";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DataVisualization
            // 
            this.DataVisualization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(183)))), ((int)(((byte)(65)))));
            this.DataVisualization.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataVisualization.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataVisualization.Location = new System.Drawing.Point(26, 479);
            this.DataVisualization.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DataVisualization.Name = "DataVisualization";
            this.DataVisualization.Size = new System.Drawing.Size(195, 46);
            this.DataVisualization.TabIndex = 8;
            this.DataVisualization.Text = "About Us";
            this.DataVisualization.UseVisualStyleBackColor = false;
            // 
            // VariRice
            // 
            this.VariRice.AutoSize = true;
            this.VariRice.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VariRice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.VariRice.Location = new System.Drawing.Point(47, 144);
            this.VariRice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VariRice.Name = "VariRice";
            this.VariRice.Size = new System.Drawing.Size(151, 25);
            this.VariRice.TabIndex = 1;
            this.VariRice.Text = "VariRice Store";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.VariRice_Logo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 155);
            this.panel2.TabIndex = 1;
            // 
            // VariRice_Logo
            // 
            this.VariRice_Logo.Image = global::Lariosa_RiceStore.Properties.Resources.Untitled_design;
            this.VariRice_Logo.Location = new System.Drawing.Point(0, -3);
            this.VariRice_Logo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VariRice_Logo.Name = "VariRice_Logo";
            this.VariRice_Logo.Size = new System.Drawing.Size(244, 155);
            this.VariRice_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VariRice_Logo.TabIndex = 1;
            this.VariRice_Logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(75)))), ((int)(((byte)(41)))));
            this.label2.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(262, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 41);
            this.label2.TabIndex = 32;
            this.label2.Text = "Report Generator";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(251, 407);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(680, 241);
            this.panel5.TabIndex = 36;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button6);
            this.panel7.Controls.Add(this.dataGridView_TotalValue);
            this.panel7.Controls.Add(this.button4);
            this.panel7.Controls.Add(this.chart4);
            this.panel7.Location = new System.Drawing.Point(8, 36);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(657, 193);
            this.panel7.TabIndex = 3;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(543, 163);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Generate Report";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // chart4
            // 
            chartArea2.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea2);
            this.chart4.Location = new System.Drawing.Point(0, 0);
            this.chart4.Name = "chart4";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Customer_Variety";
            this.chart4.Series.Add(series2);
            this.chart4.Size = new System.Drawing.Size(328, 157);
            this.chart4.TabIndex = 0;
            this.chart4.Text = "chart1";
            this.chart4.Click += new System.EventHandler(this.chart1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(13, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Top Customers";
            // 
            // Dashboard1
            // 
            this.Dashboard1.BackColor = System.Drawing.Color.OliveDrab;
            this.Dashboard1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard1.ForeColor = System.Drawing.Color.White;
            this.Dashboard1.Location = new System.Drawing.Point(757, 35);
            this.Dashboard1.Name = "Dashboard1";
            this.Dashboard1.Size = new System.Drawing.Size(174, 40);
            this.Dashboard1.TabIndex = 58;
            this.Dashboard1.Text = "Dashboard";
            this.Dashboard1.UseVisualStyleBackColor = false;
            this.Dashboard1.Click += new System.EventHandler(this.Dashboard1_Click);
            // 
            // dataGridViewTotalValue
            // 
            this.dataGridViewTotalValue.BackgroundColor = System.Drawing.Color.LawnGreen;
            this.dataGridViewTotalValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTotalValue.Location = new System.Drawing.Point(334, 0);
            this.dataGridViewTotalValue.Name = "dataGridViewTotalValue";
            this.dataGridViewTotalValue.Size = new System.Drawing.Size(320, 229);
            this.dataGridViewTotalValue.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(462, 235);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView_TotalValue
            // 
            this.dataGridView_TotalValue.BackgroundColor = System.Drawing.Color.Lime;
            this.dataGridView_TotalValue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TotalValue.Location = new System.Drawing.Point(334, 3);
            this.dataGridView_TotalValue.Name = "dataGridView_TotalValue";
            this.dataGridView_TotalValue.Size = new System.Drawing.Size(323, 154);
            this.dataGridView_TotalValue.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(462, 163);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(183)))));
            this.BackgroundImage = global::Lariosa_RiceStore.Properties.Resources.farmers1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(943, 648);
            this.Controls.Add(this.Dashboard1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.content);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Generator";
            this.Text = "Generator";
            this.Load += new System.EventHandler(this.Generator_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            this.content.ResumeLayout(false);
            this.content.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.VariRice_Logo)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTotalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TotalValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox VariRice_Logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button Rice_Variety;
        private System.Windows.Forms.Button Rice_Stock;
        private System.Windows.Forms.Button Supplier;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.Button DataVisualization;
        private System.Windows.Forms.Label VariRice;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Dashboard1;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridViewTotalValue;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView_TotalValue;
    }
}