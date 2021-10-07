﻿
namespace TGS.Views {
    partial class SchedulePage {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulePage));
            this.pnl_Menu = new System.Windows.Forms.Panel();
            this.btn_MenuLogout = new FontAwesome.Sharp.IconButton();
            this.btn_MenuOptions = new FontAwesome.Sharp.IconButton();
            this.btn_MenuPacientes = new FontAwesome.Sharp.IconButton();
            this.btn_MenuChat = new FontAwesome.Sharp.IconButton();
            this.btn_MenuCalendar = new FontAwesome.Sharp.IconButton();
            this.btn_MenuHome = new FontAwesome.Sharp.IconButton();
            this.pnl_MenuLogo = new System.Windows.Forms.Panel();
            this.img_LogoMenu = new System.Windows.Forms.PictureBox();
            this.btn_MenuHamburger = new FontAwesome.Sharp.IconButton();
            this.img_Logo = new System.Windows.Forms.PictureBox();
            this.pnl_TitleBar = new System.Windows.Forms.Panel();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Welcome = new System.Windows.Forms.Label();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.tb_Content = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_HeaderList = new System.Windows.Forms.Panel();
            this.cb_ScheduleStatus = new System.Windows.Forms.ComboBox();
            this.txt_Date = new System.Windows.Forms.MaskedTextBox();
            this.btn_Return = new System.Windows.Forms.Panel();
            this.btn_Next = new System.Windows.Forms.Panel();
            this.lv_Schedule = new System.Windows.Forms.ListView();
            this.pnl_Menu.SuspendLayout();
            this.pnl_MenuLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_LogoMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).BeginInit();
            this.pnl_TitleBar.SuspendLayout();
            this.tb_Content.SuspendLayout();
            this.pnl_HeaderList.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Menu
            // 
            this.pnl_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(219)))));
            this.pnl_Menu.Controls.Add(this.btn_MenuLogout);
            this.pnl_Menu.Controls.Add(this.btn_MenuOptions);
            this.pnl_Menu.Controls.Add(this.btn_MenuPacientes);
            this.pnl_Menu.Controls.Add(this.btn_MenuChat);
            this.pnl_Menu.Controls.Add(this.btn_MenuCalendar);
            this.pnl_Menu.Controls.Add(this.btn_MenuHome);
            this.pnl_Menu.Controls.Add(this.pnl_MenuLogo);
            this.pnl_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Menu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Menu.Name = "pnl_Menu";
            this.pnl_Menu.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.pnl_Menu.Size = new System.Drawing.Size(263, 908);
            this.pnl_Menu.TabIndex = 0;
            // 
            // btn_MenuLogout
            // 
            this.btn_MenuLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_MenuLogout.FlatAppearance.BorderSize = 0;
            this.btn_MenuLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuLogout.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuLogout.ForeColor = System.Drawing.Color.White;
            this.btn_MenuLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btn_MenuLogout.IconColor = System.Drawing.Color.White;
            this.btn_MenuLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MenuLogout.IconSize = 30;
            this.btn_MenuLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuLogout.Location = new System.Drawing.Point(0, 841);
            this.btn_MenuLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_MenuLogout.Name = "btn_MenuLogout";
            this.btn_MenuLogout.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_MenuLogout.Size = new System.Drawing.Size(263, 47);
            this.btn_MenuLogout.TabIndex = 6;
            this.btn_MenuLogout.Tag = "Logout";
            this.btn_MenuLogout.Text = "  Logout";
            this.btn_MenuLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MenuLogout.UseVisualStyleBackColor = true;
            this.btn_MenuLogout.Click += new System.EventHandler(this.btn_MenuLogout_Click);
            // 
            // btn_MenuOptions
            // 
            this.btn_MenuOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MenuOptions.FlatAppearance.BorderSize = 0;
            this.btn_MenuOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuOptions.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuOptions.ForeColor = System.Drawing.Color.White;
            this.btn_MenuOptions.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.btn_MenuOptions.IconColor = System.Drawing.Color.White;
            this.btn_MenuOptions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MenuOptions.IconSize = 30;
            this.btn_MenuOptions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuOptions.Location = new System.Drawing.Point(0, 501);
            this.btn_MenuOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_MenuOptions.Name = "btn_MenuOptions";
            this.btn_MenuOptions.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_MenuOptions.Size = new System.Drawing.Size(263, 101);
            this.btn_MenuOptions.TabIndex = 5;
            this.btn_MenuOptions.Tag = "Options";
            this.btn_MenuOptions.Text = "  Configurações";
            this.btn_MenuOptions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuOptions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MenuOptions.UseVisualStyleBackColor = true;
            this.btn_MenuOptions.Click += new System.EventHandler(this.btn_MenuOptions_Click);
            // 
            // btn_MenuPacientes
            // 
            this.btn_MenuPacientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MenuPacientes.FlatAppearance.BorderSize = 0;
            this.btn_MenuPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuPacientes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuPacientes.ForeColor = System.Drawing.Color.White;
            this.btn_MenuPacientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btn_MenuPacientes.IconColor = System.Drawing.Color.White;
            this.btn_MenuPacientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MenuPacientes.IconSize = 30;
            this.btn_MenuPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuPacientes.Location = new System.Drawing.Point(0, 400);
            this.btn_MenuPacientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_MenuPacientes.Name = "btn_MenuPacientes";
            this.btn_MenuPacientes.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_MenuPacientes.Size = new System.Drawing.Size(263, 101);
            this.btn_MenuPacientes.TabIndex = 4;
            this.btn_MenuPacientes.Tag = "Patients";
            this.btn_MenuPacientes.Text = "  Pacientes";
            this.btn_MenuPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuPacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MenuPacientes.UseVisualStyleBackColor = true;
            this.btn_MenuPacientes.Click += new System.EventHandler(this.btn_MenuPacientes_Click);
            // 
            // btn_MenuChat
            // 
            this.btn_MenuChat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MenuChat.FlatAppearance.BorderSize = 0;
            this.btn_MenuChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuChat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuChat.ForeColor = System.Drawing.Color.White;
            this.btn_MenuChat.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.btn_MenuChat.IconColor = System.Drawing.Color.White;
            this.btn_MenuChat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MenuChat.IconSize = 30;
            this.btn_MenuChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuChat.Location = new System.Drawing.Point(0, 299);
            this.btn_MenuChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_MenuChat.Name = "btn_MenuChat";
            this.btn_MenuChat.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_MenuChat.Size = new System.Drawing.Size(263, 101);
            this.btn_MenuChat.TabIndex = 3;
            this.btn_MenuChat.Tag = "Chat";
            this.btn_MenuChat.Text = "  Chat";
            this.btn_MenuChat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuChat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MenuChat.UseVisualStyleBackColor = true;
            this.btn_MenuChat.Click += new System.EventHandler(this.btn_MenuChat_Click);
            // 
            // btn_MenuCalendar
            // 
            this.btn_MenuCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MenuCalendar.FlatAppearance.BorderSize = 0;
            this.btn_MenuCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuCalendar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuCalendar.ForeColor = System.Drawing.Color.White;
            this.btn_MenuCalendar.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btn_MenuCalendar.IconColor = System.Drawing.Color.White;
            this.btn_MenuCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MenuCalendar.IconSize = 30;
            this.btn_MenuCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuCalendar.Location = new System.Drawing.Point(0, 198);
            this.btn_MenuCalendar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_MenuCalendar.Name = "btn_MenuCalendar";
            this.btn_MenuCalendar.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_MenuCalendar.Size = new System.Drawing.Size(263, 101);
            this.btn_MenuCalendar.TabIndex = 2;
            this.btn_MenuCalendar.Tag = "Calendar";
            this.btn_MenuCalendar.Text = "  Calendário";
            this.btn_MenuCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MenuCalendar.UseVisualStyleBackColor = true;
            this.btn_MenuCalendar.Click += new System.EventHandler(this.btn_MenuCalendar_Click);
            // 
            // btn_MenuHome
            // 
            this.btn_MenuHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_MenuHome.FlatAppearance.BorderSize = 0;
            this.btn_MenuHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuHome.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_MenuHome.ForeColor = System.Drawing.Color.White;
            this.btn_MenuHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_MenuHome.IconColor = System.Drawing.Color.White;
            this.btn_MenuHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MenuHome.IconSize = 30;
            this.btn_MenuHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuHome.Location = new System.Drawing.Point(0, 97);
            this.btn_MenuHome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_MenuHome.Name = "btn_MenuHome";
            this.btn_MenuHome.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.btn_MenuHome.Size = new System.Drawing.Size(263, 101);
            this.btn_MenuHome.TabIndex = 1;
            this.btn_MenuHome.Tag = "Home";
            this.btn_MenuHome.Text = "  Home";
            this.btn_MenuHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MenuHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MenuHome.UseVisualStyleBackColor = true;
            // 
            // pnl_MenuLogo
            // 
            this.pnl_MenuLogo.Controls.Add(this.img_LogoMenu);
            this.pnl_MenuLogo.Controls.Add(this.btn_MenuHamburger);
            this.pnl_MenuLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_MenuLogo.Location = new System.Drawing.Point(0, 0);
            this.pnl_MenuLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_MenuLogo.Name = "pnl_MenuLogo";
            this.pnl_MenuLogo.Size = new System.Drawing.Size(263, 97);
            this.pnl_MenuLogo.TabIndex = 0;
            // 
            // img_LogoMenu
            // 
            this.img_LogoMenu.Image = ((System.Drawing.Image)(resources.GetObject("img_LogoMenu.Image")));
            this.img_LogoMenu.Location = new System.Drawing.Point(38, 16);
            this.img_LogoMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.img_LogoMenu.Name = "img_LogoMenu";
            this.img_LogoMenu.Size = new System.Drawing.Size(119, 67);
            this.img_LogoMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_LogoMenu.TabIndex = 2;
            this.img_LogoMenu.TabStop = false;
            // 
            // btn_MenuHamburger
            // 
            this.btn_MenuHamburger.FlatAppearance.BorderSize = 0;
            this.btn_MenuHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MenuHamburger.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btn_MenuHamburger.IconColor = System.Drawing.Color.White;
            this.btn_MenuHamburger.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_MenuHamburger.IconSize = 30;
            this.btn_MenuHamburger.Location = new System.Drawing.Point(187, 16);
            this.btn_MenuHamburger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_MenuHamburger.Name = "btn_MenuHamburger";
            this.btn_MenuHamburger.Size = new System.Drawing.Size(69, 80);
            this.btn_MenuHamburger.TabIndex = 1;
            this.btn_MenuHamburger.UseVisualStyleBackColor = true;
            this.btn_MenuHamburger.Click += new System.EventHandler(this.btn_MenuHamburger_Click);
            // 
            // img_Logo
            // 
            this.img_Logo.Image = ((System.Drawing.Image)(resources.GetObject("img_Logo.Image")));
            this.img_Logo.Location = new System.Drawing.Point(7, 4);
            this.img_Logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.img_Logo.Name = "img_Logo";
            this.img_Logo.Size = new System.Drawing.Size(82, 84);
            this.img_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Logo.TabIndex = 0;
            this.img_Logo.TabStop = false;
            // 
            // pnl_TitleBar
            // 
            this.pnl_TitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.pnl_TitleBar.Controls.Add(this.lbl_Date);
            this.pnl_TitleBar.Controls.Add(this.lbl_Welcome);
            this.pnl_TitleBar.Controls.Add(this.btn_Minimize);
            this.pnl_TitleBar.Controls.Add(this.img_Logo);
            this.pnl_TitleBar.Controls.Add(this.btn_Maximize);
            this.pnl_TitleBar.Controls.Add(this.btn_Close);
            this.pnl_TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TitleBar.Location = new System.Drawing.Point(263, 0);
            this.pnl_TitleBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_TitleBar.Name = "pnl_TitleBar";
            this.pnl_TitleBar.Size = new System.Drawing.Size(1182, 97);
            this.pnl_TitleBar.TabIndex = 1;
            this.pnl_TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_TitleBar_MouseDown);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(88)))), ((int)(((byte)(145)))));
            this.lbl_Date.Location = new System.Drawing.Point(106, 48);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(123, 37);
            this.lbl_Date.TabIndex = 6;
            this.lbl_Date.Text = "--/--/----";
            // 
            // lbl_Welcome
            // 
            this.lbl_Welcome.AutoSize = true;
            this.lbl_Welcome.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Welcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(88)))), ((int)(((byte)(145)))));
            this.lbl_Welcome.Location = new System.Drawing.Point(96, 4);
            this.lbl_Welcome.Name = "lbl_Welcome";
            this.lbl_Welcome.Size = new System.Drawing.Size(178, 47);
            this.lbl_Welcome.TabIndex = 5;
            this.lbl_Welcome.Text = "Agenda";
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_Minimize.IconColor = System.Drawing.Color.White;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 20;
            this.btn_Minimize.Location = new System.Drawing.Point(1027, 0);
            this.btn_Minimize.Margin = new System.Windows.Forms.Padding(3, 4, 0, 4);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(51, 33);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.UseVisualStyleBackColor = false;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(219)))));
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.btn_Maximize.IconColor = System.Drawing.Color.White;
            this.btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximize.IconSize = 20;
            this.btn_Maximize.Location = new System.Drawing.Point(1079, 0);
            this.btn_Maximize.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Size = new System.Drawing.Size(51, 33);
            this.btn_Maximize.TabIndex = 3;
            this.btn_Maximize.UseVisualStyleBackColor = false;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(74)))), ((int)(((byte)(130)))));
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_Close.IconColor = System.Drawing.Color.White;
            this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Close.IconSize = 20;
            this.btn_Close.Location = new System.Drawing.Point(1130, 0);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(0, 4, 3, 4);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(51, 33);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tb_Content
            // 
            this.tb_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.tb_Content.ColumnCount = 3;
            this.tb_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tb_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_Content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tb_Content.Controls.Add(this.pnl_HeaderList, 1, 1);
            this.tb_Content.Controls.Add(this.lv_Schedule, 1, 3);
            this.tb_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Content.Location = new System.Drawing.Point(263, 97);
            this.tb_Content.Name = "tb_Content";
            this.tb_Content.RowCount = 5;
            this.tb_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tb_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tb_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tb_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tb_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tb_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tb_Content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tb_Content.Size = new System.Drawing.Size(1182, 811);
            this.tb_Content.TabIndex = 2;
            // 
            // pnl_HeaderList
            // 
            this.pnl_HeaderList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(219)))));
            this.pnl_HeaderList.Controls.Add(this.cb_ScheduleStatus);
            this.pnl_HeaderList.Controls.Add(this.txt_Date);
            this.pnl_HeaderList.Controls.Add(this.btn_Return);
            this.pnl_HeaderList.Controls.Add(this.btn_Next);
            this.pnl_HeaderList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_HeaderList.Location = new System.Drawing.Point(13, 13);
            this.pnl_HeaderList.Name = "pnl_HeaderList";
            this.pnl_HeaderList.Size = new System.Drawing.Size(1156, 94);
            this.pnl_HeaderList.TabIndex = 1;
            // 
            // cb_ScheduleStatus
            // 
            this.cb_ScheduleStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(219)))));
            this.cb_ScheduleStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_ScheduleStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cb_ScheduleStatus.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_ScheduleStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(88)))), ((int)(((byte)(145)))));
            this.cb_ScheduleStatus.FormattingEnabled = true;
            this.cb_ScheduleStatus.Items.AddRange(new object[] {
            "Agenda Livre",
            "Agenda Ocupada"});
            this.cb_ScheduleStatus.Location = new System.Drawing.Point(90, 0);
            this.cb_ScheduleStatus.MaxDropDownItems = 2;
            this.cb_ScheduleStatus.Name = "cb_ScheduleStatus";
            this.cb_ScheduleStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cb_ScheduleStatus.Size = new System.Drawing.Size(976, 45);
            this.cb_ScheduleStatus.TabIndex = 4;
            this.cb_ScheduleStatus.Text = "Agenda Livre";
            // 
            // txt_Date
            // 
            this.txt_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(130)))), ((int)(((byte)(219)))));
            this.txt_Date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Date.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txt_Date.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(88)))), ((int)(((byte)(145)))));
            this.txt_Date.Location = new System.Drawing.Point(90, 60);
            this.txt_Date.Mask = "00/00/0000";
            this.txt_Date.Name = "txt_Date";
            this.txt_Date.Size = new System.Drawing.Size(976, 34);
            this.txt_Date.TabIndex = 3;
            this.txt_Date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Date.ValidatingType = typeof(System.DateTime);
            // 
            // btn_Return
            // 
            this.btn_Return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Return.BackgroundImage")));
            this.btn_Return.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Return.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Return.Location = new System.Drawing.Point(0, 0);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.Size = new System.Drawing.Size(90, 94);
            this.btn_Return.TabIndex = 1;
            // 
            // btn_Next
            // 
            this.btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Next.BackgroundImage")));
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Next.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Next.Location = new System.Drawing.Point(1066, 0);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(90, 94);
            this.btn_Next.TabIndex = 0;
            // 
            // lv_Schedule
            // 
            this.lv_Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(235)))), ((int)(((byte)(252)))));
            this.lv_Schedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Schedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_Schedule.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lv_Schedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(88)))), ((int)(((byte)(145)))));
            this.lv_Schedule.HideSelection = false;
            this.lv_Schedule.Location = new System.Drawing.Point(13, 118);
            this.lv_Schedule.Name = "lv_Schedule";
            this.lv_Schedule.Size = new System.Drawing.Size(1156, 680);
            this.lv_Schedule.TabIndex = 2;
            this.lv_Schedule.UseCompatibleStateImageBehavior = false;
            this.lv_Schedule.View = System.Windows.Forms.View.Details;
            // 
            // SchedulePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1445, 908);
            this.Controls.Add(this.tb_Content);
            this.Controls.Add(this.pnl_TitleBar);
            this.Controls.Add(this.pnl_Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SchedulePage";
            this.Text = "Home";
            this.Resize += new System.EventHandler(this.Home_Resize);
            this.pnl_Menu.ResumeLayout(false);
            this.pnl_MenuLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_LogoMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_Logo)).EndInit();
            this.pnl_TitleBar.ResumeLayout(false);
            this.pnl_TitleBar.PerformLayout();
            this.tb_Content.ResumeLayout(false);
            this.pnl_HeaderList.ResumeLayout(false);
            this.pnl_HeaderList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Menu;
        private System.Windows.Forms.Panel pnl_MenuLogo;
        private System.Windows.Forms.PictureBox img_Logo;
        private System.Windows.Forms.Panel pnl_TitleBar;
        private FontAwesome.Sharp.IconButton btn_MenuLogout;
        private FontAwesome.Sharp.IconButton btn_MenuOptions;
        private FontAwesome.Sharp.IconButton btn_MenuPacientes;
        private FontAwesome.Sharp.IconButton btn_MenuChat;
        private FontAwesome.Sharp.IconButton btn_MenuCalendar;
        private FontAwesome.Sharp.IconButton btn_MenuHome;
        private FontAwesome.Sharp.IconButton btn_MenuHamburger;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private FontAwesome.Sharp.IconButton btn_Close;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Welcome;
        private System.Windows.Forms.PictureBox img_LogoMenu;
        private System.Windows.Forms.TableLayoutPanel tb_Content;
        private System.Windows.Forms.Panel pnl_HeaderList;
        private System.Windows.Forms.ListView lv_Schedule;
        private System.Windows.Forms.Panel btn_Return;
        private System.Windows.Forms.Panel btn_Next;
        private System.Windows.Forms.ComboBox cb_ScheduleStatus;
        private System.Windows.Forms.MaskedTextBox txt_Date;
    }
}