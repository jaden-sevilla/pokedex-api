using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace FormAPI
{
	partial class Form1
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
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.searchButton = new System.Windows.Forms.Button();
			this.searchBar = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.name = new System.Windows.Forms.Label();
			this.id = new System.Windows.Forms.Label();
			this.hp = new System.Windows.Forms.Label();
			this.attack = new System.Windows.Forms.Label();
			this.defense = new System.Windows.Forms.Label();
			this.spAtk = new System.Windows.Forms.Label();
			this.spDef = new System.Windows.Forms.Label();
			this.speed = new System.Windows.Forms.Label();
			this.total = new System.Windows.Forms.Label();
			this.type = new System.Windows.Forms.Label();
			this.height = new System.Windows.Forms.Label();
			this.weight = new System.Windows.Forms.Label();
			this.hpNum = new System.Windows.Forms.Label();
			this.attackNum = new System.Windows.Forms.Label();
			this.defenseNum = new System.Windows.Forms.Label();
			this.spAtkNum = new System.Windows.Forms.Label();
			this.spDefNum = new System.Windows.Forms.Label();
			this.speedNum = new System.Windows.Forms.Label();
			this.totalNum = new System.Windows.Forms.Label();
			this.idNum = new System.Windows.Forms.Label();
			this.heightNum = new System.Windows.Forms.Label();
			this.weightNum = new System.Windows.Forms.Label();
			this.type1 = new System.Windows.Forms.Label();
			this.type2 = new System.Windows.Forms.Label();
			this.hpBar = new System.Windows.Forms.Label();
			this.attackBar = new System.Windows.Forms.Label();
			this.defenseBar = new System.Windows.Forms.Label();
			this.spAtkBar = new System.Windows.Forms.Label();
			this.spDefBar = new System.Windows.Forms.Label();
			this.speedBar = new System.Windows.Forms.Label();
			this.shinyButton = new System.Windows.Forms.Button();
			this.randomButton = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.searchButton);
			this.panel1.Controls.Add(this.searchBar);
			this.panel1.Location = new System.Drawing.Point(-6, -9);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(648, 81);
			this.panel1.TabIndex = 1;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// searchButton
			// 
			this.searchButton.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchButton.Location = new System.Drawing.Point(402, 31);
			this.searchButton.Name = "searchButton";
			this.searchButton.Size = new System.Drawing.Size(49, 31);
			this.searchButton.TabIndex = 2;
			this.searchButton.Text = "Search";
			this.searchButton.UseVisualStyleBackColor = true;
			this.searchButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// searchBar
			// 
			this.searchBar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchBar.Location = new System.Drawing.Point(220, 31);
			this.searchBar.Name = "searchBar";
			this.searchBar.Size = new System.Drawing.Size(188, 31);
			this.searchBar.TabIndex = 1;
			this.searchBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.searchBar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(50, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 25);
			this.label2.TabIndex = 5;
			// 
			// name
			// 
			this.name.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name.ForeColor = System.Drawing.Color.Black;
			this.name.Location = new System.Drawing.Point(12, 120);
			this.name.MinimumSize = new System.Drawing.Size(100, 10);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(248, 41);
			this.name.TabIndex = 5;
			this.name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.name.Click += new System.EventHandler(this.name_Click);
			// 
			// id
			// 
			this.id.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.id.ForeColor = System.Drawing.Color.DimGray;
			this.id.Location = new System.Drawing.Point(252, 91);
			this.id.Name = "id";
			this.id.Size = new System.Drawing.Size(134, 25);
			this.id.TabIndex = 7;
			this.id.Tag = "";
			this.id.Text = "National ID";
			this.id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.id.Click += new System.EventHandler(this.label3_Click_2);
			// 
			// hp
			// 
			this.hp.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hp.ForeColor = System.Drawing.Color.DimGray;
			this.hp.Location = new System.Drawing.Point(266, 277);
			this.hp.Name = "hp";
			this.hp.Size = new System.Drawing.Size(73, 21);
			this.hp.TabIndex = 11;
			this.hp.Tag = "";
			this.hp.Text = "HP";
			this.hp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.hp.Click += new System.EventHandler(this.label7_Click);
			// 
			// attack
			// 
			this.attack.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.attack.ForeColor = System.Drawing.Color.DimGray;
			this.attack.Location = new System.Drawing.Point(279, 302);
			this.attack.Name = "attack";
			this.attack.Size = new System.Drawing.Size(60, 21);
			this.attack.TabIndex = 12;
			this.attack.Tag = "";
			this.attack.Text = "Attack";
			this.attack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// defense
			// 
			this.defense.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.defense.ForeColor = System.Drawing.Color.DimGray;
			this.defense.Location = new System.Drawing.Point(269, 327);
			this.defense.Name = "defense";
			this.defense.Size = new System.Drawing.Size(70, 21);
			this.defense.TabIndex = 13;
			this.defense.Tag = "";
			this.defense.Text = "Defense";
			this.defense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.defense.Click += new System.EventHandler(this.label9_Click);
			// 
			// spAtk
			// 
			this.spAtk.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spAtk.ForeColor = System.Drawing.Color.DimGray;
			this.spAtk.Location = new System.Drawing.Point(269, 352);
			this.spAtk.Name = "spAtk";
			this.spAtk.Size = new System.Drawing.Size(70, 21);
			this.spAtk.TabIndex = 14;
			this.spAtk.Tag = "";
			this.spAtk.Text = "Sp. Atk";
			this.spAtk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// spDef
			// 
			this.spDef.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spDef.ForeColor = System.Drawing.Color.DimGray;
			this.spDef.Location = new System.Drawing.Point(269, 377);
			this.spDef.Name = "spDef";
			this.spDef.Size = new System.Drawing.Size(70, 21);
			this.spDef.TabIndex = 15;
			this.spDef.Tag = "";
			this.spDef.Text = "Sp.Def";
			this.spDef.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// speed
			// 
			this.speed.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.speed.ForeColor = System.Drawing.Color.DimGray;
			this.speed.Location = new System.Drawing.Point(279, 402);
			this.speed.Name = "speed";
			this.speed.Size = new System.Drawing.Size(60, 21);
			this.speed.TabIndex = 16;
			this.speed.Tag = "";
			this.speed.Text = "Speed";
			this.speed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// total
			// 
			this.total.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.total.ForeColor = System.Drawing.Color.DimGray;
			this.total.Location = new System.Drawing.Point(272, 425);
			this.total.Name = "total";
			this.total.Size = new System.Drawing.Size(67, 25);
			this.total.TabIndex = 17;
			this.total.Tag = "";
			this.total.Text = "Total";
			this.total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.total.Click += new System.EventHandler(this.label13_Click);
			// 
			// type
			// 
			this.type.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.type.ForeColor = System.Drawing.Color.DimGray;
			this.type.Location = new System.Drawing.Point(276, 134);
			this.type.Name = "type";
			this.type.Size = new System.Drawing.Size(110, 25);
			this.type.TabIndex = 18;
			this.type.Tag = "";
			this.type.Text = "Type";
			this.type.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// height
			// 
			this.height.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.height.ForeColor = System.Drawing.Color.DimGray;
			this.height.Location = new System.Drawing.Point(276, 178);
			this.height.Name = "height";
			this.height.Size = new System.Drawing.Size(110, 25);
			this.height.TabIndex = 19;
			this.height.Tag = "";
			this.height.Text = "Height";
			this.height.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// weight
			// 
			this.weight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weight.ForeColor = System.Drawing.Color.DimGray;
			this.weight.Location = new System.Drawing.Point(276, 219);
			this.weight.Name = "weight";
			this.weight.Size = new System.Drawing.Size(110, 25);
			this.weight.TabIndex = 20;
			this.weight.Tag = "";
			this.weight.Text = "Weight";
			this.weight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// hpNum
			// 
			this.hpNum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hpNum.ForeColor = System.Drawing.Color.Black;
			this.hpNum.Location = new System.Drawing.Point(348, 275);
			this.hpNum.Name = "hpNum";
			this.hpNum.Size = new System.Drawing.Size(54, 25);
			this.hpNum.TabIndex = 21;
			this.hpNum.Tag = "";
			this.hpNum.Text = "0";
			this.hpNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// attackNum
			// 
			this.attackNum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.attackNum.ForeColor = System.Drawing.Color.Black;
			this.attackNum.Location = new System.Drawing.Point(348, 302);
			this.attackNum.Name = "attackNum";
			this.attackNum.Size = new System.Drawing.Size(54, 25);
			this.attackNum.TabIndex = 22;
			this.attackNum.Tag = "";
			this.attackNum.Text = "0";
			this.attackNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// defenseNum
			// 
			this.defenseNum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.defenseNum.ForeColor = System.Drawing.Color.Black;
			this.defenseNum.Location = new System.Drawing.Point(348, 327);
			this.defenseNum.Name = "defenseNum";
			this.defenseNum.Size = new System.Drawing.Size(54, 25);
			this.defenseNum.TabIndex = 23;
			this.defenseNum.Tag = "";
			this.defenseNum.Text = "0";
			this.defenseNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// spAtkNum
			// 
			this.spAtkNum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spAtkNum.ForeColor = System.Drawing.Color.Black;
			this.spAtkNum.Location = new System.Drawing.Point(348, 352);
			this.spAtkNum.Name = "spAtkNum";
			this.spAtkNum.Size = new System.Drawing.Size(54, 25);
			this.spAtkNum.TabIndex = 24;
			this.spAtkNum.Tag = "";
			this.spAtkNum.Text = "0";
			this.spAtkNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// spDefNum
			// 
			this.spDefNum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spDefNum.ForeColor = System.Drawing.Color.Black;
			this.spDefNum.Location = new System.Drawing.Point(348, 375);
			this.spDefNum.Name = "spDefNum";
			this.spDefNum.Size = new System.Drawing.Size(54, 25);
			this.spDefNum.TabIndex = 25;
			this.spDefNum.Tag = "";
			this.spDefNum.Text = "0";
			this.spDefNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// speedNum
			// 
			this.speedNum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.speedNum.ForeColor = System.Drawing.Color.Black;
			this.speedNum.Location = new System.Drawing.Point(348, 400);
			this.speedNum.Name = "speedNum";
			this.speedNum.Size = new System.Drawing.Size(54, 25);
			this.speedNum.TabIndex = 26;
			this.speedNum.Tag = "";
			this.speedNum.Text = "0";
			this.speedNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// totalNum
			// 
			this.totalNum.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.totalNum.ForeColor = System.Drawing.Color.Black;
			this.totalNum.Location = new System.Drawing.Point(348, 425);
			this.totalNum.Name = "totalNum";
			this.totalNum.Size = new System.Drawing.Size(54, 25);
			this.totalNum.TabIndex = 27;
			this.totalNum.Tag = "";
			this.totalNum.Text = "0";
			this.totalNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// idNum
			// 
			this.idNum.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.idNum.ForeColor = System.Drawing.Color.Black;
			this.idNum.Location = new System.Drawing.Point(392, 91);
			this.idNum.Name = "idNum";
			this.idNum.Size = new System.Drawing.Size(95, 25);
			this.idNum.TabIndex = 28;
			this.idNum.Tag = "";
			this.idNum.Text = "0";
			this.idNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.idNum.Click += new System.EventHandler(this.label7_Click_1);
			// 
			// heightNum
			// 
			this.heightNum.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.heightNum.ForeColor = System.Drawing.Color.Black;
			this.heightNum.ImageAlign = System.Drawing.ContentAlignment.TopRight;
			this.heightNum.Location = new System.Drawing.Point(392, 178);
			this.heightNum.Name = "heightNum";
			this.heightNum.Size = new System.Drawing.Size(78, 25);
			this.heightNum.TabIndex = 30;
			this.heightNum.Tag = "";
			this.heightNum.Text = "0";
			this.heightNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// weightNum
			// 
			this.weightNum.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.weightNum.ForeColor = System.Drawing.Color.Black;
			this.weightNum.Location = new System.Drawing.Point(392, 219);
			this.weightNum.Name = "weightNum";
			this.weightNum.Size = new System.Drawing.Size(95, 25);
			this.weightNum.TabIndex = 31;
			this.weightNum.Tag = "";
			this.weightNum.Text = "0";
			this.weightNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// type1
			// 
			this.type1.BackColor = System.Drawing.Color.Silver;
			this.type1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.type1.ForeColor = System.Drawing.Color.Black;
			this.type1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.type1.Location = new System.Drawing.Point(392, 132);
			this.type1.Name = "type1";
			this.type1.Size = new System.Drawing.Size(78, 27);
			this.type1.TabIndex = 33;
			this.type1.Tag = "";
			this.type1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.type1.Click += new System.EventHandler(this.label3_Click_4);
			// 
			// type2
			// 
			this.type2.BackColor = System.Drawing.Color.Silver;
			this.type2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.type2.ForeColor = System.Drawing.Color.Black;
			this.type2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.type2.Location = new System.Drawing.Point(481, 132);
			this.type2.Name = "type2";
			this.type2.Size = new System.Drawing.Size(78, 27);
			this.type2.TabIndex = 34;
			this.type2.Tag = "";
			this.type2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// hpBar
			// 
			this.hpBar.BackColor = System.Drawing.Color.Silver;
			this.hpBar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.hpBar.ForeColor = System.Drawing.Color.Black;
			this.hpBar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.hpBar.Location = new System.Drawing.Point(406, 278);
			this.hpBar.Name = "hpBar";
			this.hpBar.Size = new System.Drawing.Size(200, 19);
			this.hpBar.TabIndex = 35;
			this.hpBar.Tag = "";
			this.hpBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// attackBar
			// 
			this.attackBar.BackColor = System.Drawing.Color.Silver;
			this.attackBar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.attackBar.ForeColor = System.Drawing.Color.Black;
			this.attackBar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.attackBar.Location = new System.Drawing.Point(406, 304);
			this.attackBar.Name = "attackBar";
			this.attackBar.Size = new System.Drawing.Size(200, 19);
			this.attackBar.TabIndex = 37;
			this.attackBar.Tag = "";
			this.attackBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// defenseBar
			// 
			this.defenseBar.BackColor = System.Drawing.Color.Silver;
			this.defenseBar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.defenseBar.ForeColor = System.Drawing.Color.Black;
			this.defenseBar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.defenseBar.Location = new System.Drawing.Point(406, 328);
			this.defenseBar.Name = "defenseBar";
			this.defenseBar.Size = new System.Drawing.Size(200, 19);
			this.defenseBar.TabIndex = 38;
			this.defenseBar.Tag = "";
			this.defenseBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// spAtkBar
			// 
			this.spAtkBar.BackColor = System.Drawing.Color.Silver;
			this.spAtkBar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spAtkBar.ForeColor = System.Drawing.Color.Black;
			this.spAtkBar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.spAtkBar.Location = new System.Drawing.Point(406, 352);
			this.spAtkBar.Name = "spAtkBar";
			this.spAtkBar.Size = new System.Drawing.Size(200, 19);
			this.spAtkBar.TabIndex = 39;
			this.spAtkBar.Tag = "";
			this.spAtkBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// spDefBar
			// 
			this.spDefBar.BackColor = System.Drawing.Color.Silver;
			this.spDefBar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.spDefBar.ForeColor = System.Drawing.Color.Black;
			this.spDefBar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.spDefBar.Location = new System.Drawing.Point(406, 377);
			this.spDefBar.Name = "spDefBar";
			this.spDefBar.Size = new System.Drawing.Size(200, 19);
			this.spDefBar.TabIndex = 40;
			this.spDefBar.Tag = "";
			this.spDefBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// speedBar
			// 
			this.speedBar.BackColor = System.Drawing.Color.Silver;
			this.speedBar.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.speedBar.ForeColor = System.Drawing.Color.Black;
			this.speedBar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.speedBar.Location = new System.Drawing.Point(406, 402);
			this.speedBar.Name = "speedBar";
			this.speedBar.Size = new System.Drawing.Size(200, 19);
			this.speedBar.TabIndex = 41;
			this.speedBar.Tag = "";
			this.speedBar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// shinyButton
			// 
			this.shinyButton.BackColor = System.Drawing.Color.Silver;
			this.shinyButton.Enabled = false;
			this.shinyButton.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.shinyButton.Location = new System.Drawing.Point(539, 213);
			this.shinyButton.Name = "shinyButton";
			this.shinyButton.Size = new System.Drawing.Size(67, 31);
			this.shinyButton.TabIndex = 4;
			this.shinyButton.Text = "Shiny";
			this.shinyButton.UseVisualStyleBackColor = false;
			this.shinyButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// randomButton
			// 
			this.randomButton.BackColor = System.Drawing.Color.Silver;
			this.randomButton.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.randomButton.Location = new System.Drawing.Point(539, 176);
			this.randomButton.Name = "randomButton";
			this.randomButton.Size = new System.Drawing.Size(67, 31);
			this.randomButton.TabIndex = 42;
			this.randomButton.Text = "Random";
			this.randomButton.UseVisualStyleBackColor = false;
			this.randomButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(18, 178);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(242, 195);
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			string projectRootDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, @"..\..\"));
			string imageDirectory = Path.Combine(projectRootDirectory, "images");
			string imagePath = Path.Combine(imageDirectory, "pokeball.png");
			this.pictureBox2.Image = Image.FromFile(imagePath);
			this.pictureBox2.Location = new System.Drawing.Point(3, 15);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(122, 63);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 42;
			this.pictureBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(618, 460);
			this.Controls.Add(this.randomButton);
			this.Controls.Add(this.shinyButton);
			this.Controls.Add(this.speedBar);
			this.Controls.Add(this.spDefBar);
			this.Controls.Add(this.spAtkBar);
			this.Controls.Add(this.defenseBar);
			this.Controls.Add(this.attackBar);
			this.Controls.Add(this.hpBar);
			this.Controls.Add(this.type2);
			this.Controls.Add(this.type1);
			this.Controls.Add(this.weightNum);
			this.Controls.Add(this.heightNum);
			this.Controls.Add(this.idNum);
			this.Controls.Add(this.totalNum);
			this.Controls.Add(this.speedNum);
			this.Controls.Add(this.spDefNum);
			this.Controls.Add(this.spAtkNum);
			this.Controls.Add(this.defenseNum);
			this.Controls.Add(this.attackNum);
			this.Controls.Add(this.hpNum);
			this.Controls.Add(this.weight);
			this.Controls.Add(this.height);
			this.Controls.Add(this.type);
			this.Controls.Add(this.total);
			this.Controls.Add(this.speed);
			this.Controls.Add(this.spDef);
			this.Controls.Add(this.spAtk);
			this.Controls.Add(this.defense);
			this.Controls.Add(this.attack);
			this.Controls.Add(this.hp);
			this.Controls.Add(this.id);
			this.Controls.Add(this.name);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.ForeColor = System.Drawing.Color.DimGray;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox searchBar;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label name;
		private System.Windows.Forms.Label id;
		private System.Windows.Forms.Label hp;
		private System.Windows.Forms.Label attack;
		private System.Windows.Forms.Label defense;
		private System.Windows.Forms.Label spAtk;
		private System.Windows.Forms.Label spDef;
		private System.Windows.Forms.Label speed;
		private System.Windows.Forms.Label total;
		private System.Windows.Forms.Label type;
		private System.Windows.Forms.Label height;
		private System.Windows.Forms.Label weight;
		private System.Windows.Forms.Label hpNum;
		private System.Windows.Forms.Label attackNum;
		private System.Windows.Forms.Label defenseNum;
		private System.Windows.Forms.Label spAtkNum;
		private System.Windows.Forms.Label spDefNum;
		private System.Windows.Forms.Label speedNum;
		private System.Windows.Forms.Label totalNum;
		private System.Windows.Forms.Label idNum;
		private System.Windows.Forms.Label heightNum;
		private System.Windows.Forms.Label weightNum;
		private System.Windows.Forms.Label type1;
		private System.Windows.Forms.Label type2;
		private System.Windows.Forms.Label hpBar;
		private System.Windows.Forms.Label attackBar;
		private System.Windows.Forms.Label defenseBar;
		private System.Windows.Forms.Label spAtkBar;
		private System.Windows.Forms.Label spDefBar;
		private System.Windows.Forms.Label speedBar;
		private System.Windows.Forms.Button shinyButton;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button searchButton;
		private System.Windows.Forms.Button randomButton;
	}
}

