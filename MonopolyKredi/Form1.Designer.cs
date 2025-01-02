namespace MonopolyKredi
{
    partial class main_page
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_page));
            this.maas_button1 = new System.Windows.Forms.Button();
            this.maas_button2 = new System.Windows.Forms.Button();
            this.maas_button3 = new System.Windows.Forms.Button();
            this.maas_button4 = new System.Windows.Forms.Button();
            this.maas_button5 = new System.Windows.Forms.Button();
            this.maas_button6 = new System.Windows.Forms.Button();
            this.airplane_balance_text = new System.Windows.Forms.Label();
            this.hamburger_balance_text = new System.Windows.Forms.Label();
            this.skateboard_balance_text = new System.Windows.Forms.Label();
            this.formula_balance_text = new System.Windows.Forms.Label();
            this.skate_balance_text = new System.Windows.Forms.Label();
            this.telephone_balance_text = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.bakiye_title = new System.Windows.Forms.Label();
            this.takas = new System.Windows.Forms.Button();
            this.remitter_cb = new System.Windows.Forms.ComboBox();
            this.beneficiary_cb = new System.Windows.Forms.ComboBox();
            this.gonderen_title = new System.Windows.Forms.Label();
            this.alan_title = new System.Windows.Forms.Label();
            this.ucret_title = new System.Windows.Forms.Label();
            this.deduction = new System.Windows.Forms.TextBox();
            this.airplane_player = new System.Windows.Forms.TextBox();
            this.ucak_oyuncusu_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hamburger_player = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.skateboard_player = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.formula_player = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.skate_player = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telephone_player = new System.Windows.Forms.TextBox();
            this.oyuncu_kaydet = new System.Windows.Forms.Button();
            this.oyunculari_sifirla = new System.Windows.Forms.Button();
            this.telefon_simge = new System.Windows.Forms.PictureBox();
            this.paten_simge = new System.Windows.Forms.PictureBox();
            this.formula_simge = new System.Windows.Forms.PictureBox();
            this.kaykay_simge = new System.Windows.Forms.PictureBox();
            this.hamburger_simge = new System.Windows.Forms.PictureBox();
            this.ucak_simge = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.telefon_simge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paten_simge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formula_simge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaykay_simge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburger_simge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucak_simge)).BeginInit();
            this.SuspendLayout();
            // 
            // maas_button1
            // 
            this.maas_button1.Location = new System.Drawing.Point(392, 46);
            this.maas_button1.Name = "maas_button1";
            this.maas_button1.Size = new System.Drawing.Size(128, 64);
            this.maas_button1.TabIndex = 1;
            this.maas_button1.Text = "Maaş Ver";
            this.maas_button1.UseVisualStyleBackColor = true;
            this.maas_button1.Click += new System.EventHandler(this.airplane_pay);
            // 
            // maas_button2
            // 
            this.maas_button2.Location = new System.Drawing.Point(392, 121);
            this.maas_button2.Name = "maas_button2";
            this.maas_button2.Size = new System.Drawing.Size(128, 64);
            this.maas_button2.TabIndex = 2;
            this.maas_button2.Text = "Maaş Ver";
            this.maas_button2.UseVisualStyleBackColor = true;
            this.maas_button2.Click += new System.EventHandler(this.hamburger_pay);
            // 
            // maas_button3
            // 
            this.maas_button3.Location = new System.Drawing.Point(392, 196);
            this.maas_button3.Name = "maas_button3";
            this.maas_button3.Size = new System.Drawing.Size(128, 64);
            this.maas_button3.TabIndex = 3;
            this.maas_button3.Text = "Maaş Ver";
            this.maas_button3.UseVisualStyleBackColor = true;
            this.maas_button3.Click += new System.EventHandler(this.skateboard_pay);
            // 
            // maas_button4
            // 
            this.maas_button4.Location = new System.Drawing.Point(392, 271);
            this.maas_button4.Name = "maas_button4";
            this.maas_button4.Size = new System.Drawing.Size(128, 64);
            this.maas_button4.TabIndex = 4;
            this.maas_button4.Text = "Maaş Ver";
            this.maas_button4.UseVisualStyleBackColor = true;
            this.maas_button4.Click += new System.EventHandler(this.formula_pay);
            // 
            // maas_button5
            // 
            this.maas_button5.Location = new System.Drawing.Point(392, 346);
            this.maas_button5.Name = "maas_button5";
            this.maas_button5.Size = new System.Drawing.Size(128, 64);
            this.maas_button5.TabIndex = 5;
            this.maas_button5.Text = "Maaş Ver";
            this.maas_button5.UseVisualStyleBackColor = true;
            this.maas_button5.Click += new System.EventHandler(this.skate_pay);
            // 
            // maas_button6
            // 
            this.maas_button6.Location = new System.Drawing.Point(392, 421);
            this.maas_button6.Name = "maas_button6";
            this.maas_button6.Size = new System.Drawing.Size(128, 64);
            this.maas_button6.TabIndex = 6;
            this.maas_button6.Text = "Maaş Ver";
            this.maas_button6.UseVisualStyleBackColor = true;
            this.maas_button6.Click += new System.EventHandler(this.telephone_pay);
            // 
            // ucak_bakiye_text
            // 
            this.airplane_balance_text.AutoSize = true;
            this.airplane_balance_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.airplane_balance_text.Location = new System.Drawing.Point(123, 72);
            this.airplane_balance_text.Name = "ucak_bakiye_text";
            this.airplane_balance_text.Size = new System.Drawing.Size(63, 16);
            this.airplane_balance_text.TabIndex = 0;
            this.airplane_balance_text.Text = "15000000";
            // 
            // hamburger_bakiye_text
            // 
            this.hamburger_balance_text.AutoSize = true;
            this.hamburger_balance_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hamburger_balance_text.Location = new System.Drawing.Point(123, 147);
            this.hamburger_balance_text.Name = "hamburger_bakiye_text";
            this.hamburger_balance_text.Size = new System.Drawing.Size(63, 16);
            this.hamburger_balance_text.TabIndex = 0;
            this.hamburger_balance_text.Text = "15000000";
            // 
            // kaykay_bakiye_text
            // 
            this.skateboard_balance_text.AutoSize = true;
            this.skateboard_balance_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skateboard_balance_text.Location = new System.Drawing.Point(123, 222);
            this.skateboard_balance_text.Name = "kaykay_bakiye_text";
            this.skateboard_balance_text.Size = new System.Drawing.Size(63, 16);
            this.skateboard_balance_text.TabIndex = 0;
            this.skateboard_balance_text.Text = "15000000";
            // 
            // formula_bakiye_text
            // 
            this.formula_balance_text.AutoSize = true;
            this.formula_balance_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.formula_balance_text.Location = new System.Drawing.Point(123, 297);
            this.formula_balance_text.Name = "formula_bakiye_text";
            this.formula_balance_text.Size = new System.Drawing.Size(63, 16);
            this.formula_balance_text.TabIndex = 0;
            this.formula_balance_text.Text = "15000000";
            // 
            // paten_bakiye_text
            // 
            this.skate_balance_text.AutoSize = true;
            this.skate_balance_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skate_balance_text.Location = new System.Drawing.Point(123, 372);
            this.skate_balance_text.Name = "paten_bakiye_text";
            this.skate_balance_text.Size = new System.Drawing.Size(63, 16);
            this.skate_balance_text.TabIndex = 0;
            this.skate_balance_text.Text = "15000000";
            // 
            // telefon_bakiye_text
            // 
            this.telephone_balance_text.AutoSize = true;
            this.telephone_balance_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.telephone_balance_text.Location = new System.Drawing.Point(123, 447);
            this.telephone_balance_text.Name = "telefon_bakiye_text";
            this.telephone_balance_text.Size = new System.Drawing.Size(63, 16);
            this.telephone_balance_text.TabIndex = 0;
            this.telephone_balance_text.Text = "15000000";
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.Location = new System.Drawing.Point(1322, 826);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(90, 23);
            this.reset.TabIndex = 18;
            this.reset.Text = "Bakiye Sıfırla";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_balance);
            // 
            // bakiye_title
            // 
            this.bakiye_title.AutoSize = true;
            this.bakiye_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bakiye_title.Location = new System.Drawing.Point(119, 24);
            this.bakiye_title.Name = "bakiye_title";
            this.bakiye_title.Size = new System.Drawing.Size(71, 24);
            this.bakiye_title.TabIndex = 9;
            this.bakiye_title.Text = "Bakiye";
            // 
            // takas
            // 
            this.takas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.takas.Location = new System.Drawing.Point(974, 72);
            this.takas.Name = "takas";
            this.takas.Size = new System.Drawing.Size(75, 23);
            this.takas.TabIndex = 10;
            this.takas.Text = "Takas";
            this.takas.UseVisualStyleBackColor = true;
            this.takas.Click += new System.EventHandler(this.rent_payment);
            // 
            // gonderen_cb
            // 
            this.remitter_cb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.remitter_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.remitter_cb.FormattingEnabled = true;
            this.remitter_cb.Location = new System.Drawing.Point(559, 74);
            this.remitter_cb.Name = "gonderen_cb";
            this.remitter_cb.Size = new System.Drawing.Size(121, 21);
            this.remitter_cb.TabIndex = 7;
            this.remitter_cb.SelectedIndexChanged += new System.EventHandler(this.gonderen_cb_SelectedIndexChanged);
            // 
            // alan_cb
            // 
            this.beneficiary_cb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.beneficiary_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.beneficiary_cb.FormattingEnabled = true;
            this.beneficiary_cb.Location = new System.Drawing.Point(710, 74);
            this.beneficiary_cb.Name = "alan_cb";
            this.beneficiary_cb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.beneficiary_cb.Size = new System.Drawing.Size(121, 21);
            this.beneficiary_cb.TabIndex = 8;
            this.beneficiary_cb.SelectedIndexChanged += new System.EventHandler(this.alan_cb_SelectedIndexChanged);
            // 
            // gonderen_title
            // 
            this.gonderen_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gonderen_title.AutoSize = true;
            this.gonderen_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gonderen_title.Location = new System.Drawing.Point(567, 24);
            this.gonderen_title.Name = "gonderen_title";
            this.gonderen_title.Size = new System.Drawing.Size(104, 24);
            this.gonderen_title.TabIndex = 0;
            this.gonderen_title.Text = "Gönderen";
            // 
            // alan_title
            // 
            this.alan_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.alan_title.AutoSize = true;
            this.alan_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alan_title.Location = new System.Drawing.Point(744, 24);
            this.alan_title.Name = "alan_title";
            this.alan_title.Size = new System.Drawing.Size(52, 24);
            this.alan_title.TabIndex = 0;
            this.alan_title.Text = "Alan";
            // 
            // ucret_title
            // 
            this.ucret_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ucret_title.AutoSize = true;
            this.ucret_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucret_title.Location = new System.Drawing.Point(872, 24);
            this.ucret_title.Name = "ucret_title";
            this.ucret_title.Size = new System.Drawing.Size(59, 24);
            this.ucret_title.TabIndex = 0;
            this.ucret_title.Text = "Ücret";
            // 
            // dusulecek_miktar
            // 
            this.deduction.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deduction.Location = new System.Drawing.Point(853, 74);
            this.deduction.MaxLength = 8;
            this.deduction.Name = "dusulecek_miktar";
            this.deduction.Size = new System.Drawing.Size(100, 20);
            this.deduction.TabIndex = 9;
            this.deduction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Deduction_KeyPress);
            // 
            // ucak_oyuncusu
            // 
            this.airplane_player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.airplane_player.Location = new System.Drawing.Point(237, 668);
            this.airplane_player.Name = "ucak_oyuncusu";
            this.airplane_player.Size = new System.Drawing.Size(100, 20);
            this.airplane_player.TabIndex = 11;
            // 
            // ucak_oyuncusu_title
            // 
            this.ucak_oyuncusu_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucak_oyuncusu_title.AutoSize = true;
            this.ucak_oyuncusu_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ucak_oyuncusu_title.Location = new System.Drawing.Point(12, 664);
            this.ucak_oyuncusu_title.Name = "ucak_oyuncusu_title";
            this.ucak_oyuncusu_title.Size = new System.Drawing.Size(157, 24);
            this.ucak_oyuncusu_title.TabIndex = 9;
            this.ucak_oyuncusu_title.Text = "Uçak Oyuncusu";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hamburger Oyuncusu";
            // 
            // hamburger_oyuncusu
            // 
            this.hamburger_player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hamburger_player.Location = new System.Drawing.Point(237, 701);
            this.hamburger_player.Name = "hamburger_oyuncusu";
            this.hamburger_player.Size = new System.Drawing.Size(100, 20);
            this.hamburger_player.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 730);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kaykay Oyuncusu";
            // 
            // kaykay_oyuncusu
            // 
            this.skateboard_player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skateboard_player.Location = new System.Drawing.Point(237, 734);
            this.skateboard_player.Name = "kaykay_oyuncusu";
            this.skateboard_player.Size = new System.Drawing.Size(100, 20);
            this.skateboard_player.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 763);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Formula Oyuncusu";
            // 
            // formula_oyuncusu
            // 
            this.formula_player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.formula_player.Location = new System.Drawing.Point(237, 767);
            this.formula_player.Name = "formula_oyuncusu";
            this.formula_player.Size = new System.Drawing.Size(100, 20);
            this.formula_player.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 796);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Paten Oyuncusu";
            // 
            // paten_oyuncusu
            // 
            this.skate_player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.skate_player.Location = new System.Drawing.Point(237, 800);
            this.skate_player.Name = "paten_oyuncusu";
            this.skate_player.Size = new System.Drawing.Size(100, 20);
            this.skate_player.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(12, 829);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefon Oyuncusu";
            // 
            // telefon_oyuncusu
            // 
            this.telephone_player.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.telephone_player.Location = new System.Drawing.Point(237, 833);
            this.telephone_player.Name = "telefon_oyuncusu";
            this.telephone_player.Size = new System.Drawing.Size(100, 20);
            this.telephone_player.TabIndex = 16;
            // 
            // oyuncu_kaydet
            // 
            this.oyuncu_kaydet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.oyuncu_kaydet.Location = new System.Drawing.Point(392, 828);
            this.oyuncu_kaydet.Name = "oyuncu_kaydet";
            this.oyuncu_kaydet.Size = new System.Drawing.Size(120, 25);
            this.oyuncu_kaydet.TabIndex = 17;
            this.oyuncu_kaydet.Text = "Oyuncuları Kaydet";
            this.oyuncu_kaydet.UseVisualStyleBackColor = true;
            this.oyuncu_kaydet.Click += new System.EventHandler(this.save_players);
            // 
            // oyunculari_sifirla
            // 
            this.oyunculari_sifirla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.oyunculari_sifirla.Location = new System.Drawing.Point(1226, 826);
            this.oyunculari_sifirla.Name = "oyunculari_sifirla";
            this.oyunculari_sifirla.Size = new System.Drawing.Size(90, 23);
            this.oyunculari_sifirla.TabIndex = 18;
            this.oyunculari_sifirla.Text = "Oyuncu Sıfırla";
            this.oyunculari_sifirla.UseVisualStyleBackColor = true;
            this.oyunculari_sifirla.Click += new System.EventHandler(this.reset_players);
            // 
            // telefon_simge
            // 
            this.telefon_simge.Image = global::MonopolyKredi.Properties.Resources._6;
            this.telefon_simge.Location = new System.Drawing.Point(31, 421);
            this.telefon_simge.Name = "telefon_simge";
            this.telefon_simge.Size = new System.Drawing.Size(64, 64);
            this.telefon_simge.TabIndex = 6;
            this.telefon_simge.TabStop = false;
            // 
            // paten_simge
            // 
            this.paten_simge.Image = global::MonopolyKredi.Properties.Resources._5;
            this.paten_simge.Location = new System.Drawing.Point(31, 346);
            this.paten_simge.Name = "paten_simge";
            this.paten_simge.Size = new System.Drawing.Size(64, 64);
            this.paten_simge.TabIndex = 6;
            this.paten_simge.TabStop = false;
            // 
            // formula_simge
            // 
            this.formula_simge.Image = global::MonopolyKredi.Properties.Resources._4;
            this.formula_simge.Location = new System.Drawing.Point(31, 271);
            this.formula_simge.Name = "formula_simge";
            this.formula_simge.Size = new System.Drawing.Size(64, 64);
            this.formula_simge.TabIndex = 6;
            this.formula_simge.TabStop = false;
            // 
            // kaykay_simge
            // 
            this.kaykay_simge.Image = global::MonopolyKredi.Properties.Resources._3;
            this.kaykay_simge.Location = new System.Drawing.Point(31, 196);
            this.kaykay_simge.Name = "kaykay_simge";
            this.kaykay_simge.Size = new System.Drawing.Size(64, 64);
            this.kaykay_simge.TabIndex = 6;
            this.kaykay_simge.TabStop = false;
            // 
            // hamburger_simge
            // 
            this.hamburger_simge.Image = global::MonopolyKredi.Properties.Resources._2;
            this.hamburger_simge.Location = new System.Drawing.Point(31, 121);
            this.hamburger_simge.Name = "hamburger_simge";
            this.hamburger_simge.Size = new System.Drawing.Size(64, 64);
            this.hamburger_simge.TabIndex = 6;
            this.hamburger_simge.TabStop = false;
            // 
            // ucak_simge
            // 
            this.ucak_simge.Image = global::MonopolyKredi.Properties.Resources._1;
            this.ucak_simge.Location = new System.Drawing.Point(31, 46);
            this.ucak_simge.Name = "ucak_simge";
            this.ucak_simge.Size = new System.Drawing.Size(64, 64);
            this.ucak_simge.TabIndex = 6;
            this.ucak_simge.TabStop = false;
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 861);
            this.Controls.Add(this.oyuncu_kaydet);
            this.Controls.Add(this.telephone_player);
            this.Controls.Add(this.skate_player);
            this.Controls.Add(this.formula_player);
            this.Controls.Add(this.skateboard_player);
            this.Controls.Add(this.hamburger_player);
            this.Controls.Add(this.airplane_player);
            this.Controls.Add(this.beneficiary_cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.remitter_cb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.takas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.deduction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucret_title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alan_title);
            this.Controls.Add(this.ucak_oyuncusu_title);
            this.Controls.Add(this.gonderen_title);
            this.Controls.Add(this.bakiye_title);
            this.Controls.Add(this.oyunculari_sifirla);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.telephone_balance_text);
            this.Controls.Add(this.skateboard_balance_text);
            this.Controls.Add(this.skate_balance_text);
            this.Controls.Add(this.hamburger_balance_text);
            this.Controls.Add(this.formula_balance_text);
            this.Controls.Add(this.airplane_balance_text);
            this.Controls.Add(this.telefon_simge);
            this.Controls.Add(this.paten_simge);
            this.Controls.Add(this.formula_simge);
            this.Controls.Add(this.kaykay_simge);
            this.Controls.Add(this.hamburger_simge);
            this.Controls.Add(this.ucak_simge);
            this.Controls.Add(this.maas_button6);
            this.Controls.Add(this.maas_button5);
            this.Controls.Add(this.maas_button4);
            this.Controls.Add(this.maas_button3);
            this.Controls.Add(this.maas_button2);
            this.Controls.Add(this.maas_button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main_page";
            this.Text = "Monopoly";
            this.Load += new System.EventHandler(this.main_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.telefon_simge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paten_simge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formula_simge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaykay_simge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hamburger_simge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucak_simge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button maas_button1;
        private System.Windows.Forms.Button maas_button2;
        private System.Windows.Forms.Button maas_button3;
        private System.Windows.Forms.Button maas_button4;
        private System.Windows.Forms.Button maas_button5;
        private System.Windows.Forms.Button maas_button6;
        private System.Windows.Forms.PictureBox ucak_simge;
        private System.Windows.Forms.PictureBox hamburger_simge;
        private System.Windows.Forms.PictureBox kaykay_simge;
        private System.Windows.Forms.PictureBox formula_simge;
        private System.Windows.Forms.PictureBox paten_simge;
        private System.Windows.Forms.PictureBox telefon_simge;
        private System.Windows.Forms.Label airplane_balance_text;
        private System.Windows.Forms.Label hamburger_balance_text;
        private System.Windows.Forms.Label skateboard_balance_text;
        private System.Windows.Forms.Label formula_balance_text;
        private System.Windows.Forms.Label skate_balance_text;
        private System.Windows.Forms.Label telephone_balance_text;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label bakiye_title;
        private System.Windows.Forms.Button takas;
        private System.Windows.Forms.ComboBox remitter_cb;
        private System.Windows.Forms.ComboBox beneficiary_cb;
        private System.Windows.Forms.Label gonderen_title;
        private System.Windows.Forms.Label alan_title;
        private System.Windows.Forms.Label ucret_title;
        private System.Windows.Forms.TextBox deduction;
        private System.Windows.Forms.TextBox airplane_player;
        private System.Windows.Forms.Label ucak_oyuncusu_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hamburger_player;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox skateboard_player;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox formula_player;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox skate_player;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telephone_player;
        private System.Windows.Forms.Button oyuncu_kaydet;
        private System.Windows.Forms.Button oyunculari_sifirla;
    }
}

