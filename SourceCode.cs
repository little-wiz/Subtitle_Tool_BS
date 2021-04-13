using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Jianss_Subtitle_Tool
{
    public class Form1 : Form
    {
        private IContainer components = null;

        private ListBox listBox1;

        private RichTextBox richTextBox1;

        private Label label1;

        private Label label2;

        private ListBox listBox2;

        private Button button1;

        private Button button2;

        private TextBox textBox1;

        private ListBox listBox3;

        private ListBox listBox4;

        private ListBox listBox5;

        private ListBox listBox6;

        private ListBox listBox7;

        private ListBox listBox8;

        private Label label4;

        private ListBox listBox9;

        private ListBox listBox10;

        private Label label3;

        private Label label5;

        private Label label6;

        private Label label7;

        public Form1()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.loadSt(this.textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "此軟件設定檔 (*.appset)|*.appset"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog.FileName;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if ((!disposing ? false : this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            this.listBox1 = new ListBox();
            this.richTextBox1 = new RichTextBox();
            this.label1 = new Label();
            this.label2 = new Label();
            this.listBox2 = new ListBox();
            this.button1 = new Button();
            this.button2 = new Button();
            this.textBox1 = new TextBox();
            this.listBox3 = new ListBox();
            this.listBox4 = new ListBox();
            this.listBox5 = new ListBox();
            this.listBox6 = new ListBox();
            this.listBox7 = new ListBox();
            this.listBox8 = new ListBox();
            this.label4 = new Label();
            this.listBox9 = new ListBox();
            this.listBox10 = new ListBox();
            this.label3 = new Label();
            this.label5 = new Label();
            this.label6 = new Label();
            this.label7 = new Label();
            base.SuspendLayout();
            this.listBox1.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new Point(12, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new Size(86, 424);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new EventHandler(this.listBox1_SelectedIndexChanged);
            this.richTextBox1.Font = new Font("新細明體", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.richTextBox1.Location = new Point(12, 507);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new Size(914, 118);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.label1.AutoSize = true;
            this.label1.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.label1.Location = new Point(9, 52);
            this.label1.Name = "label1";
            this.label1.Size = new Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "髒話";
            this.label2.AutoSize = true;
            this.label2.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.label2.Location = new Point(101, 52);
            this.label2.Name = "label2";
            this.label2.Size = new Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "人物";
            this.listBox2.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new Point(104, 70);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new Size(86, 424);
            this.listBox2.TabIndex = 5;
            this.listBox2.SelectedIndexChanged += new EventHandler(this.listBox2_SelectedIndexChanged);
            this.button1.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.button1.Location = new Point(840, 6);
            this.button1.Name = "button1";
            this.button1.Size = new Size(86, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "載入設定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            this.button2.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.button2.Location = new Point(4, 6);
            this.button2.Name = "button2";
            this.button2.Size = new Size(94, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "瀏覽設定檔";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new EventHandler(this.button2_Click);
            this.textBox1.Location = new Point(104, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(730, 22);
            this.textBox1.TabIndex = 8;
            this.listBox3.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new Point(196, 70);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new Size(86, 424);
            this.listBox3.TabIndex = 9;
            this.listBox3.SelectedIndexChanged += new EventHandler(this.listBox3_SelectedIndexChanged);
            this.listBox4.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 15;
            this.listBox4.Location = new Point(288, 70);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new Size(86, 424);
            this.listBox4.TabIndex = 10;
            this.listBox4.SelectedIndexChanged += new EventHandler(this.listBox4_SelectedIndexChanged);
            this.listBox5.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new Point(380, 70);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new Size(86, 424);
            this.listBox5.TabIndex = 11;
            this.listBox5.SelectedIndexChanged += new EventHandler(this.listBox5_SelectedIndexChanged);
            this.listBox6.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 15;
            this.listBox6.Location = new Point(472, 70);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new Size(86, 424);
            this.listBox6.TabIndex = 12;
            this.listBox6.SelectedIndexChanged += new EventHandler(this.listBox6_SelectedIndexChanged);
            this.listBox7.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 15;
            this.listBox7.Location = new Point(564, 70);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new Size(86, 424);
            this.listBox7.TabIndex = 13;
            this.listBox7.SelectedIndexChanged += new EventHandler(this.listBox7_SelectedIndexChanged);
            this.listBox8.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 15;
            this.listBox8.Location = new Point(656, 70);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new Size(86, 424);
            this.listBox8.TabIndex = 14;
            this.listBox8.SelectedIndexChanged += new EventHandler(this.listBox8_SelectedIndexChanged);
            this.label4.BackColor = SystemColors.ControlDark;
            this.label4.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.label4.Location = new Point(288, 52);
            this.label4.Name = "label4";
            this.label4.Size = new Size(178, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "角色";
            this.listBox9.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.listBox9.FormattingEnabled = true;
            this.listBox9.ItemHeight = 15;
            this.listBox9.Location = new Point(748, 70);
            this.listBox9.Name = "listBox9";
            this.listBox9.Size = new Size(86, 424);
            this.listBox9.TabIndex = 16;
            this.listBox9.SelectedIndexChanged += new EventHandler(this.listBox9_SelectedIndexChanged);
            this.listBox10.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.listBox10.FormattingEnabled = true;
            this.listBox10.ItemHeight = 15;
            this.listBox10.Location = new Point(840, 70);
            this.listBox10.Name = "listBox10";
            this.listBox10.Size = new Size(86, 424);
            this.listBox10.TabIndex = 17;
            this.listBox10.SelectedIndexChanged += new EventHandler(this.listBox10_SelectedIndexChanged);
            this.label3.AutoSize = true;
            this.label3.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.label3.Location = new Point(193, 52);
            this.label3.Name = "label3";
            this.label3.Size = new Size(37, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "模式";
            this.label5.AutoSize = true;
            this.label5.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.label5.Location = new Point(472, 52);
            this.label5.Name = "label5";
            this.label5.Size = new Size(67, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "遊戲名詞";
            this.label6.AutoSize = true;
            this.label6.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.label6.Location = new Point(561, 52);
            this.label6.Name = "label6";
            this.label6.Size = new Size(52, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "感嘆詞";
            this.label7.AutoSize = true;
            this.label7.Font = new Font("新細明體", 11.25f, FontStyle.Regular, GraphicsUnit.Point, 136);
            this.label7.Location = new Point(653, 52);
            this.label7.Name = "label7";
            this.label7.Size = new Size(52, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "口頭禪";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(938, 637);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.listBox10);
            base.Controls.Add(this.listBox9);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.listBox8);
            base.Controls.Add(this.listBox7);
            base.Controls.Add(this.listBox6);
            base.Controls.Add(this.listBox5);
            base.Controls.Add(this.listBox4);
            base.Controls.Add(this.listBox3);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.button2);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.listBox2);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.richTextBox1);
            base.Controls.Add(this.listBox1);
            base.Name = "Form1";
            this.Text = "Form1";
            base.Load += new EventHandler(this.Form1_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(this.listBox1.SelectedItem.ToString());
        }

        private void listBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(this.listBox10.SelectedItem.ToString());
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(this.listBox2.SelectedItem.ToString());
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(this.listBox3.SelectedItem.ToString());
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(this.listBox4.SelectedItem.ToString());
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(this.listBox5.SelectedItem.ToString());
        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(this.listBox6.SelectedItem.ToString());
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(this.listBox7.SelectedItem.ToString());
        }

        private void listBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(this.listBox8.SelectedItem.ToString());
        }

        private void listBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.richTextBox1.AppendText(this.listBox9.SelectedItem.ToString());
        }

        private void loadSt(string path)
        {
            string str;
            this.listBox1.Items.Clear();
            this.listBox2.Items.Clear();
            this.listBox3.Items.Clear();
            this.listBox4.Items.Clear();
            this.listBox5.Items.Clear();
            this.listBox6.Items.Clear();
            this.listBox7.Items.Clear();
            this.listBox8.Items.Clear();
            this.listBox9.Items.Clear();
            this.listBox10.Items.Clear();
            List<string> strs = new List<string>();
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                try
                {
                    while (true)
                    {
                        string str1 = streamReader.ReadLine();
                        str = str1;
                        if (str1 == "-swear")
                        {
                            break;
                        }
                        this.listBox1.Items.Add(str);
                    }
                    while (true)
                    {
                        string str2 = streamReader.ReadLine();
                        str = str2;
                        if (str2 == "-ppl")
                        {
                            break;
                        }
                        this.listBox2.Items.Add(str);
                    }
                    while (true)
                    {
                        string str3 = streamReader.ReadLine();
                        str = str3;
                        if (str3 == "-mode")
                        {
                            break;
                        }
                        this.listBox3.Items.Add(str);
                    }
                    while (true)
                    {
                        string str4 = streamReader.ReadLine();
                        str = str4;
                        if (str4 == "-char1")
                        {
                            break;
                        }
                        this.listBox4.Items.Add(str);
                    }
                    while (true)
                    {
                        string str5 = streamReader.ReadLine();
                        str = str5;
                        if (str5 == "-char2")
                        {
                            break;
                        }
                        this.listBox5.Items.Add(str);
                    }
                    while (true)
                    {
                        string str6 = streamReader.ReadLine();
                        str = str6;
                        if (str6 == "-elem")
                        {
                            break;
                        }
                        this.listBox6.Items.Add(str);
                    }
                    while (true)
                    {
                        string str7 = streamReader.ReadLine();
                        str = str7;
                        if (str7 == "-exclam")
                        {
                            break;
                        }
                        this.listBox7.Items.Add(str);
                    }
                    while (true)
                    {
                        string str8 = streamReader.ReadLine();
                        str = str8;
                        if (str8 == "-usual")
                        {
                            break;
                        }
                        this.listBox8.Items.Add(str);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("設定檔不完整， 請檢查內容或聯系設定檔發行人");
                }
            }
        }
    }
}