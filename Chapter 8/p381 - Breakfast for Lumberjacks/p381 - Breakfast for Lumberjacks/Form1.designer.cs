namespace p381___Breakfast_for_Lumberjacks
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components;

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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addLumberjack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextLumberjack = new System.Windows.Forms.Button();
            this.nextInLine = new System.Windows.Forms.Label();
            this.addFlapjacks = new System.Windows.Forms.Button();
            this.banana = new System.Windows.Forms.RadioButton();
            this.browned = new System.Windows.Forms.RadioButton();
            this.soggy = new System.Windows.Forms.RadioButton();
            this.crispy = new System.Windows.Forms.RadioButton();
            this.howMany = new System.Windows.Forms.NumericUpDown();
            this.line = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(109, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lumberjack name";
            // 
            // addLumberjack
            // 
            this.addLumberjack.Location = new System.Drawing.Point(12, 38);
            this.addLumberjack.Name = "addLumberjack";
            this.addLumberjack.Size = new System.Drawing.Size(197, 23);
            this.addLumberjack.TabIndex = 3;
            this.addLumberjack.Text = "Add lumberjack";
            this.addLumberjack.UseVisualStyleBackColor = true;
            this.addLumberjack.Click += new System.EventHandler(this.addLumberjack_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Breakfast line";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nextLumberjack);
            this.groupBox1.Controls.Add(this.nextInLine);
            this.groupBox1.Controls.Add(this.addFlapjacks);
            this.groupBox1.Controls.Add(this.banana);
            this.groupBox1.Controls.Add(this.browned);
            this.groupBox1.Controls.Add(this.soggy);
            this.groupBox1.Controls.Add(this.crispy);
            this.groupBox1.Controls.Add(this.howMany);
            this.groupBox1.Location = new System.Drawing.Point(109, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 262);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feed a Lumberjack";
            // 
            // nextLumberjack
            // 
            this.nextLumberjack.Location = new System.Drawing.Point(6, 233);
            this.nextLumberjack.Name = "nextLumberjack";
            this.nextLumberjack.Size = new System.Drawing.Size(121, 23);
            this.nextLumberjack.TabIndex = 7;
            this.nextLumberjack.Text = "Next lumberjack";
            this.nextLumberjack.UseVisualStyleBackColor = true;
            this.nextLumberjack.Click += new System.EventHandler(this.nextLumberjack_Click);
            // 
            // nextInLine
            // 
            this.nextInLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.nextInLine.Location = new System.Drawing.Point(6, 163);
            this.nextInLine.Name = "nextInLine";
            this.nextInLine.Size = new System.Drawing.Size(121, 43);
            this.nextInLine.TabIndex = 6;
            // 
            // addFlapjacks
            // 
            this.addFlapjacks.Location = new System.Drawing.Point(6, 137);
            this.addFlapjacks.Name = "addFlapjacks";
            this.addFlapjacks.Size = new System.Drawing.Size(121, 23);
            this.addFlapjacks.TabIndex = 5;
            this.addFlapjacks.Text = "Add flapjacks";
            this.addFlapjacks.UseVisualStyleBackColor = true;
            this.addFlapjacks.Click += new System.EventHandler(this.addFlapjacks_Click);
            // 
            // banana
            // 
            this.banana.AutoSize = true;
            this.banana.Location = new System.Drawing.Point(7, 114);
            this.banana.Name = "banana";
            this.banana.Size = new System.Drawing.Size(62, 17);
            this.banana.TabIndex = 4;
            this.banana.TabStop = true;
            this.banana.Text = "Banana";
            this.banana.UseVisualStyleBackColor = true;
            // 
            // browned
            // 
            this.browned.AutoSize = true;
            this.browned.Location = new System.Drawing.Point(7, 91);
            this.browned.Name = "browned";
            this.browned.Size = new System.Drawing.Size(67, 17);
            this.browned.TabIndex = 3;
            this.browned.TabStop = true;
            this.browned.Text = "Browned";
            this.browned.UseVisualStyleBackColor = true;
            // 
            // soggy
            // 
            this.soggy.AutoSize = true;
            this.soggy.Location = new System.Drawing.Point(6, 68);
            this.soggy.Name = "soggy";
            this.soggy.Size = new System.Drawing.Size(55, 17);
            this.soggy.TabIndex = 2;
            this.soggy.TabStop = true;
            this.soggy.Text = "Soggy";
            this.soggy.UseVisualStyleBackColor = true;
            // 
            // crispy
            // 
            this.crispy.AutoSize = true;
            this.crispy.Location = new System.Drawing.Point(7, 45);
            this.crispy.Name = "crispy";
            this.crispy.Size = new System.Drawing.Size(53, 17);
            this.crispy.TabIndex = 1;
            this.crispy.TabStop = true;
            this.crispy.Text = "Crispy";
            this.crispy.UseVisualStyleBackColor = true;
            // 
            // howMany
            // 
            this.howMany.Location = new System.Drawing.Point(7, 19);
            this.howMany.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.howMany.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.howMany.Name = "howMany";
            this.howMany.Size = new System.Drawing.Size(67, 20);
            this.howMany.TabIndex = 0;
            this.howMany.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // line
            // 
            this.line.FormattingEnabled = true;
            this.line.Location = new System.Drawing.Point(12, 100);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(91, 225);
            this.line.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 341);
            this.Controls.Add(this.line);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLumberjack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Breakfast for Lumberjacks";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addLumberjack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown howMany;
        private System.Windows.Forms.RadioButton banana;
        private System.Windows.Forms.RadioButton browned;
        private System.Windows.Forms.RadioButton soggy;
        private System.Windows.Forms.RadioButton crispy;
        private System.Windows.Forms.Button addFlapjacks;
        private System.Windows.Forms.Label nextInLine;
        private System.Windows.Forms.Button nextLumberjack;
        private System.Windows.Forms.ListBox line;
    }
}

