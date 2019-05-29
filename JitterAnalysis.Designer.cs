namespace ICPackaging
{
    partial class JitterAnalysis
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
            System.Windows.Forms.TreeNode treeNode64 = new System.Windows.Forms.TreeNode("Periodic Jitter");
            System.Windows.Forms.TreeNode treeNode65 = new System.Windows.Forms.TreeNode("Crosstalk");
            System.Windows.Forms.TreeNode treeNode66 = new System.Windows.Forms.TreeNode("Intersymbol interface (ISI)");
            System.Windows.Forms.TreeNode treeNode67 = new System.Windows.Forms.TreeNode("Duty cycle distortion");
            System.Windows.Forms.TreeNode treeNode68 = new System.Windows.Forms.TreeNode("Data Dependent Jitter", new System.Windows.Forms.TreeNode[] {
            treeNode65,
            treeNode66,
            treeNode67});
            System.Windows.Forms.TreeNode treeNode69 = new System.Windows.Forms.TreeNode("Crosstalk ");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JitterAnalysis));
            System.Windows.Forms.TreeNode treeNode70 = new System.Windows.Forms.TreeNode("Deterministic Jitter (DJ)", new System.Windows.Forms.TreeNode[] {
            treeNode64,
            treeNode68,
            treeNode69});
            System.Windows.Forms.TreeNode treeNode71 = new System.Windows.Forms.TreeNode("Sources of RJ");
            System.Windows.Forms.TreeNode treeNode72 = new System.Windows.Forms.TreeNode("Random Jitter", new System.Windows.Forms.TreeNode[] {
            treeNode71});
            System.Windows.Forms.TreeNode treeNode73 = new System.Windows.Forms.TreeNode("Jitter Sources", new System.Windows.Forms.TreeNode[] {
            treeNode70,
            treeNode72});
            System.Windows.Forms.TreeNode treeNode74 = new System.Windows.Forms.TreeNode("Externally generated noise");
            System.Windows.Forms.TreeNode treeNode75 = new System.Windows.Forms.TreeNode("Local Supply Noise");
            System.Windows.Forms.TreeNode treeNode76 = new System.Windows.Forms.TreeNode("SupplyNoise", new System.Windows.Forms.TreeNode[] {
            treeNode74,
            treeNode75});
            System.Windows.Forms.TreeNode treeNode77 = new System.Windows.Forms.TreeNode("Receiver Offset");
            System.Windows.Forms.TreeNode treeNode78 = new System.Windows.Forms.TreeNode("Receiver Sensitivity");
            System.Windows.Forms.TreeNode treeNode79 = new System.Windows.Forms.TreeNode("Vref Noise");
            System.Windows.Forms.TreeNode treeNode80 = new System.Windows.Forms.TreeNode("Equalizer Quantization Error");
            System.Windows.Forms.TreeNode treeNode81 = new System.Windows.Forms.TreeNode("Thermal and Shot noise");
            System.Windows.Forms.TreeNode treeNode82 = new System.Windows.Forms.TreeNode("Noise sources ", new System.Windows.Forms.TreeNode[] {
            treeNode76,
            treeNode77,
            treeNode78,
            treeNode79,
            treeNode80,
            treeNode81});
            System.Windows.Forms.TreeNode treeNode83 = new System.Windows.Forms.TreeNode("Peak distortion analysis method");
            System.Windows.Forms.TreeNode treeNode84 = new System.Windows.Forms.TreeNode("Noise Budget", new System.Windows.Forms.TreeNode[] {
            treeNode83});
            this.FIRButton = new System.Windows.Forms.Button();
            this.Equalization = new System.Windows.Forms.Button();
            this.CTLE = new System.Windows.Forms.Button();
            this.FFE = new System.Windows.Forms.Button();
            this.DFE = new System.Windows.Forms.Button();
            this.BER = new System.Windows.Forms.Button();
            this.JitterTree = new System.Windows.Forms.TreeView();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FIRButton
            // 
            this.FIRButton.Location = new System.Drawing.Point(408, 174);
            this.FIRButton.Name = "FIRButton";
            this.FIRButton.Size = new System.Drawing.Size(184, 23);
            this.FIRButton.TabIndex = 3;
            this.FIRButton.Text = "Finite Impulse Response Filter";
            this.FIRButton.UseVisualStyleBackColor = true;
            this.FIRButton.Click += new System.EventHandler(this.FIRButton_Click);
            // 
            // Equalization
            // 
            this.Equalization.Location = new System.Drawing.Point(43, 174);
            this.Equalization.Name = "Equalization";
            this.Equalization.Size = new System.Drawing.Size(153, 23);
            this.Equalization.TabIndex = 4;
            this.Equalization.Text = "What is Equalization?";
            this.Equalization.UseVisualStyleBackColor = true;
            this.Equalization.Click += new System.EventHandler(this.Equalization_Click);
            // 
            // CTLE
            // 
            this.CTLE.Location = new System.Drawing.Point(43, 203);
            this.CTLE.Name = "CTLE";
            this.CTLE.Size = new System.Drawing.Size(153, 23);
            this.CTLE.TabIndex = 5;
            this.CTLE.Text = "Receiver Equalization: CTLE";
            this.CTLE.UseVisualStyleBackColor = true;
            this.CTLE.Click += new System.EventHandler(this.CTLE_Click);
            // 
            // FFE
            // 
            this.FFE.Location = new System.Drawing.Point(214, 203);
            this.FFE.Name = "FFE";
            this.FFE.Size = new System.Drawing.Size(188, 23);
            this.FFE.TabIndex = 6;
            this.FFE.Text = "Receiver Eq: Feed Forward Eq";
            this.FFE.UseVisualStyleBackColor = true;
            this.FFE.Click += new System.EventHandler(this.FFE_Click);
            // 
            // DFE
            // 
            this.DFE.Location = new System.Drawing.Point(214, 174);
            this.DFE.Name = "DFE";
            this.DFE.Size = new System.Drawing.Size(188, 23);
            this.DFE.TabIndex = 7;
            this.DFE.Text = "Receiver Eq Decision Feedback (DFE)";
            this.DFE.UseVisualStyleBackColor = true;
            this.DFE.Click += new System.EventHandler(this.DFE_Click);
            // 
            // BER
            // 
            this.BER.Location = new System.Drawing.Point(408, 203);
            this.BER.Name = "BER";
            this.BER.Size = new System.Drawing.Size(184, 23);
            this.BER.TabIndex = 8;
            this.BER.Text = "What is BER?";
            this.BER.UseVisualStyleBackColor = true;
            this.BER.Click += new System.EventHandler(this.BER_Click);
            // 
            // JitterTree
            // 
            this.JitterTree.Location = new System.Drawing.Point(616, 12);
            this.JitterTree.Name = "JitterTree";
            treeNode64.Name = "PJ";
            treeNode64.Text = "Periodic Jitter";
            treeNode64.ToolTipText = "Repeats at a fixed frequency and is caused by modulating effects such as spread s" +
    "pectrum clocking. For a system with multiple periodic sources, we need to model " +
    "periodic jitter";
            treeNode65.Name = "Crosstalk";
            treeNode65.Text = "Crosstalk";
            treeNode65.ToolTipText = "Data dependent";
            treeNode66.Name = "ISI";
            treeNode66.Text = "Intersymbol interface (ISI)";
            treeNode66.ToolTipText = "The interconnect channel consists of losses, dispersion and reflections. This cau" +
    "ses Intersymbol interferences in the transmission line";
            treeNode67.Name = "DCD";
            treeNode67.Text = "Duty cycle distortion";
            treeNode67.ToolTipText = "Results from the deviation in the amount of time the signal spends in the logic s" +
    "tates. E.g rise and fall time mismatches.";
            treeNode68.Name = "DDJ";
            treeNode68.Text = "Data Dependent Jitter";
            treeNode68.ToolTipText = "Depends on the transmitted data pattern";
            treeNode69.Name = "crosstalk";
            treeNode69.Text = "Crosstalk ";
            treeNode69.ToolTipText = resources.GetString("treeNode69.ToolTipText");
            treeNode70.Name = "DJ";
            treeNode70.Text = "Deterministic Jitter (DJ)";
            treeNode70.ToolTipText = "The probability of exceeding the peak to peak maximum value is equal to zero,henc" +
    "e it is called a being bounded.";
            treeNode71.Name = "Sources";
            treeNode71.Text = "Sources of RJ";
            treeNode71.ToolTipText = "Source of RJ include device noise such as shot , flicker and thermal";
            treeNode72.Name = "RJ";
            treeNode72.Text = "Random Jitter";
            treeNode72.ToolTipText = resources.GetString("treeNode72.ToolTipText");
            treeNode73.Name = "Node0";
            treeNode73.Text = "Jitter Sources";
            treeNode73.ToolTipText = "Utilize the dual durac model to estimate the total system jitter";
            treeNode74.Name = "SupplyNoise";
            treeNode74.Text = "Externally generated noise";
            treeNode74.ToolTipText = "Noise from PDN between voltage source regulator and local I/O ckts";
            treeNode75.Name = "LocalSupplyNoise";
            treeNode75.Text = "Local Supply Noise";
            treeNode75.ToolTipText = "Generated  by transient currents in the I/O circuits. For single ended systems, t" +
    "he current transients can be high hence casuing local supply noise to be up to 1" +
    "0% of Vss.";
            treeNode76.Name = "SN";
            treeNode76.Text = "SupplyNoise";
            treeNode76.ToolTipText = "Power Supply Noise, it is caused largely by a common-mode source. It is beneficia" +
    "l to utilize differential I/O ckts that can reject most of the noise. Hence they" +
    " have a high CMMR ratio.";
            treeNode77.Name = "RecOffset";
            treeNode77.Text = "Receiver Offset";
            treeNode77.ToolTipText = "Due to process variations (corner cases) , devices can exhibit variations in the " +
    "threshold voltage of a receiver ckt.";
            treeNode78.Name = "ReceiverSensitivity";
            treeNode78.Text = "Receiver Sensitivity";
            treeNode79.Name = "VrefNoise";
            treeNode79.Text = "Vref Noise";
            treeNode79.ToolTipText = " Typical noise specifications are +/-2% of the reference voltage";
            treeNode80.Name = "EqualizerQuant";
            treeNode80.Text = "Equalizer Quantization Error";
            treeNode80.ToolTipText = "DLE, use DACs to generate the equalizer coefficients (IC design) ";
            treeNode81.Name = "ThermalShotNoise";
            treeNode81.Text = "Thermal and Shot noise";
            treeNode81.ToolTipText = "Thermal noise is a result of power dissipation in devices and displays a normal d" +
    "istribution. ";
            treeNode82.Name = "NoiseSources";
            treeNode82.Text = "Noise sources ";
            treeNode82.ToolTipText = "Various noise sources in digital signaling systems";
            treeNode83.Name = "PKanalysis";
            treeNode83.Text = "Peak distortion analysis method";
            treeNode83.ToolTipText = "Techniques utilized to determine the worst case values for peak jitter and noise " +
    "is called peak distortion analysis (PDA)";
            treeNode84.Name = "NoiseBudget";
            treeNode84.Text = "Noise Budget";
            treeNode84.ToolTipText = "Utilized to design a noise margin for a system. Find out the probability of excee" +
    "ding the worst case scenario for e.g 1 in a trillion, ";
            this.JitterTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode73,
            treeNode82,
            treeNode84});
            this.JitterTree.ShowNodeToolTips = true;
            this.JitterTree.Size = new System.Drawing.Size(226, 214);
            this.JitterTree.TabIndex = 9;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ICPackaging.Properties.Resources.Jitter4;
            this.pictureBox6.Location = new System.Drawing.Point(639, 242);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(203, 140);
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ICPackaging.Properties.Resources.Jitter3;
            this.pictureBox5.Location = new System.Drawing.Point(430, 242);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(203, 140);
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ICPackaging.Properties.Resources.Jitter2;
            this.pictureBox4.Location = new System.Drawing.Point(221, 242);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(203, 140);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ICPackaging.Properties.Resources.Jitter1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 242);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(203, 140);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ICPackaging.Properties.Resources.FIRWaveform;
            this.pictureBox2.Location = new System.Drawing.Point(274, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(318, 156);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ICPackaging.Properties.Resources.DefaultChannel1;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 156);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Period Jitter Only ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Including DCD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total System Jitter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Jitter + bypass capacitors and equalization";
            // 
            // JitterAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 414);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.JitterTree);
            this.Controls.Add(this.BER);
            this.Controls.Add(this.DFE);
            this.Controls.Add(this.FFE);
            this.Controls.Add(this.CTLE);
            this.Controls.Add(this.Equalization);
            this.Controls.Add(this.FIRButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "JitterAnalysis";
            this.Text = "JitterAnalysis";
            this.Load += new System.EventHandler(this.JitterAnalysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button FIRButton;
        private System.Windows.Forms.Button Equalization;
        private System.Windows.Forms.Button CTLE;
        private System.Windows.Forms.Button FFE;
        private System.Windows.Forms.Button DFE;
        private System.Windows.Forms.Button BER;
        private System.Windows.Forms.TreeView JitterTree;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}