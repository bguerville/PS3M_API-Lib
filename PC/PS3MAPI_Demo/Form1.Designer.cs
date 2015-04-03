namespace PS3Lib_Mod_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.textOutput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAttach = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.comboB_Procs = new System.Windows.Forms.ComboBox();
            this.lblProcs = new System.Windows.Forms.Label();
            this.tabC_Global = new System.Windows.Forms.TabControl();
            this.tabP_PS3 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Setup = new System.Windows.Forms.Button();
            this.btn_FileManager = new System.Windows.Forms.Button();
            this.btn_GameManager = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.p_PS3_Notify = new System.Windows.Forms.Panel();
            this.tB_PS3_Notify = new System.Windows.Forms.TextBox();
            this.btn_PS3_Notify = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.p_PS3_MimicOFW = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_SetPSID = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.mtxtB_PSID = new System.Windows.Forms.MaskedTextBox();
            this.btn_SetIDPS = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_PS3_ClearHistory = new System.Windows.Forms.Button();
            this.mtxtB_IDPS = new System.Windows.Forms.MaskedTextBox();
            this.cb_RemoveHook = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_8_D = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_8_P3 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_8_P2 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_8_P1 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_8 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_36 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_35 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_11 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_10 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_9 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_7 = new System.Windows.Forms.CheckBox();
            this.cb_Syscall_6 = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cB_PS3_MIMICOFW = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PS3_DisableSyscall = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.p_PS3_Led = new System.Windows.Forms.Panel();
            this.cB_PS3_Led_Color = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_PS3_Led_Set = new System.Windows.Forms.Button();
            this.cB_PS3_Led_Mode = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.p_PS3_Buzzer = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Ring_Buzzer = new System.Windows.Forms.Button();
            this.cB_PS3_Buzzer = new System.Windows.Forms.ComboBox();
            this.p_PS3_Power = new System.Windows.Forms.Panel();
            this.btn_Power_Execute = new System.Windows.Forms.Button();
            this.cB_PS3_Power = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Temp_Refresh = new System.Windows.Forms.Button();
            this.lbl_Temp_CPU = new System.Windows.Forms.Label();
            this.lbl_Temp_RSX = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_core_version = new System.Windows.Forms.Label();
            this.lbl_fw = new System.Windows.Forms.Label();
            this.tabP_Processes = new System.Windows.Forms.TabPage();
            this.p_Process = new System.Windows.Forms.Panel();
            this.btnUnattach = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.p_SetMem = new System.Windows.Forms.Panel();
            this.txtB_SetOffset = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.btnSetMem = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.p_GetMem = new System.Windows.Forms.Panel();
            this.txtB_GetOffset = new System.Windows.Forms.TextBox();
            this.nUD_GetLength = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.tabP_Plugins = new System.Windows.Forms.TabPage();
            this.VSHPlug_Refresh = new System.Windows.Forms.Button();
            this.OthersPlug_Refresh = new System.Windows.Forms.Button();
            this.label47 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label49 = new System.Windows.Forms.Label();
            this.OthersPlug_Process_2 = new System.Windows.Forms.ComboBox();
            this.OthersPlug_Process_1 = new System.Windows.Forms.ComboBox();
            this.OthersPlug_Process_0 = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.btn_OthersPlug_0 = new System.Windows.Forms.Button();
            this.btn_OthersPlug_1 = new System.Windows.Forms.Button();
            this.btn_OthersPlug_2 = new System.Windows.Forms.Button();
            this.OthersPlug_Path_0 = new System.Windows.Forms.TextBox();
            this.OthersPlug_Path_1 = new System.Windows.Forms.TextBox();
            this.OthersPlug_Path_2 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.OthersPlug_Name_0 = new System.Windows.Forms.Label();
            this.OthersPlug_Name_1 = new System.Windows.Forms.Label();
            this.OthersPlug_Name_2 = new System.Windows.Forms.Label();
            this.btn_PluginsAdv = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.VSHPlug_Path_6 = new System.Windows.Forms.TextBox();
            this.VSHPlug_Path_5 = new System.Windows.Forms.TextBox();
            this.VSHPlug_Path_4 = new System.Windows.Forms.TextBox();
            this.VSHPlug_Path_3 = new System.Windows.Forms.TextBox();
            this.VSHPlug_Path_2 = new System.Windows.Forms.TextBox();
            this.VSHPlug_Path_1 = new System.Windows.Forms.TextBox();
            this.VSHPlug_Name_6 = new System.Windows.Forms.Label();
            this.VSHPlug_Name_5 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.VSHPlug_Name_4 = new System.Windows.Forms.Label();
            this.VSHPlug_Name_3 = new System.Windows.Forms.Label();
            this.VSHPlug_Name_2 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.VSHPlug_Path_0 = new System.Windows.Forms.TextBox();
            this.btn_VSHPlug_0 = new System.Windows.Forms.Button();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.VSHPlug_Name_0 = new System.Windows.Forms.Label();
            this.VSHPlug_Name_1 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.btn_VSHPlug_6 = new System.Windows.Forms.Button();
            this.btn_VSHPlug_5 = new System.Windows.Forms.Button();
            this.btn_VSHPlug_4 = new System.Windows.Forms.Button();
            this.btn_VSHPlug_3 = new System.Windows.Forms.Button();
            this.btn_VSHPlug_2 = new System.Windows.Forms.Button();
            this.btn_VSHPlug_1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabP_PluginsAdv = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAttach2 = new System.Windows.Forms.Button();
            this.btnUnattach2 = new System.Windows.Forms.Button();
            this.btnRefresh2 = new System.Windows.Forms.Button();
            this.comboB_Procs2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_PluginsSimple = new System.Windows.Forms.Button();
            this.btn_Module_Unload = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_Module_Load = new System.Windows.Forms.Button();
            this.tB_Module_Path = new System.Windows.Forms.TextBox();
            this.btn_Module_Refresh = new System.Windows.Forms.Button();
            this.lV_Modules = new System.Windows.Forms.ListView();
            this.cH_Modules_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cH_Modules_Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtB_Port = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtB_Ip = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p_Connection = new System.Windows.Forms.Panel();
            this.btn_ShowLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Lib_Version = new System.Windows.Forms.Label();
            this.p_PluginsAdv = new System.Windows.Forms.Panel();
            this.tabC_Global.SuspendLayout();
            this.tabP_PS3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.p_PS3_Notify.SuspendLayout();
            this.p_PS3_MimicOFW.SuspendLayout();
            this.p_PS3_Led.SuspendLayout();
            this.p_PS3_Buzzer.SuspendLayout();
            this.p_PS3_Power.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabP_Processes.SuspendLayout();
            this.p_Process.SuspendLayout();
            this.p_SetMem.SuspendLayout();
            this.p_GetMem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_GetLength)).BeginInit();
            this.tabP_Plugins.SuspendLayout();
            this.panel9.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabP_PluginsAdv.SuspendLayout();
            this.panel6.SuspendLayout();
            this.p_Connection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.p_PluginsAdv.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(383, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(87, 27);
            this.btnDisconnect.TabIndex = 9;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(290, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(87, 27);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // textOutput
            // 
            this.textOutput.BackColor = System.Drawing.SystemColors.Control;
            this.textOutput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textOutput.Location = new System.Drawing.Point(0, 62);
            this.textOutput.MaxLength = 2147483647;
            this.textOutput.Multiline = true;
            this.textOutput.Name = "textOutput";
            this.textOutput.ReadOnly = true;
            this.textOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textOutput.Size = new System.Drawing.Size(758, 119);
            this.textOutput.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(640, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Get";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGetMem_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.Enabled = false;
            this.btnAttach.Location = new System.Drawing.Point(425, 4);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.Size = new System.Drawing.Size(87, 23);
            this.btnAttach.TabIndex = 3;
            this.btnAttach.Text = "Attach";
            this.btnAttach.UseVisualStyleBackColor = true;
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Location = new System.Drawing.Point(288, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboB_Procs
            // 
            this.comboB_Procs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_Procs.Enabled = false;
            this.comboB_Procs.FormattingEnabled = true;
            this.comboB_Procs.Location = new System.Drawing.Point(26, 4);
            this.comboB_Procs.MaxDropDownItems = 16;
            this.comboB_Procs.Name = "comboB_Procs";
            this.comboB_Procs.Size = new System.Drawing.Size(226, 23);
            this.comboB_Procs.TabIndex = 1;
            this.comboB_Procs.SelectedIndexChanged += new System.EventHandler(this.comboB_Procs_SelectedIndexChanged);
            // 
            // lblProcs
            // 
            this.lblProcs.AutoSize = true;
            this.lblProcs.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcs.Location = new System.Drawing.Point(8, 14);
            this.lblProcs.Name = "lblProcs";
            this.lblProcs.Size = new System.Drawing.Size(66, 20);
            this.lblProcs.TabIndex = 0;
            this.lblProcs.Text = "Process:";
            // 
            // tabC_Global
            // 
            this.tabC_Global.Controls.Add(this.tabP_PS3);
            this.tabC_Global.Controls.Add(this.tabP_Processes);
            this.tabC_Global.Controls.Add(this.tabP_Plugins);
            this.tabC_Global.Controls.Add(this.tabP_PluginsAdv);
            this.tabC_Global.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabC_Global.Enabled = false;
            this.tabC_Global.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabC_Global.Location = new System.Drawing.Point(0, 106);
            this.tabC_Global.Name = "tabC_Global";
            this.tabC_Global.SelectedIndex = 0;
            this.tabC_Global.Size = new System.Drawing.Size(784, 505);
            this.tabC_Global.TabIndex = 25;
            // 
            // tabP_PS3
            // 
            this.tabP_PS3.BackColor = System.Drawing.Color.White;
            this.tabP_PS3.Controls.Add(this.label8);
            this.tabP_PS3.Controls.Add(this.panel3);
            this.tabP_PS3.Controls.Add(this.label20);
            this.tabP_PS3.Controls.Add(this.p_PS3_Notify);
            this.tabP_PS3.Controls.Add(this.label19);
            this.tabP_PS3.Controls.Add(this.p_PS3_MimicOFW);
            this.tabP_PS3.Controls.Add(this.label13);
            this.tabP_PS3.Controls.Add(this.p_PS3_Led);
            this.tabP_PS3.Controls.Add(this.label15);
            this.tabP_PS3.Controls.Add(this.label14);
            this.tabP_PS3.Controls.Add(this.label11);
            this.tabP_PS3.Controls.Add(this.p_PS3_Buzzer);
            this.tabP_PS3.Controls.Add(this.p_PS3_Power);
            this.tabP_PS3.Controls.Add(this.label10);
            this.tabP_PS3.Controls.Add(this.panel2);
            this.tabP_PS3.Controls.Add(this.panel1);
            this.tabP_PS3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabP_PS3.Location = new System.Drawing.Point(4, 26);
            this.tabP_PS3.Name = "tabP_PS3";
            this.tabP_PS3.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_PS3.Size = new System.Drawing.Size(776, 475);
            this.tabP_PS3.TabIndex = 0;
            this.tabP_PS3.Text = "PS3 Commands";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(259, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "webMAN:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_Setup);
            this.panel3.Controls.Add(this.btn_FileManager);
            this.panel3.Controls.Add(this.btn_GameManager);
            this.panel3.Location = new System.Drawing.Point(263, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(504, 39);
            this.panel3.TabIndex = 17;
            // 
            // btn_Setup
            // 
            this.btn_Setup.Location = new System.Drawing.Point(351, 6);
            this.btn_Setup.Name = "btn_Setup";
            this.btn_Setup.Size = new System.Drawing.Size(108, 24);
            this.btn_Setup.TabIndex = 18;
            this.btn_Setup.Text = "Setup";
            this.btn_Setup.UseVisualStyleBackColor = true;
            this.btn_Setup.Click += new System.EventHandler(this.btn_Setup_Click);
            // 
            // btn_FileManager
            // 
            this.btn_FileManager.Location = new System.Drawing.Point(39, 6);
            this.btn_FileManager.Name = "btn_FileManager";
            this.btn_FileManager.Size = new System.Drawing.Size(108, 24);
            this.btn_FileManager.TabIndex = 17;
            this.btn_FileManager.Text = "Files Manager";
            this.btn_FileManager.UseVisualStyleBackColor = true;
            this.btn_FileManager.Click += new System.EventHandler(this.btn_FileManager_Click);
            // 
            // btn_GameManager
            // 
            this.btn_GameManager.Location = new System.Drawing.Point(199, 6);
            this.btn_GameManager.Name = "btn_GameManager";
            this.btn_GameManager.Size = new System.Drawing.Size(108, 24);
            this.btn_GameManager.TabIndex = 16;
            this.btn_GameManager.Text = "Games Manager";
            this.btn_GameManager.UseVisualStyleBackColor = true;
            this.btn_GameManager.Click += new System.EventHandler(this.btn_GameManager_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(259, 158);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(88, 20);
            this.label20.TabIndex = 16;
            this.label20.Text = "PS3 Notify:";
            // 
            // p_PS3_Notify
            // 
            this.p_PS3_Notify.BackColor = System.Drawing.SystemColors.Control;
            this.p_PS3_Notify.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_PS3_Notify.Controls.Add(this.tB_PS3_Notify);
            this.p_PS3_Notify.Controls.Add(this.btn_PS3_Notify);
            this.p_PS3_Notify.Location = new System.Drawing.Point(263, 181);
            this.p_PS3_Notify.Name = "p_PS3_Notify";
            this.p_PS3_Notify.Size = new System.Drawing.Size(504, 72);
            this.p_PS3_Notify.TabIndex = 15;
            // 
            // tB_PS3_Notify
            // 
            this.tB_PS3_Notify.BackColor = System.Drawing.SystemColors.Control;
            this.tB_PS3_Notify.Location = new System.Drawing.Point(7, 8);
            this.tB_PS3_Notify.MaxLength = 200;
            this.tB_PS3_Notify.Multiline = true;
            this.tB_PS3_Notify.Name = "tB_PS3_Notify";
            this.tB_PS3_Notify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_PS3_Notify.Size = new System.Drawing.Size(399, 53);
            this.tB_PS3_Notify.TabIndex = 16;
            // 
            // btn_PS3_Notify
            // 
            this.btn_PS3_Notify.Location = new System.Drawing.Point(412, 23);
            this.btn_PS3_Notify.Name = "btn_PS3_Notify";
            this.btn_PS3_Notify.Size = new System.Drawing.Size(87, 24);
            this.btn_PS3_Notify.TabIndex = 15;
            this.btn_PS3_Notify.Text = "Notify";
            this.btn_PS3_Notify.UseVisualStyleBackColor = true;
            this.btn_PS3_Notify.Click += new System.EventHandler(this.btn_PS3_Notify_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 256);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 20);
            this.label19.TabIndex = 14;
            this.label19.Text = "PS3 Mimic OFW:";
            // 
            // p_PS3_MimicOFW
            // 
            this.p_PS3_MimicOFW.BackColor = System.Drawing.SystemColors.Control;
            this.p_PS3_MimicOFW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_PS3_MimicOFW.Controls.Add(this.panel5);
            this.p_PS3_MimicOFW.Controls.Add(this.btn_SetPSID);
            this.p_PS3_MimicOFW.Controls.Add(this.label9);
            this.p_PS3_MimicOFW.Controls.Add(this.mtxtB_PSID);
            this.p_PS3_MimicOFW.Controls.Add(this.btn_SetIDPS);
            this.p_PS3_MimicOFW.Controls.Add(this.label7);
            this.p_PS3_MimicOFW.Controls.Add(this.btn_PS3_ClearHistory);
            this.p_PS3_MimicOFW.Controls.Add(this.mtxtB_IDPS);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_RemoveHook);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_8_D);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_8_P3);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_8_P2);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_8_P1);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_8);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_36);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_35);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_11);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_10);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_9);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_7);
            this.p_PS3_MimicOFW.Controls.Add(this.cb_Syscall_6);
            this.p_PS3_MimicOFW.Controls.Add(this.panel4);
            this.p_PS3_MimicOFW.Controls.Add(this.cB_PS3_MIMICOFW);
            this.p_PS3_MimicOFW.Controls.Add(this.label24);
            this.p_PS3_MimicOFW.Controls.Add(this.label1);
            this.p_PS3_MimicOFW.Controls.Add(this.btn_PS3_DisableSyscall);
            this.p_PS3_MimicOFW.Location = new System.Drawing.Point(10, 279);
            this.p_PS3_MimicOFW.Name = "p_PS3_MimicOFW";
            this.p_PS3_MimicOFW.Size = new System.Drawing.Size(759, 188);
            this.p_PS3_MimicOFW.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(9, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(735, 2);
            this.panel5.TabIndex = 49;
            // 
            // btn_SetPSID
            // 
            this.btn_SetPSID.Location = new System.Drawing.Point(657, 9);
            this.btn_SetPSID.Name = "btn_SetPSID";
            this.btn_SetPSID.Size = new System.Drawing.Size(60, 24);
            this.btn_SetPSID.TabIndex = 47;
            this.btn_SetPSID.Text = "Set";
            this.btn_SetPSID.UseVisualStyleBackColor = true;
            this.btn_SetPSID.Click += new System.EventHandler(this.btn_PS3_SetPSID_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(387, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "PSID:";
            // 
            // mtxtB_PSID
            // 
            this.mtxtB_PSID.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtB_PSID.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxtB_PSID.Location = new System.Drawing.Point(436, 9);
            this.mtxtB_PSID.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.mtxtB_PSID.Name = "mtxtB_PSID";
            this.mtxtB_PSID.PromptChar = '0';
            this.mtxtB_PSID.Size = new System.Drawing.Size(215, 23);
            this.mtxtB_PSID.TabIndex = 45;
            this.mtxtB_PSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtB_PSID.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
            this.mtxtB_PSID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_HexOnly);
            // 
            // btn_SetIDPS
            // 
            this.btn_SetIDPS.Location = new System.Drawing.Point(288, 9);
            this.btn_SetIDPS.Name = "btn_SetIDPS";
            this.btn_SetIDPS.Size = new System.Drawing.Size(60, 24);
            this.btn_SetIDPS.TabIndex = 44;
            this.btn_SetIDPS.Text = "Set";
            this.btn_SetIDPS.UseVisualStyleBackColor = true;
            this.btn_SetIDPS.Click += new System.EventHandler(this.btn_PS3_SetIDPS_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "IDPS:";
            // 
            // btn_PS3_ClearHistory
            // 
            this.btn_PS3_ClearHistory.Location = new System.Drawing.Point(135, 54);
            this.btn_PS3_ClearHistory.Name = "btn_PS3_ClearHistory";
            this.btn_PS3_ClearHistory.Size = new System.Drawing.Size(60, 24);
            this.btn_PS3_ClearHistory.TabIndex = 22;
            this.btn_PS3_ClearHistory.Text = "Clear";
            this.btn_PS3_ClearHistory.UseVisualStyleBackColor = true;
            this.btn_PS3_ClearHistory.Click += new System.EventHandler(this.btn_PS3_ClearHistory_Click);
            // 
            // mtxtB_IDPS
            // 
            this.mtxtB_IDPS.BackColor = System.Drawing.SystemColors.Control;
            this.mtxtB_IDPS.Location = new System.Drawing.Point(67, 10);
            this.mtxtB_IDPS.Mask = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
            this.mtxtB_IDPS.Name = "mtxtB_IDPS";
            this.mtxtB_IDPS.PromptChar = '0';
            this.mtxtB_IDPS.Size = new System.Drawing.Size(215, 23);
            this.mtxtB_IDPS.TabIndex = 42;
            this.mtxtB_IDPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtB_IDPS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_HexOnly);
            // 
            // cb_RemoveHook
            // 
            this.cb_RemoveHook.AutoSize = true;
            this.cb_RemoveHook.Enabled = false;
            this.cb_RemoveHook.Location = new System.Drawing.Point(559, 158);
            this.cb_RemoveHook.Name = "cb_RemoveHook";
            this.cb_RemoveHook.Size = new System.Drawing.Size(122, 19);
            this.cb_RemoveHook.TabIndex = 39;
            this.cb_RemoveHook.Text = "Also remove hook";
            this.cb_RemoveHook.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_8_D
            // 
            this.cb_Syscall_8_D.AutoSize = true;
            this.cb_Syscall_8_D.Enabled = false;
            this.cb_Syscall_8_D.Location = new System.Drawing.Point(479, 158);
            this.cb_Syscall_8_D.Name = "cb_Syscall_8_D";
            this.cb_Syscall_8_D.Size = new System.Drawing.Size(64, 19);
            this.cb_Syscall_8_D.TabIndex = 38;
            this.cb_Syscall_8_D.Text = "Disable";
            this.cb_Syscall_8_D.UseVisualStyleBackColor = true;
            this.cb_Syscall_8_D.CheckedChanged += new System.EventHandler(this.cb_Syscall_8_D_CheckedChanged);
            // 
            // cb_Syscall_8_P3
            // 
            this.cb_Syscall_8_P3.AutoSize = true;
            this.cb_Syscall_8_P3.Enabled = false;
            this.cb_Syscall_8_P3.Location = new System.Drawing.Point(479, 133);
            this.cb_Syscall_8_P3.Name = "cb_Syscall_8_P3";
            this.cb_Syscall_8_P3.Size = new System.Drawing.Size(199, 19);
            this.cb_Syscall_8_P3.TabIndex = 37;
            this.cb_Syscall_8_P3.Text = "Fake Disable (Can be re-enabled)";
            this.cb_Syscall_8_P3.UseVisualStyleBackColor = true;
            this.cb_Syscall_8_P3.CheckedChanged += new System.EventHandler(this.cb_Syscall_8_P3_CheckedChanged);
            // 
            // cb_Syscall_8_P2
            // 
            this.cb_Syscall_8_P2.AutoSize = true;
            this.cb_Syscall_8_P2.Enabled = false;
            this.cb_Syscall_8_P2.Location = new System.Drawing.Point(479, 108);
            this.cb_Syscall_8_P2.Name = "cb_Syscall_8_P2";
            this.cb_Syscall_8_P2.Size = new System.Drawing.Size(218, 19);
            this.cb_Syscall_8_P2.TabIndex = 36;
            this.cb_Syscall_8_P2.Text = "Partial: Keep only PS3M_Api features";
            this.cb_Syscall_8_P2.UseVisualStyleBackColor = true;
            this.cb_Syscall_8_P2.CheckedChanged += new System.EventHandler(this.cb_Syscall_8_P2_CheckedChanged);
            // 
            // cb_Syscall_8_P1
            // 
            this.cb_Syscall_8_P1.AutoSize = true;
            this.cb_Syscall_8_P1.Enabled = false;
            this.cb_Syscall_8_P1.Location = new System.Drawing.Point(479, 83);
            this.cb_Syscall_8_P1.Name = "cb_Syscall_8_P1";
            this.cb_Syscall_8_P1.Size = new System.Drawing.Size(275, 19);
            this.cb_Syscall_8_P1.TabIndex = 35;
            this.cb_Syscall_8_P1.Text = "Partial: Keep Cobra/Mamba/PS3M_Api features";
            this.cb_Syscall_8_P1.UseVisualStyleBackColor = true;
            this.cb_Syscall_8_P1.CheckedChanged += new System.EventHandler(this.cb_Syscall_8_P1_CheckedChanged);
            // 
            // cb_Syscall_8
            // 
            this.cb_Syscall_8.AutoSize = true;
            this.cb_Syscall_8.Location = new System.Drawing.Point(463, 58);
            this.cb_Syscall_8.Name = "cb_Syscall_8";
            this.cb_Syscall_8.Size = new System.Drawing.Size(252, 19);
            this.cb_Syscall_8.TabIndex = 34;
            this.cb_Syscall_8.Text = "[8] COBRA/MAMBA/PS3M_API/EXTENDED";
            this.cb_Syscall_8.UseVisualStyleBackColor = true;
            this.cb_Syscall_8.CheckedChanged += new System.EventHandler(this.cb_Syscall_8_CheckedChanged);
            // 
            // cb_Syscall_36
            // 
            this.cb_Syscall_36.AutoSize = true;
            this.cb_Syscall_36.Location = new System.Drawing.Point(281, 158);
            this.cb_Syscall_36.Name = "cb_Syscall_36";
            this.cb_Syscall_36.Size = new System.Drawing.Size(107, 19);
            this.cb_Syscall_36.TabIndex = 33;
            this.cb_Syscall_36.Text = "[36] Map Game";
            this.cb_Syscall_36.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_35
            // 
            this.cb_Syscall_35.AutoSize = true;
            this.cb_Syscall_35.Location = new System.Drawing.Point(345, 133);
            this.cb_Syscall_35.Name = "cb_Syscall_35";
            this.cb_Syscall_35.Size = new System.Drawing.Size(100, 19);
            this.cb_Syscall_35.TabIndex = 32;
            this.cb_Syscall_35.Text = "[35] Map Path";
            this.cb_Syscall_35.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_11
            // 
            this.cb_Syscall_11.AutoSize = true;
            this.cb_Syscall_11.Location = new System.Drawing.Point(345, 108);
            this.cb_Syscall_11.Name = "cb_Syscall_11";
            this.cb_Syscall_11.Size = new System.Drawing.Size(96, 19);
            this.cb_Syscall_11.TabIndex = 31;
            this.cb_Syscall_11.Text = "[11] LV1 Peek";
            this.cb_Syscall_11.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_10
            // 
            this.cb_Syscall_10.AutoSize = true;
            this.cb_Syscall_10.Location = new System.Drawing.Point(345, 83);
            this.cb_Syscall_10.Name = "cb_Syscall_10";
            this.cb_Syscall_10.Size = new System.Drawing.Size(91, 19);
            this.cb_Syscall_10.TabIndex = 30;
            this.cb_Syscall_10.Text = "[10] LV1 Call";
            this.cb_Syscall_10.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_9
            // 
            this.cb_Syscall_9.AutoSize = true;
            this.cb_Syscall_9.Location = new System.Drawing.Point(239, 133);
            this.cb_Syscall_9.Name = "cb_Syscall_9";
            this.cb_Syscall_9.Size = new System.Drawing.Size(91, 19);
            this.cb_Syscall_9.TabIndex = 29;
            this.cb_Syscall_9.Text = "[9] LV1 Poke";
            this.cb_Syscall_9.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_7
            // 
            this.cb_Syscall_7.AutoSize = true;
            this.cb_Syscall_7.Location = new System.Drawing.Point(239, 108);
            this.cb_Syscall_7.Name = "cb_Syscall_7";
            this.cb_Syscall_7.Size = new System.Drawing.Size(91, 19);
            this.cb_Syscall_7.TabIndex = 28;
            this.cb_Syscall_7.Text = "[7] LV2 Poke";
            this.cb_Syscall_7.UseVisualStyleBackColor = true;
            // 
            // cb_Syscall_6
            // 
            this.cb_Syscall_6.AutoSize = true;
            this.cb_Syscall_6.Location = new System.Drawing.Point(239, 83);
            this.cb_Syscall_6.Name = "cb_Syscall_6";
            this.cb_Syscall_6.Size = new System.Drawing.Size(90, 19);
            this.cb_Syscall_6.TabIndex = 27;
            this.cb_Syscall_6.Text = "[6] LV2 Peek";
            this.cb_Syscall_6.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(226, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 113);
            this.panel4.TabIndex = 23;
            // 
            // cB_PS3_MIMICOFW
            // 
            this.cB_PS3_MIMICOFW.AutoSize = true;
            this.cB_PS3_MIMICOFW.Location = new System.Drawing.Point(2, 92);
            this.cB_PS3_MIMICOFW.Name = "cB_PS3_MIMICOFW";
            this.cB_PS3_MIMICOFW.Size = new System.Drawing.Size(219, 64);
            this.cB_PS3_MIMICOFW.TabIndex = 25;
            this.cB_PS3_MIMICOFW.Text = "Also remove \"unsafe\" empty\r\ndirectory (GAMES, GAMEZ, PS3ISO,\r\nPS2ISO, PSXISO, PSX" +
    "GAMES, PSPISO,\r\nISO, BDISO, DVDISO, PKG).";
            this.cB_PS3_MIMICOFW.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(5, 55);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 20);
            this.label24.TabIndex = 24;
            this.label24.Text = "User history:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "CFW Syscall:";
            // 
            // btn_PS3_DisableSyscall
            // 
            this.btn_PS3_DisableSyscall.Location = new System.Drawing.Point(366, 54);
            this.btn_PS3_DisableSyscall.Name = "btn_PS3_DisableSyscall";
            this.btn_PS3_DisableSyscall.Size = new System.Drawing.Size(60, 24);
            this.btn_PS3_DisableSyscall.TabIndex = 15;
            this.btn_PS3_DisableSyscall.Text = "Disable";
            this.btn_PS3_DisableSyscall.UseVisualStyleBackColor = true;
            this.btn_PS3_DisableSyscall.Click += new System.EventHandler(this.btn_PS3_CleanSyscall_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(4, 158);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "PS3 Leds:";
            // 
            // p_PS3_Led
            // 
            this.p_PS3_Led.BackColor = System.Drawing.SystemColors.Control;
            this.p_PS3_Led.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_PS3_Led.Controls.Add(this.cB_PS3_Led_Color);
            this.p_PS3_Led.Controls.Add(this.label17);
            this.p_PS3_Led.Controls.Add(this.label16);
            this.p_PS3_Led.Controls.Add(this.btn_PS3_Led_Set);
            this.p_PS3_Led.Controls.Add(this.cB_PS3_Led_Mode);
            this.p_PS3_Led.Location = new System.Drawing.Point(8, 181);
            this.p_PS3_Led.Name = "p_PS3_Led";
            this.p_PS3_Led.Size = new System.Drawing.Size(249, 72);
            this.p_PS3_Led.TabIndex = 11;
            // 
            // cB_PS3_Led_Color
            // 
            this.cB_PS3_Led_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_PS3_Led_Color.FormattingEnabled = true;
            this.cB_PS3_Led_Color.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Yellow"});
            this.cB_PS3_Led_Color.Location = new System.Drawing.Point(65, 9);
            this.cB_PS3_Led_Color.MaxDropDownItems = 16;
            this.cB_PS3_Led_Color.Name = "cB_PS3_Led_Color";
            this.cB_PS3_Led_Color.Size = new System.Drawing.Size(111, 23);
            this.cB_PS3_Led_Color.TabIndex = 12;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 11;
            this.label17.Text = "Mode:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 10;
            this.label16.Text = "Color:";
            // 
            // btn_PS3_Led_Set
            // 
            this.btn_PS3_Led_Set.Location = new System.Drawing.Point(182, 23);
            this.btn_PS3_Led_Set.Name = "btn_PS3_Led_Set";
            this.btn_PS3_Led_Set.Size = new System.Drawing.Size(60, 24);
            this.btn_PS3_Led_Set.TabIndex = 4;
            this.btn_PS3_Led_Set.Text = "Set";
            this.btn_PS3_Led_Set.UseVisualStyleBackColor = true;
            this.btn_PS3_Led_Set.Click += new System.EventHandler(this.btn_PS3_Led_Set_Click);
            // 
            // cB_PS3_Led_Mode
            // 
            this.cB_PS3_Led_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_PS3_Led_Mode.FormattingEnabled = true;
            this.cB_PS3_Led_Mode.Items.AddRange(new object[] {
            "Off",
            "On",
            "Blink Fast",
            "Blink Slow"});
            this.cB_PS3_Led_Mode.Location = new System.Drawing.Point(65, 38);
            this.cB_PS3_Led_Mode.MaxDropDownItems = 16;
            this.cB_PS3_Led_Mode.Name = "cB_PS3_Led_Mode";
            this.cB_PS3_Led_Mode.Size = new System.Drawing.Size(111, 23);
            this.cB_PS3_Led_Mode.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(4, 93);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "PS3 Buzzer:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(259, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "PS3 Temperatures:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(514, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "PS3 Power:";
            // 
            // p_PS3_Buzzer
            // 
            this.p_PS3_Buzzer.BackColor = System.Drawing.SystemColors.Control;
            this.p_PS3_Buzzer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_PS3_Buzzer.Controls.Add(this.label12);
            this.p_PS3_Buzzer.Controls.Add(this.btn_Ring_Buzzer);
            this.p_PS3_Buzzer.Controls.Add(this.cB_PS3_Buzzer);
            this.p_PS3_Buzzer.Location = new System.Drawing.Point(8, 116);
            this.p_PS3_Buzzer.Name = "p_PS3_Buzzer";
            this.p_PS3_Buzzer.Size = new System.Drawing.Size(249, 39);
            this.p_PS3_Buzzer.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 11;
            this.label12.Text = "Mode:";
            // 
            // btn_Ring_Buzzer
            // 
            this.btn_Ring_Buzzer.Location = new System.Drawing.Point(182, 4);
            this.btn_Ring_Buzzer.Name = "btn_Ring_Buzzer";
            this.btn_Ring_Buzzer.Size = new System.Drawing.Size(60, 26);
            this.btn_Ring_Buzzer.TabIndex = 11;
            this.btn_Ring_Buzzer.Text = "Ring";
            this.btn_Ring_Buzzer.UseVisualStyleBackColor = true;
            this.btn_Ring_Buzzer.Click += new System.EventHandler(this.btn_Ring_Buzzer_Click);
            // 
            // cB_PS3_Buzzer
            // 
            this.cB_PS3_Buzzer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_PS3_Buzzer.FormattingEnabled = true;
            this.cB_PS3_Buzzer.Items.AddRange(new object[] {
            "Simple",
            "Double",
            "Triple"});
            this.cB_PS3_Buzzer.Location = new System.Drawing.Point(60, 7);
            this.cB_PS3_Buzzer.MaxDropDownItems = 16;
            this.cB_PS3_Buzzer.Name = "cB_PS3_Buzzer";
            this.cB_PS3_Buzzer.Size = new System.Drawing.Size(116, 23);
            this.cB_PS3_Buzzer.TabIndex = 12;
            // 
            // p_PS3_Power
            // 
            this.p_PS3_Power.BackColor = System.Drawing.SystemColors.Control;
            this.p_PS3_Power.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_PS3_Power.Controls.Add(this.btn_Power_Execute);
            this.p_PS3_Power.Controls.Add(this.cB_PS3_Power);
            this.p_PS3_Power.Location = new System.Drawing.Point(518, 26);
            this.p_PS3_Power.Name = "p_PS3_Power";
            this.p_PS3_Power.Size = new System.Drawing.Size(249, 64);
            this.p_PS3_Power.TabIndex = 6;
            // 
            // btn_Power_Execute
            // 
            this.btn_Power_Execute.Location = new System.Drawing.Point(84, 33);
            this.btn_Power_Execute.Name = "btn_Power_Execute";
            this.btn_Power_Execute.Size = new System.Drawing.Size(87, 26);
            this.btn_Power_Execute.TabIndex = 4;
            this.btn_Power_Execute.Text = "Execute";
            this.btn_Power_Execute.UseVisualStyleBackColor = true;
            this.btn_Power_Execute.Click += new System.EventHandler(this.btn_Power_Execute_Click);
            // 
            // cB_PS3_Power
            // 
            this.cB_PS3_Power.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB_PS3_Power.FormattingEnabled = true;
            this.cB_PS3_Power.Items.AddRange(new object[] {
            "Shutdown",
            "Quick Reboot",
            "Soft Reboot",
            "Hard Reboot"});
            this.cB_PS3_Power.Location = new System.Drawing.Point(37, 5);
            this.cB_PS3_Power.MaxDropDownItems = 16;
            this.cB_PS3_Power.Name = "cB_PS3_Power";
            this.cB_PS3_Power.Size = new System.Drawing.Size(173, 23);
            this.cB_PS3_Power.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "PS3 Details:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_Temp_Refresh);
            this.panel2.Controls.Add(this.lbl_Temp_CPU);
            this.panel2.Controls.Add(this.lbl_Temp_RSX);
            this.panel2.Location = new System.Drawing.Point(263, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 64);
            this.panel2.TabIndex = 4;
            // 
            // btn_Temp_Refresh
            // 
            this.btn_Temp_Refresh.Location = new System.Drawing.Point(168, 16);
            this.btn_Temp_Refresh.Name = "btn_Temp_Refresh";
            this.btn_Temp_Refresh.Size = new System.Drawing.Size(76, 27);
            this.btn_Temp_Refresh.TabIndex = 3;
            this.btn_Temp_Refresh.Text = "Refresh";
            this.btn_Temp_Refresh.UseVisualStyleBackColor = true;
            this.btn_Temp_Refresh.Click += new System.EventHandler(this.btn_Temp_Refresh_Click);
            // 
            // lbl_Temp_CPU
            // 
            this.lbl_Temp_CPU.AutoSize = true;
            this.lbl_Temp_CPU.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp_CPU.Location = new System.Drawing.Point(3, 5);
            this.lbl_Temp_CPU.Name = "lbl_Temp_CPU";
            this.lbl_Temp_CPU.Size = new System.Drawing.Size(39, 20);
            this.lbl_Temp_CPU.TabIndex = 1;
            this.lbl_Temp_CPU.Text = "CPU:";
            // 
            // lbl_Temp_RSX
            // 
            this.lbl_Temp_RSX.AutoSize = true;
            this.lbl_Temp_RSX.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Temp_RSX.Location = new System.Drawing.Point(3, 33);
            this.lbl_Temp_RSX.Name = "lbl_Temp_RSX";
            this.lbl_Temp_RSX.Size = new System.Drawing.Size(38, 20);
            this.lbl_Temp_RSX.TabIndex = 2;
            this.lbl_Temp_RSX.Text = "RSX:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_core_version);
            this.panel1.Controls.Add(this.lbl_fw);
            this.panel1.Location = new System.Drawing.Point(8, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 64);
            this.panel1.TabIndex = 0;
            // 
            // lbl_core_version
            // 
            this.lbl_core_version.AutoSize = true;
            this.lbl_core_version.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_core_version.Location = new System.Drawing.Point(3, 33);
            this.lbl_core_version.Name = "lbl_core_version";
            this.lbl_core_version.Size = new System.Drawing.Size(77, 20);
            this.lbl_core_version.TabIndex = 4;
            this.lbl_core_version.Text = "PS3M_API:";
            // 
            // lbl_fw
            // 
            this.lbl_fw.AutoSize = true;
            this.lbl_fw.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fw.Location = new System.Drawing.Point(3, 5);
            this.lbl_fw.Name = "lbl_fw";
            this.lbl_fw.Size = new System.Drawing.Size(73, 20);
            this.lbl_fw.TabIndex = 0;
            this.lbl_fw.Text = "Firmware:";
            // 
            // tabP_Processes
            // 
            this.tabP_Processes.BackColor = System.Drawing.Color.White;
            this.tabP_Processes.Controls.Add(this.p_Process);
            this.tabP_Processes.Controls.Add(this.label30);
            this.tabP_Processes.Controls.Add(this.p_SetMem);
            this.tabP_Processes.Controls.Add(this.label18);
            this.tabP_Processes.Controls.Add(this.lblProcs);
            this.tabP_Processes.Controls.Add(this.p_GetMem);
            this.tabP_Processes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabP_Processes.Location = new System.Drawing.Point(4, 26);
            this.tabP_Processes.Name = "tabP_Processes";
            this.tabP_Processes.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Processes.Size = new System.Drawing.Size(776, 475);
            this.tabP_Processes.TabIndex = 1;
            this.tabP_Processes.Text = "Memory Commands";
            // 
            // p_Process
            // 
            this.p_Process.BackColor = System.Drawing.SystemColors.Control;
            this.p_Process.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Process.Controls.Add(this.btnAttach);
            this.p_Process.Controls.Add(this.btnUnattach);
            this.p_Process.Controls.Add(this.btnRefresh);
            this.p_Process.Controls.Add(this.comboB_Procs);
            this.p_Process.Location = new System.Drawing.Point(80, 7);
            this.p_Process.Name = "p_Process";
            this.p_Process.Size = new System.Drawing.Size(686, 33);
            this.p_Process.TabIndex = 28;
            // 
            // btnUnattach
            // 
            this.btnUnattach.Enabled = false;
            this.btnUnattach.Location = new System.Drawing.Point(553, 4);
            this.btnUnattach.Name = "btnUnattach";
            this.btnUnattach.Size = new System.Drawing.Size(87, 23);
            this.btnUnattach.TabIndex = 5;
            this.btnUnattach.Text = "Unattach";
            this.btnUnattach.UseVisualStyleBackColor = true;
            this.btnUnattach.Click += new System.EventHandler(this.btnUnattach_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(8, 261);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(156, 20);
            this.label30.TabIndex = 27;
            this.label30.Text = "Set Process Memory:";
            // 
            // p_SetMem
            // 
            this.p_SetMem.BackColor = System.Drawing.SystemColors.Control;
            this.p_SetMem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_SetMem.Controls.Add(this.txtB_SetOffset);
            this.p_SetMem.Controls.Add(this.label28);
            this.p_SetMem.Controls.Add(this.label29);
            this.p_SetMem.Controls.Add(this.textInput);
            this.p_SetMem.Controls.Add(this.btnSetMem);
            this.p_SetMem.Location = new System.Drawing.Point(7, 284);
            this.p_SetMem.Name = "p_SetMem";
            this.p_SetMem.Size = new System.Drawing.Size(760, 183);
            this.p_SetMem.TabIndex = 26;
            // 
            // txtB_SetOffset
            // 
            this.txtB_SetOffset.BackColor = System.Drawing.SystemColors.Control;
            this.txtB_SetOffset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_SetOffset.Location = new System.Drawing.Point(62, 11);
            this.txtB_SetOffset.MaxLength = 128;
            this.txtB_SetOffset.Name = "txtB_SetOffset";
            this.txtB_SetOffset.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtB_SetOffset.Size = new System.Drawing.Size(133, 23);
            this.txtB_SetOffset.TabIndex = 47;
            this.txtB_SetOffset.Text = "1";
            this.txtB_SetOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtB_SetOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_HexOnly);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(4, 39);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 20);
            this.label28.TabIndex = 45;
            this.label28.Text = "Input:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(4, 10);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(52, 20);
            this.label29.TabIndex = 44;
            this.label29.Text = "Offset:";
            // 
            // textInput
            // 
            this.textInput.BackColor = System.Drawing.SystemColors.Control;
            this.textInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textInput.Location = new System.Drawing.Point(0, 62);
            this.textInput.MaxLength = 2147483647;
            this.textInput.Multiline = true;
            this.textInput.Name = "textInput";
            this.textInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textInput.Size = new System.Drawing.Size(758, 119);
            this.textInput.TabIndex = 25;
            this.textInput.Text = "000102030405060708090A0B0C0D0E0F";
            this.textInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_HexOnly);
            // 
            // btnSetMem
            // 
            this.btnSetMem.Location = new System.Drawing.Point(640, 10);
            this.btnSetMem.Name = "btnSetMem";
            this.btnSetMem.Size = new System.Drawing.Size(87, 23);
            this.btnSetMem.TabIndex = 26;
            this.btnSetMem.Text = "Set";
            this.btnSetMem.UseVisualStyleBackColor = true;
            this.btnSetMem.Click += new System.EventHandler(this.btnSetMem_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 47);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(159, 20);
            this.label18.TabIndex = 7;
            this.label18.Text = "Get Process Memory:";
            // 
            // p_GetMem
            // 
            this.p_GetMem.BackColor = System.Drawing.SystemColors.Control;
            this.p_GetMem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_GetMem.Controls.Add(this.txtB_GetOffset);
            this.p_GetMem.Controls.Add(this.nUD_GetLength);
            this.p_GetMem.Controls.Add(this.label27);
            this.p_GetMem.Controls.Add(this.button1);
            this.p_GetMem.Controls.Add(this.label25);
            this.p_GetMem.Controls.Add(this.textOutput);
            this.p_GetMem.Controls.Add(this.label26);
            this.p_GetMem.Location = new System.Drawing.Point(7, 70);
            this.p_GetMem.Name = "p_GetMem";
            this.p_GetMem.Size = new System.Drawing.Size(760, 183);
            this.p_GetMem.TabIndex = 6;
            // 
            // txtB_GetOffset
            // 
            this.txtB_GetOffset.BackColor = System.Drawing.SystemColors.Control;
            this.txtB_GetOffset.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB_GetOffset.Location = new System.Drawing.Point(62, 10);
            this.txtB_GetOffset.MaxLength = 128;
            this.txtB_GetOffset.Name = "txtB_GetOffset";
            this.txtB_GetOffset.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtB_GetOffset.Size = new System.Drawing.Size(133, 23);
            this.txtB_GetOffset.TabIndex = 45;
            this.txtB_GetOffset.Text = "1";
            this.txtB_GetOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtB_GetOffset.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_HexOnly);
            // 
            // nUD_GetLength
            // 
            this.nUD_GetLength.BackColor = System.Drawing.SystemColors.Control;
            this.nUD_GetLength.Location = new System.Drawing.Point(327, 10);
            this.nUD_GetLength.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nUD_GetLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_GetLength.Name = "nUD_GetLength";
            this.nUD_GetLength.Size = new System.Drawing.Size(224, 23);
            this.nUD_GetLength.TabIndex = 22;
            this.nUD_GetLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUD_GetLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(264, 10);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 20);
            this.label27.TabIndex = 44;
            this.label27.Text = "Length:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(4, 39);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 20);
            this.label25.TabIndex = 4;
            this.label25.Text = "Output:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(4, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 20);
            this.label26.TabIndex = 0;
            this.label26.Text = "Offset:";
            // 
            // tabP_Plugins
            // 
            this.tabP_Plugins.Controls.Add(this.VSHPlug_Refresh);
            this.tabP_Plugins.Controls.Add(this.OthersPlug_Refresh);
            this.tabP_Plugins.Controls.Add(this.label47);
            this.tabP_Plugins.Controls.Add(this.panel9);
            this.tabP_Plugins.Controls.Add(this.btn_PluginsAdv);
            this.tabP_Plugins.Controls.Add(this.panel8);
            this.tabP_Plugins.Controls.Add(this.label3);
            this.tabP_Plugins.Location = new System.Drawing.Point(4, 26);
            this.tabP_Plugins.Name = "tabP_Plugins";
            this.tabP_Plugins.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_Plugins.Size = new System.Drawing.Size(776, 475);
            this.tabP_Plugins.TabIndex = 2;
            this.tabP_Plugins.Text = "Plugins Commands";
            this.tabP_Plugins.UseVisualStyleBackColor = true;
            // 
            // VSHPlug_Refresh
            // 
            this.VSHPlug_Refresh.Enabled = false;
            this.VSHPlug_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Refresh.Location = new System.Drawing.Point(112, 9);
            this.VSHPlug_Refresh.Name = "VSHPlug_Refresh";
            this.VSHPlug_Refresh.Size = new System.Drawing.Size(87, 25);
            this.VSHPlug_Refresh.TabIndex = 58;
            this.VSHPlug_Refresh.Text = "Refresh";
            this.VSHPlug_Refresh.UseVisualStyleBackColor = true;
            this.VSHPlug_Refresh.Click += new System.EventHandler(this.VSHPlug_Refresh_Click);
            // 
            // OthersPlug_Refresh
            // 
            this.OthersPlug_Refresh.Enabled = false;
            this.OthersPlug_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersPlug_Refresh.Location = new System.Drawing.Point(129, 307);
            this.OthersPlug_Refresh.Name = "OthersPlug_Refresh";
            this.OthersPlug_Refresh.Size = new System.Drawing.Size(87, 25);
            this.OthersPlug_Refresh.TabIndex = 57;
            this.OthersPlug_Refresh.Text = "Refresh";
            this.OthersPlug_Refresh.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(9, 309);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(115, 20);
            this.label47.TabIndex = 56;
            this.label47.Text = "Others Plugins:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Control;
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.tableLayoutPanel2);
            this.panel9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel9.Location = new System.Drawing.Point(13, 335);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(755, 132);
            this.panel9.TabIndex = 55;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 346F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel2.Controls.Add(this.label49, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.OthersPlug_Process_2, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.OthersPlug_Process_1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.OthersPlug_Process_0, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label48, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label53, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label56, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label57, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label58, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btn_OthersPlug_0, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.btn_OthersPlug_1, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_OthersPlug_2, 4, 3);
            this.tableLayoutPanel2.Controls.Add(this.OthersPlug_Path_0, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.OthersPlug_Path_1, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.OthersPlug_Path_2, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.label55, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label54, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.OthersPlug_Name_0, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.OthersPlug_Name_1, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.OthersPlug_Name_2, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(753, 130);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.Red;
            this.label49.Location = new System.Drawing.Point(659, 2);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(95, 30);
            this.label49.TabIndex = 57;
            this.label49.Text = "Soon v1.3?";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OthersPlug_Process_2
            // 
            this.OthersPlug_Process_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersPlug_Process_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OthersPlug_Process_2.Enabled = false;
            this.OthersPlug_Process_2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersPlug_Process_2.FormattingEnabled = true;
            this.OthersPlug_Process_2.Location = new System.Drawing.Point(57, 101);
            this.OthersPlug_Process_2.MaxDropDownItems = 16;
            this.OthersPlug_Process_2.Name = "OthersPlug_Process_2";
            this.OthersPlug_Process_2.Size = new System.Drawing.Size(119, 25);
            this.OthersPlug_Process_2.TabIndex = 58;
            // 
            // OthersPlug_Process_1
            // 
            this.OthersPlug_Process_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersPlug_Process_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OthersPlug_Process_1.Enabled = false;
            this.OthersPlug_Process_1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersPlug_Process_1.FormattingEnabled = true;
            this.OthersPlug_Process_1.Location = new System.Drawing.Point(57, 69);
            this.OthersPlug_Process_1.MaxDropDownItems = 16;
            this.OthersPlug_Process_1.Name = "OthersPlug_Process_1";
            this.OthersPlug_Process_1.Size = new System.Drawing.Size(119, 25);
            this.OthersPlug_Process_1.TabIndex = 58;
            // 
            // OthersPlug_Process_0
            // 
            this.OthersPlug_Process_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersPlug_Process_0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OthersPlug_Process_0.Enabled = false;
            this.OthersPlug_Process_0.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersPlug_Process_0.FormattingEnabled = true;
            this.OthersPlug_Process_0.Location = new System.Drawing.Point(57, 37);
            this.OthersPlug_Process_0.MaxDropDownItems = 16;
            this.OthersPlug_Process_0.Name = "OthersPlug_Process_0";
            this.OthersPlug_Process_0.Size = new System.Drawing.Size(119, 25);
            this.OthersPlug_Process_0.TabIndex = 57;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label48.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(57, 2);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(119, 30);
            this.label48.TabIndex = 57;
            this.label48.Text = "Process";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(5, 2);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(44, 30);
            this.label53.TabIndex = 0;
            this.label53.Text = "Slot";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.Location = new System.Drawing.Point(5, 34);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(44, 30);
            this.label56.TabIndex = 44;
            this.label56.Text = "0";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(5, 66);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(44, 30);
            this.label57.TabIndex = 45;
            this.label57.Text = "1";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(5, 98);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(44, 30);
            this.label58.TabIndex = 46;
            this.label58.Text = "2";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_OthersPlug_0
            // 
            this.btn_OthersPlug_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OthersPlug_0.Enabled = false;
            this.btn_OthersPlug_0.Location = new System.Drawing.Point(659, 37);
            this.btn_OthersPlug_0.Name = "btn_OthersPlug_0";
            this.btn_OthersPlug_0.Size = new System.Drawing.Size(95, 24);
            this.btn_OthersPlug_0.TabIndex = 15;
            this.btn_OthersPlug_0.Text = "Load";
            this.btn_OthersPlug_0.UseVisualStyleBackColor = true;
            // 
            // btn_OthersPlug_1
            // 
            this.btn_OthersPlug_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OthersPlug_1.Enabled = false;
            this.btn_OthersPlug_1.Location = new System.Drawing.Point(659, 69);
            this.btn_OthersPlug_1.Name = "btn_OthersPlug_1";
            this.btn_OthersPlug_1.Size = new System.Drawing.Size(95, 24);
            this.btn_OthersPlug_1.TabIndex = 64;
            this.btn_OthersPlug_1.Text = "Load";
            this.btn_OthersPlug_1.UseVisualStyleBackColor = true;
            // 
            // btn_OthersPlug_2
            // 
            this.btn_OthersPlug_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OthersPlug_2.Enabled = false;
            this.btn_OthersPlug_2.Location = new System.Drawing.Point(659, 101);
            this.btn_OthersPlug_2.Name = "btn_OthersPlug_2";
            this.btn_OthersPlug_2.Size = new System.Drawing.Size(95, 24);
            this.btn_OthersPlug_2.TabIndex = 65;
            this.btn_OthersPlug_2.Text = "Load";
            this.btn_OthersPlug_2.UseVisualStyleBackColor = true;
            // 
            // OthersPlug_Path_0
            // 
            this.OthersPlug_Path_0.BackColor = System.Drawing.SystemColors.Control;
            this.OthersPlug_Path_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersPlug_Path_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersPlug_Path_0.Location = new System.Drawing.Point(311, 37);
            this.OthersPlug_Path_0.MaxLength = 128;
            this.OthersPlug_Path_0.Name = "OthersPlug_Path_0";
            this.OthersPlug_Path_0.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OthersPlug_Path_0.Size = new System.Drawing.Size(340, 23);
            this.OthersPlug_Path_0.TabIndex = 43;
            this.OthersPlug_Path_0.Text = "/dev_hdd0/tmp/others_plugin_0.sprx";
            // 
            // OthersPlug_Path_1
            // 
            this.OthersPlug_Path_1.BackColor = System.Drawing.SystemColors.Control;
            this.OthersPlug_Path_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersPlug_Path_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersPlug_Path_1.Location = new System.Drawing.Point(311, 69);
            this.OthersPlug_Path_1.MaxLength = 128;
            this.OthersPlug_Path_1.Name = "OthersPlug_Path_1";
            this.OthersPlug_Path_1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OthersPlug_Path_1.Size = new System.Drawing.Size(340, 23);
            this.OthersPlug_Path_1.TabIndex = 58;
            this.OthersPlug_Path_1.Text = "/dev_hdd0/tmp/others_plugin_1.sprx";
            // 
            // OthersPlug_Path_2
            // 
            this.OthersPlug_Path_2.BackColor = System.Drawing.SystemColors.Control;
            this.OthersPlug_Path_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersPlug_Path_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersPlug_Path_2.Location = new System.Drawing.Point(311, 101);
            this.OthersPlug_Path_2.MaxLength = 128;
            this.OthersPlug_Path_2.Name = "OthersPlug_Path_2";
            this.OthersPlug_Path_2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OthersPlug_Path_2.Size = new System.Drawing.Size(340, 23);
            this.OthersPlug_Path_2.TabIndex = 57;
            this.OthersPlug_Path_2.Text = "/dev_hdd0/tmp/others_plugin_2.sprx";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label55.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(311, 2);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(340, 30);
            this.label55.TabIndex = 16;
            this.label55.Text = "Path";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(184, 2);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(119, 30);
            this.label54.TabIndex = 17;
            this.label54.Text = "Name";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OthersPlug_Name_0
            // 
            this.OthersPlug_Name_0.AutoSize = true;
            this.OthersPlug_Name_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersPlug_Name_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersPlug_Name_0.Location = new System.Drawing.Point(184, 34);
            this.OthersPlug_Name_0.Name = "OthersPlug_Name_0";
            this.OthersPlug_Name_0.Size = new System.Drawing.Size(119, 30);
            this.OthersPlug_Name_0.TabIndex = 49;
            this.OthersPlug_Name_0.Text = "NONE";
            this.OthersPlug_Name_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OthersPlug_Name_1
            // 
            this.OthersPlug_Name_1.AutoSize = true;
            this.OthersPlug_Name_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersPlug_Name_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersPlug_Name_1.Location = new System.Drawing.Point(184, 66);
            this.OthersPlug_Name_1.Name = "OthersPlug_Name_1";
            this.OthersPlug_Name_1.Size = new System.Drawing.Size(119, 30);
            this.OthersPlug_Name_1.TabIndex = 50;
            this.OthersPlug_Name_1.Text = "NONE";
            this.OthersPlug_Name_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OthersPlug_Name_2
            // 
            this.OthersPlug_Name_2.AutoSize = true;
            this.OthersPlug_Name_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OthersPlug_Name_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OthersPlug_Name_2.Location = new System.Drawing.Point(184, 98);
            this.OthersPlug_Name_2.Name = "OthersPlug_Name_2";
            this.OthersPlug_Name_2.Size = new System.Drawing.Size(119, 30);
            this.OthersPlug_Name_2.TabIndex = 55;
            this.OthersPlug_Name_2.Text = "NONE";
            this.OthersPlug_Name_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_PluginsAdv
            // 
            this.btn_PluginsAdv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PluginsAdv.Location = new System.Drawing.Point(642, 9);
            this.btn_PluginsAdv.Name = "btn_PluginsAdv";
            this.btn_PluginsAdv.Size = new System.Drawing.Size(124, 25);
            this.btn_PluginsAdv.TabIndex = 54;
            this.btn_PluginsAdv.Text = "[Advanced Mode]";
            this.btn_PluginsAdv.UseVisualStyleBackColor = true;
            this.btn_PluginsAdv.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Control;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.tableLayoutPanel1);
            this.panel8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel8.Location = new System.Drawing.Point(12, 37);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(755, 262);
            this.panel8.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 476F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Path_6, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Path_5, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Path_4, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Path_3, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Path_2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Path_1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Name_6, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Name_5, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label44, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Name_4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Name_3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Name_2, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label32, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label31, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Path_0, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_VSHPlug_0, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label33, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label34, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label35, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label36, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label37, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Name_0, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.VSHPlug_Name_1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label43, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_VSHPlug_6, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.btn_VSHPlug_5, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn_VSHPlug_4, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btn_VSHPlug_3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_VSHPlug_2, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_VSHPlug_1, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(753, 260);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // VSHPlug_Path_6
            // 
            this.VSHPlug_Path_6.BackColor = System.Drawing.SystemColors.Control;
            this.VSHPlug_Path_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Path_6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Path_6.Location = new System.Drawing.Point(184, 229);
            this.VSHPlug_Path_6.MaxLength = 128;
            this.VSHPlug_Path_6.Name = "VSHPlug_Path_6";
            this.VSHPlug_Path_6.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VSHPlug_Path_6.Size = new System.Drawing.Size(470, 23);
            this.VSHPlug_Path_6.TabIndex = 57;
            this.VSHPlug_Path_6.Text = "/dev_hdd0/tmp/vsh_plugin_6.sprx";
            // 
            // VSHPlug_Path_5
            // 
            this.VSHPlug_Path_5.BackColor = System.Drawing.SystemColors.Control;
            this.VSHPlug_Path_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Path_5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Path_5.Location = new System.Drawing.Point(184, 197);
            this.VSHPlug_Path_5.MaxLength = 128;
            this.VSHPlug_Path_5.Name = "VSHPlug_Path_5";
            this.VSHPlug_Path_5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VSHPlug_Path_5.Size = new System.Drawing.Size(470, 23);
            this.VSHPlug_Path_5.TabIndex = 57;
            this.VSHPlug_Path_5.Text = "/dev_hdd0/tmp/vsh_plugin_5.sprx";
            // 
            // VSHPlug_Path_4
            // 
            this.VSHPlug_Path_4.BackColor = System.Drawing.SystemColors.Control;
            this.VSHPlug_Path_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Path_4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Path_4.Location = new System.Drawing.Point(184, 165);
            this.VSHPlug_Path_4.MaxLength = 128;
            this.VSHPlug_Path_4.Name = "VSHPlug_Path_4";
            this.VSHPlug_Path_4.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VSHPlug_Path_4.Size = new System.Drawing.Size(470, 23);
            this.VSHPlug_Path_4.TabIndex = 57;
            this.VSHPlug_Path_4.Text = "/dev_hdd0/tmp/vsh_plugin_4.sprx";
            // 
            // VSHPlug_Path_3
            // 
            this.VSHPlug_Path_3.BackColor = System.Drawing.SystemColors.Control;
            this.VSHPlug_Path_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Path_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Path_3.Location = new System.Drawing.Point(184, 133);
            this.VSHPlug_Path_3.MaxLength = 128;
            this.VSHPlug_Path_3.Name = "VSHPlug_Path_3";
            this.VSHPlug_Path_3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VSHPlug_Path_3.Size = new System.Drawing.Size(470, 23);
            this.VSHPlug_Path_3.TabIndex = 57;
            this.VSHPlug_Path_3.Text = "/dev_hdd0/tmp/vsh_plugin_3.sprx";
            // 
            // VSHPlug_Path_2
            // 
            this.VSHPlug_Path_2.BackColor = System.Drawing.SystemColors.Control;
            this.VSHPlug_Path_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Path_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Path_2.Location = new System.Drawing.Point(184, 101);
            this.VSHPlug_Path_2.MaxLength = 128;
            this.VSHPlug_Path_2.Name = "VSHPlug_Path_2";
            this.VSHPlug_Path_2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VSHPlug_Path_2.Size = new System.Drawing.Size(470, 23);
            this.VSHPlug_Path_2.TabIndex = 57;
            this.VSHPlug_Path_2.Text = "/dev_hdd0/tmp/vsh_plugin_2.sprx";
            // 
            // VSHPlug_Path_1
            // 
            this.VSHPlug_Path_1.BackColor = System.Drawing.SystemColors.Control;
            this.VSHPlug_Path_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Path_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Path_1.Location = new System.Drawing.Point(184, 69);
            this.VSHPlug_Path_1.MaxLength = 128;
            this.VSHPlug_Path_1.Name = "VSHPlug_Path_1";
            this.VSHPlug_Path_1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VSHPlug_Path_1.Size = new System.Drawing.Size(470, 23);
            this.VSHPlug_Path_1.TabIndex = 56;
            this.VSHPlug_Path_1.Text = "/dev_hdd0/tmp/vsh_plugin_1.sprx";
            // 
            // VSHPlug_Name_6
            // 
            this.VSHPlug_Name_6.AutoSize = true;
            this.VSHPlug_Name_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Name_6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Name_6.Location = new System.Drawing.Point(57, 226);
            this.VSHPlug_Name_6.Name = "VSHPlug_Name_6";
            this.VSHPlug_Name_6.Size = new System.Drawing.Size(119, 32);
            this.VSHPlug_Name_6.TabIndex = 56;
            this.VSHPlug_Name_6.Text = "NONE";
            this.VSHPlug_Name_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VSHPlug_Name_5
            // 
            this.VSHPlug_Name_5.AutoSize = true;
            this.VSHPlug_Name_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Name_5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Name_5.Location = new System.Drawing.Point(57, 194);
            this.VSHPlug_Name_5.Name = "VSHPlug_Name_5";
            this.VSHPlug_Name_5.Size = new System.Drawing.Size(119, 30);
            this.VSHPlug_Name_5.TabIndex = 56;
            this.VSHPlug_Name_5.Text = "NONE";
            this.VSHPlug_Name_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(5, 226);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(44, 32);
            this.label44.TabIndex = 55;
            this.label44.Text = "6";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VSHPlug_Name_4
            // 
            this.VSHPlug_Name_4.AutoSize = true;
            this.VSHPlug_Name_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Name_4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Name_4.Location = new System.Drawing.Point(57, 162);
            this.VSHPlug_Name_4.Name = "VSHPlug_Name_4";
            this.VSHPlug_Name_4.Size = new System.Drawing.Size(119, 30);
            this.VSHPlug_Name_4.TabIndex = 55;
            this.VSHPlug_Name_4.Text = "NONE";
            this.VSHPlug_Name_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VSHPlug_Name_3
            // 
            this.VSHPlug_Name_3.AutoSize = true;
            this.VSHPlug_Name_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Name_3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Name_3.Location = new System.Drawing.Point(57, 130);
            this.VSHPlug_Name_3.Name = "VSHPlug_Name_3";
            this.VSHPlug_Name_3.Size = new System.Drawing.Size(119, 30);
            this.VSHPlug_Name_3.TabIndex = 55;
            this.VSHPlug_Name_3.Text = "NONE";
            this.VSHPlug_Name_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VSHPlug_Name_2
            // 
            this.VSHPlug_Name_2.AutoSize = true;
            this.VSHPlug_Name_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Name_2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Name_2.Location = new System.Drawing.Point(57, 98);
            this.VSHPlug_Name_2.Name = "VSHPlug_Name_2";
            this.VSHPlug_Name_2.Size = new System.Drawing.Size(119, 30);
            this.VSHPlug_Name_2.TabIndex = 55;
            this.VSHPlug_Name_2.Text = "NONE";
            this.VSHPlug_Name_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(5, 2);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(44, 30);
            this.label32.TabIndex = 0;
            this.label32.Text = "Slot";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(57, 2);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(119, 30);
            this.label31.TabIndex = 17;
            this.label31.Text = "Name";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(184, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 30);
            this.label4.TabIndex = 16;
            this.label4.Text = "Path";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VSHPlug_Path_0
            // 
            this.VSHPlug_Path_0.BackColor = System.Drawing.SystemColors.Control;
            this.VSHPlug_Path_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Path_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Path_0.Location = new System.Drawing.Point(184, 37);
            this.VSHPlug_Path_0.MaxLength = 128;
            this.VSHPlug_Path_0.Name = "VSHPlug_Path_0";
            this.VSHPlug_Path_0.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.VSHPlug_Path_0.Size = new System.Drawing.Size(470, 23);
            this.VSHPlug_Path_0.TabIndex = 43;
            this.VSHPlug_Path_0.Text = "/dev_hdd0/tmp/vsh_plugin_0.sprx";
            // 
            // btn_VSHPlug_0
            // 
            this.btn_VSHPlug_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VSHPlug_0.Enabled = false;
            this.btn_VSHPlug_0.Location = new System.Drawing.Point(662, 37);
            this.btn_VSHPlug_0.Name = "btn_VSHPlug_0";
            this.btn_VSHPlug_0.Size = new System.Drawing.Size(92, 24);
            this.btn_VSHPlug_0.TabIndex = 15;
            this.btn_VSHPlug_0.Text = "Reserved";
            this.btn_VSHPlug_0.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(5, 34);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(44, 30);
            this.label33.TabIndex = 44;
            this.label33.Text = "0";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(5, 66);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(44, 30);
            this.label34.TabIndex = 45;
            this.label34.Text = "1";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(5, 98);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 30);
            this.label35.TabIndex = 46;
            this.label35.Text = "2";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(5, 130);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(44, 30);
            this.label36.TabIndex = 47;
            this.label36.Text = "3";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(5, 162);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(44, 30);
            this.label37.TabIndex = 48;
            this.label37.Text = "4";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VSHPlug_Name_0
            // 
            this.VSHPlug_Name_0.AutoSize = true;
            this.VSHPlug_Name_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Name_0.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Name_0.Location = new System.Drawing.Point(57, 34);
            this.VSHPlug_Name_0.Name = "VSHPlug_Name_0";
            this.VSHPlug_Name_0.Size = new System.Drawing.Size(119, 30);
            this.VSHPlug_Name_0.TabIndex = 49;
            this.VSHPlug_Name_0.Text = "NONE";
            this.VSHPlug_Name_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VSHPlug_Name_1
            // 
            this.VSHPlug_Name_1.AutoSize = true;
            this.VSHPlug_Name_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSHPlug_Name_1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VSHPlug_Name_1.Location = new System.Drawing.Point(57, 66);
            this.VSHPlug_Name_1.Name = "VSHPlug_Name_1";
            this.VSHPlug_Name_1.Size = new System.Drawing.Size(119, 30);
            this.VSHPlug_Name_1.TabIndex = 50;
            this.VSHPlug_Name_1.Text = "NONE";
            this.VSHPlug_Name_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(5, 194);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(44, 30);
            this.label43.TabIndex = 56;
            this.label43.Text = "5";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_VSHPlug_6
            // 
            this.btn_VSHPlug_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VSHPlug_6.Location = new System.Drawing.Point(662, 229);
            this.btn_VSHPlug_6.Name = "btn_VSHPlug_6";
            this.btn_VSHPlug_6.Size = new System.Drawing.Size(92, 26);
            this.btn_VSHPlug_6.TabIndex = 58;
            this.btn_VSHPlug_6.Text = "Load";
            this.btn_VSHPlug_6.UseVisualStyleBackColor = true;
            this.btn_VSHPlug_6.Click += new System.EventHandler(this.btn_VSHPlug_6_Click);
            // 
            // btn_VSHPlug_5
            // 
            this.btn_VSHPlug_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VSHPlug_5.Location = new System.Drawing.Point(662, 197);
            this.btn_VSHPlug_5.Name = "btn_VSHPlug_5";
            this.btn_VSHPlug_5.Size = new System.Drawing.Size(92, 24);
            this.btn_VSHPlug_5.TabIndex = 59;
            this.btn_VSHPlug_5.Text = "Load";
            this.btn_VSHPlug_5.UseVisualStyleBackColor = true;
            this.btn_VSHPlug_5.Click += new System.EventHandler(this.btn_VSHPlug_5_Click);
            // 
            // btn_VSHPlug_4
            // 
            this.btn_VSHPlug_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VSHPlug_4.Location = new System.Drawing.Point(662, 165);
            this.btn_VSHPlug_4.Name = "btn_VSHPlug_4";
            this.btn_VSHPlug_4.Size = new System.Drawing.Size(92, 24);
            this.btn_VSHPlug_4.TabIndex = 60;
            this.btn_VSHPlug_4.Text = "Load";
            this.btn_VSHPlug_4.UseVisualStyleBackColor = true;
            this.btn_VSHPlug_4.Click += new System.EventHandler(this.btn_VSHPlug_4_Click);
            // 
            // btn_VSHPlug_3
            // 
            this.btn_VSHPlug_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VSHPlug_3.Location = new System.Drawing.Point(662, 133);
            this.btn_VSHPlug_3.Name = "btn_VSHPlug_3";
            this.btn_VSHPlug_3.Size = new System.Drawing.Size(92, 24);
            this.btn_VSHPlug_3.TabIndex = 61;
            this.btn_VSHPlug_3.Text = "Load";
            this.btn_VSHPlug_3.UseVisualStyleBackColor = true;
            this.btn_VSHPlug_3.Click += new System.EventHandler(this.btn_VSHPlug_3_Click);
            // 
            // btn_VSHPlug_2
            // 
            this.btn_VSHPlug_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VSHPlug_2.Location = new System.Drawing.Point(662, 101);
            this.btn_VSHPlug_2.Name = "btn_VSHPlug_2";
            this.btn_VSHPlug_2.Size = new System.Drawing.Size(92, 24);
            this.btn_VSHPlug_2.TabIndex = 62;
            this.btn_VSHPlug_2.Text = "Load";
            this.btn_VSHPlug_2.UseVisualStyleBackColor = true;
            this.btn_VSHPlug_2.Click += new System.EventHandler(this.btn_VSHPlug_2_Click);
            // 
            // btn_VSHPlug_1
            // 
            this.btn_VSHPlug_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_VSHPlug_1.Location = new System.Drawing.Point(662, 69);
            this.btn_VSHPlug_1.Name = "btn_VSHPlug_1";
            this.btn_VSHPlug_1.Size = new System.Drawing.Size(92, 24);
            this.btn_VSHPlug_1.TabIndex = 63;
            this.btn_VSHPlug_1.Text = "Load";
            this.btn_VSHPlug_1.UseVisualStyleBackColor = true;
            this.btn_VSHPlug_1.Click += new System.EventHandler(this.btn_VSHPlug_1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "VSH Plugins:";
            // 
            // tabP_PluginsAdv
            // 
            this.tabP_PluginsAdv.Controls.Add(this.p_PluginsAdv);
            this.tabP_PluginsAdv.Controls.Add(this.panel6);
            this.tabP_PluginsAdv.Controls.Add(this.label2);
            this.tabP_PluginsAdv.Controls.Add(this.btn_PluginsSimple);
            this.tabP_PluginsAdv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabP_PluginsAdv.Location = new System.Drawing.Point(4, 26);
            this.tabP_PluginsAdv.Name = "tabP_PluginsAdv";
            this.tabP_PluginsAdv.Padding = new System.Windows.Forms.Padding(3);
            this.tabP_PluginsAdv.Size = new System.Drawing.Size(776, 475);
            this.tabP_PluginsAdv.TabIndex = 3;
            this.tabP_PluginsAdv.Text = "Plugins Commands";
            this.tabP_PluginsAdv.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Control;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnAttach2);
            this.panel6.Controls.Add(this.btnUnattach2);
            this.panel6.Controls.Add(this.btnRefresh2);
            this.panel6.Controls.Add(this.comboB_Procs2);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.Location = new System.Drawing.Point(80, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(556, 33);
            this.panel6.TabIndex = 55;
            // 
            // btnAttach2
            // 
            this.btnAttach2.Enabled = false;
            this.btnAttach2.Location = new System.Drawing.Point(352, 4);
            this.btnAttach2.Name = "btnAttach2";
            this.btnAttach2.Size = new System.Drawing.Size(87, 23);
            this.btnAttach2.TabIndex = 3;
            this.btnAttach2.Text = "Attach";
            this.btnAttach2.UseVisualStyleBackColor = true;
            this.btnAttach2.Click += new System.EventHandler(this.btnAttach2_Click);
            // 
            // btnUnattach2
            // 
            this.btnUnattach2.Enabled = false;
            this.btnUnattach2.Location = new System.Drawing.Point(455, 4);
            this.btnUnattach2.Name = "btnUnattach2";
            this.btnUnattach2.Size = new System.Drawing.Size(87, 23);
            this.btnUnattach2.TabIndex = 5;
            this.btnUnattach2.Text = "Unattach";
            this.btnUnattach2.UseVisualStyleBackColor = true;
            this.btnUnattach2.Click += new System.EventHandler(this.btnUnattach_Click);
            // 
            // btnRefresh2
            // 
            this.btnRefresh2.Enabled = false;
            this.btnRefresh2.Location = new System.Drawing.Point(248, 4);
            this.btnRefresh2.Name = "btnRefresh2";
            this.btnRefresh2.Size = new System.Drawing.Size(87, 23);
            this.btnRefresh2.TabIndex = 2;
            this.btnRefresh2.Text = "Refresh";
            this.btnRefresh2.UseVisualStyleBackColor = true;
            this.btnRefresh2.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // comboB_Procs2
            // 
            this.comboB_Procs2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboB_Procs2.Enabled = false;
            this.comboB_Procs2.FormattingEnabled = true;
            this.comboB_Procs2.Location = new System.Drawing.Point(6, 4);
            this.comboB_Procs2.MaxDropDownItems = 16;
            this.comboB_Procs2.Name = "comboB_Procs2";
            this.comboB_Procs2.Size = new System.Drawing.Size(226, 23);
            this.comboB_Procs2.TabIndex = 1;
            this.comboB_Procs2.SelectedIndexChanged += new System.EventHandler(this.comboB_Procs2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "Process:";
            // 
            // btn_PluginsSimple
            // 
            this.btn_PluginsSimple.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PluginsSimple.Location = new System.Drawing.Point(642, 9);
            this.btn_PluginsSimple.Name = "btn_PluginsSimple";
            this.btn_PluginsSimple.Size = new System.Drawing.Size(124, 25);
            this.btn_PluginsSimple.TabIndex = 53;
            this.btn_PluginsSimple.Text = "[Simple Mode]";
            this.btn_PluginsSimple.UseVisualStyleBackColor = true;
            this.btn_PluginsSimple.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_Module_Unload
            // 
            this.btn_Module_Unload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Module_Unload.Location = new System.Drawing.Point(597, 51);
            this.btn_Module_Unload.Name = "btn_Module_Unload";
            this.btn_Module_Unload.Size = new System.Drawing.Size(166, 26);
            this.btn_Module_Unload.TabIndex = 46;
            this.btn_Module_Unload.Text = "Unload selected plugin";
            this.btn_Module_Unload.UseVisualStyleBackColor = true;
            this.btn_Module_Unload.Click += new System.EventHandler(this.btn_Module_Unload_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(115, 20);
            this.label22.TabIndex = 45;
            this.label22.Text = "Plugins loaded:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(147, 20);
            this.label21.TabIndex = 44;
            this.label21.Text = "Load a plugin, path:";
            // 
            // btn_Module_Load
            // 
            this.btn_Module_Load.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Module_Load.Location = new System.Drawing.Point(676, 7);
            this.btn_Module_Load.Name = "btn_Module_Load";
            this.btn_Module_Load.Size = new System.Drawing.Size(87, 25);
            this.btn_Module_Load.TabIndex = 43;
            this.btn_Module_Load.Text = "Load";
            this.btn_Module_Load.UseVisualStyleBackColor = true;
            this.btn_Module_Load.Click += new System.EventHandler(this.btn_Module_Load_Click);
            // 
            // tB_Module_Path
            // 
            this.tB_Module_Path.BackColor = System.Drawing.SystemColors.Control;
            this.tB_Module_Path.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tB_Module_Path.Location = new System.Drawing.Point(156, 8);
            this.tB_Module_Path.MaxLength = 128;
            this.tB_Module_Path.Name = "tB_Module_Path";
            this.tB_Module_Path.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tB_Module_Path.Size = new System.Drawing.Size(514, 23);
            this.tB_Module_Path.TabIndex = 42;
            // 
            // btn_Module_Refresh
            // 
            this.btn_Module_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Module_Refresh.Location = new System.Drawing.Point(123, 51);
            this.btn_Module_Refresh.Name = "btn_Module_Refresh";
            this.btn_Module_Refresh.Size = new System.Drawing.Size(87, 26);
            this.btn_Module_Refresh.TabIndex = 41;
            this.btn_Module_Refresh.Text = "Refresh";
            this.btn_Module_Refresh.UseVisualStyleBackColor = true;
            this.btn_Module_Refresh.Click += new System.EventHandler(this.btn_Module_Refresh_Click);
            // 
            // lV_Modules
            // 
            this.lV_Modules.AutoArrange = false;
            this.lV_Modules.BackColor = System.Drawing.SystemColors.Control;
            this.lV_Modules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cH_Modules_Name,
            this.cH_Modules_Path});
            this.lV_Modules.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lV_Modules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lV_Modules.FullRowSelect = true;
            this.lV_Modules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lV_Modules.HideSelection = false;
            this.lV_Modules.Location = new System.Drawing.Point(0, 83);
            this.lV_Modules.MultiSelect = false;
            this.lV_Modules.Name = "lV_Modules";
            this.lV_Modules.ShowGroups = false;
            this.lV_Modules.Size = new System.Drawing.Size(770, 343);
            this.lV_Modules.TabIndex = 40;
            this.lV_Modules.UseCompatibleStateImageBehavior = false;
            this.lV_Modules.View = System.Windows.Forms.View.Details;
            // 
            // cH_Modules_Name
            // 
            this.cH_Modules_Name.Text = "Name";
            this.cH_Modules_Name.Width = 135;
            // 
            // cH_Modules_Path
            // 
            this.cH_Modules_Path.Text = "Path";
            this.cH_Modules_Path.Width = 549;
            // 
            // txtB_Port
            // 
            this.txtB_Port.Enabled = false;
            this.txtB_Port.Location = new System.Drawing.Point(215, 7);
            this.txtB_Port.MaxLength = 5;
            this.txtB_Port.Name = "txtB_Port";
            this.txtB_Port.Size = new System.Drawing.Size(55, 23);
            this.txtB_Port.TabIndex = 13;
            this.txtB_Port.Text = "7887";
            this.txtB_Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(159, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "PORT: ";
            // 
            // txtB_Ip
            // 
            this.txtB_Ip.Location = new System.Drawing.Point(37, 7);
            this.txtB_Ip.MaxLength = 16;
            this.txtB_Ip.Name = "txtB_Ip";
            this.txtB_Ip.Size = new System.Drawing.Size(116, 23);
            this.txtB_Ip.TabIndex = 11;
            this.txtB_Ip.Text = "127.0.0.1";
            this.txtB_Ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "IP: ";
            // 
            // p_Connection
            // 
            this.p_Connection.BackColor = System.Drawing.SystemColors.Control;
            this.p_Connection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.p_Connection.Controls.Add(this.btn_ShowLog);
            this.p_Connection.Controls.Add(this.txtB_Ip);
            this.p_Connection.Controls.Add(this.txtB_Port);
            this.p_Connection.Controls.Add(this.btnConnect);
            this.p_Connection.Controls.Add(this.btnDisconnect);
            this.p_Connection.Controls.Add(this.label5);
            this.p_Connection.Controls.Add(this.label6);
            this.p_Connection.Location = new System.Drawing.Point(185, 32);
            this.p_Connection.Name = "p_Connection";
            this.p_Connection.Size = new System.Drawing.Size(586, 38);
            this.p_Connection.TabIndex = 26;
            // 
            // btn_ShowLog
            // 
            this.btn_ShowLog.Location = new System.Drawing.Point(476, 4);
            this.btn_ShowLog.Name = "btn_ShowLog";
            this.btn_ShowLog.Size = new System.Drawing.Size(87, 27);
            this.btn_ShowLog.TabIndex = 14;
            this.btn_ShowLog.Text = "Show Log";
            this.btn_ShowLog.UseVisualStyleBackColor = true;
            this.btn_ShowLog.Click += new System.EventHandler(this.btn_ShowLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PS3_Manager_API_Demo_Tools.Properties.Resources.ICON0;
            this.pictureBox1.Location = new System.Drawing.Point(1, -7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Lib_Version
            // 
            this.lbl_Lib_Version.AutoSize = true;
            this.lbl_Lib_Version.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Lib_Version.Location = new System.Drawing.Point(695, 9);
            this.lbl_Lib_Version.Name = "lbl_Lib_Version";
            this.lbl_Lib_Version.Size = new System.Drawing.Size(77, 20);
            this.lbl_Lib_Version.TabIndex = 28;
            this.lbl_Lib_Version.Text = "Lib v7.7.7";
            // 
            // p_PluginsAdv
            // 
            this.p_PluginsAdv.Controls.Add(this.label21);
            this.p_PluginsAdv.Controls.Add(this.btn_Module_Refresh);
            this.p_PluginsAdv.Controls.Add(this.tB_Module_Path);
            this.p_PluginsAdv.Controls.Add(this.btn_Module_Load);
            this.p_PluginsAdv.Controls.Add(this.lV_Modules);
            this.p_PluginsAdv.Controls.Add(this.btn_Module_Unload);
            this.p_PluginsAdv.Controls.Add(this.label22);
            this.p_PluginsAdv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_PluginsAdv.Location = new System.Drawing.Point(3, 46);
            this.p_PluginsAdv.Name = "p_PluginsAdv";
            this.p_PluginsAdv.Size = new System.Drawing.Size(770, 426);
            this.p_PluginsAdv.TabIndex = 56;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 611);
            this.Controls.Add(this.tabC_Global);
            this.Controls.Add(this.lbl_Lib_Version);
            this.Controls.Add(this.p_Connection);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS3 Manager API Demo Tools";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabC_Global.ResumeLayout(false);
            this.tabP_PS3.ResumeLayout(false);
            this.tabP_PS3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.p_PS3_Notify.ResumeLayout(false);
            this.p_PS3_Notify.PerformLayout();
            this.p_PS3_MimicOFW.ResumeLayout(false);
            this.p_PS3_MimicOFW.PerformLayout();
            this.p_PS3_Led.ResumeLayout(false);
            this.p_PS3_Led.PerformLayout();
            this.p_PS3_Buzzer.ResumeLayout(false);
            this.p_PS3_Buzzer.PerformLayout();
            this.p_PS3_Power.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabP_Processes.ResumeLayout(false);
            this.tabP_Processes.PerformLayout();
            this.p_Process.ResumeLayout(false);
            this.p_SetMem.ResumeLayout(false);
            this.p_SetMem.PerformLayout();
            this.p_GetMem.ResumeLayout(false);
            this.p_GetMem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_GetLength)).EndInit();
            this.tabP_Plugins.ResumeLayout(false);
            this.tabP_Plugins.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabP_PluginsAdv.ResumeLayout(false);
            this.tabP_PluginsAdv.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.p_Connection.ResumeLayout(false);
            this.p_Connection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.p_PluginsAdv.ResumeLayout(false);
            this.p_PluginsAdv.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAttach;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox comboB_Procs;
        private System.Windows.Forms.Label lblProcs;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox textOutput;
        private System.Windows.Forms.TabControl tabC_Global;
        private System.Windows.Forms.TabPage tabP_PS3;
        private System.Windows.Forms.TabPage tabP_Processes;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button btnSetMem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel p_PS3_Led;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_PS3_Led_Set;
        private System.Windows.Forms.ComboBox cB_PS3_Led_Mode;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel p_PS3_Buzzer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Ring_Buzzer;
        private System.Windows.Forms.ComboBox cB_PS3_Buzzer;
        private System.Windows.Forms.Panel p_PS3_Power;
        private System.Windows.Forms.Button btn_Power_Execute;
        private System.Windows.Forms.ComboBox cB_PS3_Power;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Temp_Refresh;
        private System.Windows.Forms.Label lbl_Temp_CPU;
        private System.Windows.Forms.Label lbl_Temp_RSX;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_core_version;
        private System.Windows.Forms.Label lbl_fw;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel p_PS3_Notify;
        private System.Windows.Forms.TextBox tB_PS3_Notify;
        private System.Windows.Forms.Button btn_PS3_Notify;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel p_PS3_MimicOFW;
        private System.Windows.Forms.Button btn_PS3_DisableSyscall;
        private System.Windows.Forms.Button btnUnattach;
        private System.Windows.Forms.NumericUpDown nUD_GetLength;
        protected internal System.Windows.Forms.TextBox txtB_Port;
        private System.Windows.Forms.Label label5;
        protected internal System.Windows.Forms.TextBox txtB_Ip;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel p_Connection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_GameManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Setup;
        private System.Windows.Forms.Button btn_FileManager;
        private System.Windows.Forms.Button btn_PS3_ClearHistory;
        private System.Windows.Forms.CheckBox cB_PS3_MIMICOFW;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ShowLog;
        private System.Windows.Forms.Label lbl_Lib_Version;
        private System.Windows.Forms.CheckBox cb_RemoveHook;
        private System.Windows.Forms.CheckBox cb_Syscall_8_D;
        private System.Windows.Forms.CheckBox cb_Syscall_8_P3;
        private System.Windows.Forms.CheckBox cb_Syscall_8_P2;
        private System.Windows.Forms.CheckBox cb_Syscall_8_P1;
        private System.Windows.Forms.CheckBox cb_Syscall_8;
        private System.Windows.Forms.CheckBox cb_Syscall_36;
        private System.Windows.Forms.CheckBox cb_Syscall_35;
        private System.Windows.Forms.CheckBox cb_Syscall_11;
        private System.Windows.Forms.CheckBox cb_Syscall_10;
        private System.Windows.Forms.CheckBox cb_Syscall_9;
        private System.Windows.Forms.CheckBox cb_Syscall_7;
        private System.Windows.Forms.CheckBox cb_Syscall_6;
        private System.Windows.Forms.ComboBox cB_PS3_Led_Color;
        private System.Windows.Forms.Button btn_SetPSID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mtxtB_PSID;
        private System.Windows.Forms.Button btn_SetIDPS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtxtB_IDPS;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel p_GetMem;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TabPage tabP_Plugins;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Panel p_SetMem;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button btn_PluginsAdv;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox VSHPlug_Path_0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_VSHPlug_0;
        private System.Windows.Forms.TabPage tabP_PluginsAdv;
        private System.Windows.Forms.Button btn_PluginsSimple;
        private System.Windows.Forms.Button btn_Module_Unload;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btn_Module_Load;
        private System.Windows.Forms.TextBox tB_Module_Path;
        private System.Windows.Forms.Button btn_Module_Refresh;
        private System.Windows.Forms.ListView lV_Modules;
        private System.Windows.Forms.ColumnHeader cH_Modules_Name;
        private System.Windows.Forms.ColumnHeader cH_Modules_Path;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_OthersPlug_1;
        private System.Windows.Forms.TextBox OthersPlug_Path_2;
        private System.Windows.Forms.TextBox OthersPlug_Path_1;
        private System.Windows.Forms.Label OthersPlug_Name_2;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox OthersPlug_Path_0;
        private System.Windows.Forms.Button btn_OthersPlug_0;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label OthersPlug_Name_0;
        private System.Windows.Forms.Label OthersPlug_Name_1;
        private System.Windows.Forms.Button btn_OthersPlug_2;
        private System.Windows.Forms.TextBox VSHPlug_Path_6;
        private System.Windows.Forms.TextBox VSHPlug_Path_5;
        private System.Windows.Forms.TextBox VSHPlug_Path_4;
        private System.Windows.Forms.TextBox VSHPlug_Path_3;
        private System.Windows.Forms.TextBox VSHPlug_Path_2;
        private System.Windows.Forms.TextBox VSHPlug_Path_1;
        private System.Windows.Forms.Label VSHPlug_Name_6;
        private System.Windows.Forms.Label VSHPlug_Name_5;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label VSHPlug_Name_4;
        private System.Windows.Forms.Label VSHPlug_Name_3;
        private System.Windows.Forms.Label VSHPlug_Name_2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label VSHPlug_Name_0;
        private System.Windows.Forms.Label VSHPlug_Name_1;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btn_VSHPlug_6;
        private System.Windows.Forms.Button btn_VSHPlug_5;
        private System.Windows.Forms.Button btn_VSHPlug_4;
        private System.Windows.Forms.Button btn_VSHPlug_3;
        private System.Windows.Forms.Button btn_VSHPlug_2;
        private System.Windows.Forms.Button btn_VSHPlug_1;
        private System.Windows.Forms.Panel p_Process;
        private System.Windows.Forms.Button VSHPlug_Refresh;
        private System.Windows.Forms.Button OthersPlug_Refresh;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox OthersPlug_Process_2;
        private System.Windows.Forms.ComboBox OthersPlug_Process_1;
        private System.Windows.Forms.ComboBox OthersPlug_Process_0;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAttach2;
        private System.Windows.Forms.Button btnUnattach2;
        private System.Windows.Forms.Button btnRefresh2;
        private System.Windows.Forms.ComboBox comboB_Procs2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtB_SetOffset;
        private System.Windows.Forms.TextBox txtB_GetOffset;
        private System.Windows.Forms.Panel p_PluginsAdv;
    }
}

