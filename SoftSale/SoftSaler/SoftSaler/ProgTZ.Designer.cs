namespace SoftSaler
{
    partial class ProgTZ
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.tz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proger = new System.Windows.Forms.ComboBox();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.finishDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.TextBox();
            this.comboClient = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.manager = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название программы";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(192, 109);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            // 
            // tz
            // 
            this.tz.Location = new System.Drawing.Point(201, 159);
            this.tz.Name = "tz";
            this.tz.Size = new System.Drawing.Size(143, 20);
            this.tz.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Техническое задание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ведущий программист";
            // 
            // proger
            // 
            this.proger.FormattingEnabled = true;
            this.proger.Location = new System.Drawing.Point(201, 204);
            this.proger.Name = "proger";
            this.proger.Size = new System.Drawing.Size(143, 21);
            this.proger.TabIndex = 5;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(519, 217);
            this.startDate.MinDate = new System.DateTime(2022, 6, 16, 0, 0, 0, 0);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 20);
            this.startDate.TabIndex = 6;
            // 
            // finishDate
            // 
            this.finishDate.Location = new System.Drawing.Point(519, 244);
            this.finishDate.Name = "finishDate";
            this.finishDate.Size = new System.Drawing.Size(200, 20);
            this.finishDate.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата начала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата окончания";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(445, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Сумма";
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(529, 300);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(143, 20);
            this.sum.TabIndex = 11;
            // 
            // comboClient
            // 
            this.comboClient.FormattingEnabled = true;
            this.comboClient.Location = new System.Drawing.Point(526, 186);
            this.comboClient.Name = "comboClient";
            this.comboClient.Size = new System.Drawing.Size(143, 21);
            this.comboClient.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(551, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Сотрудник";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Клиент";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Заключить договор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // manager
            // 
            this.manager.FormattingEnabled = true;
            this.manager.Location = new System.Drawing.Point(519, 119);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(143, 21);
            this.manager.TabIndex = 18;
            // 
            // ProgTZ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.manager);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboClient);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.finishDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.proger);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tz);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "ProgTZ";
            this.Text = "ProgTZ";
            this.Load += new System.EventHandler(this.ProgTZ_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox tz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox proger;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker finishDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.ComboBox comboClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox manager;
    }
}