namespace calculator
{
    partial class Form1
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
            btn1=new Button();
            btn2=new Button();
            btn3=new Button();
            btn4=new Button();
            btn5=new Button();
            btn6=new Button();
            btn7=new Button();
            btn8=new Button();
            btn9=new Button();
            btn0=new Button();
            btnplus=new Button();
            btnminus=new Button();
            btnmul=new Button();
            btndivide=new Button();
            btnclr=new Button();
            btnequal=new Button();
            txtTotal=new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location=new Point(29, 93);
            btn1.Name="btn1";
            btn1.Size=new Size(94, 69);
            btn1.TabIndex=1;
            btn1.Text="1";
            btn1.UseVisualStyleBackColor=true;
            btn1.Click+=button1_Click;
            // 
            // btn2
            // 
            btn2.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location=new Point(156, 93);
            btn2.Name="btn2";
            btn2.Size=new Size(94, 69);
            btn2.TabIndex=2;
            btn2.Text="2";
            btn2.UseVisualStyleBackColor=true;
            btn2.Click+=btn2_Click;
            // 
            // btn3
            // 
            btn3.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location=new Point(292, 94);
            btn3.Name="btn3";
            btn3.Size=new Size(94, 69);
            btn3.TabIndex=3;
            btn3.Text="3";
            btn3.UseVisualStyleBackColor=true;
            btn3.Click+=btn3_Click;
            // 
            // btn4
            // 
            btn4.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location=new Point(439, 93);
            btn4.Name="btn4";
            btn4.Size=new Size(94, 69);
            btn4.TabIndex=4;
            btn4.Text="4";
            btn4.UseVisualStyleBackColor=true;
            btn4.Click+=btn4_Click;
            // 
            // btn5
            // 
            btn5.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location=new Point(581, 93);
            btn5.Name="btn5";
            btn5.Size=new Size(94, 69);
            btn5.TabIndex=5;
            btn5.Text="5";
            btn5.UseVisualStyleBackColor=true;
            btn5.Click+=btn5_Click;
            // 
            // btn6
            // 
            btn6.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location=new Point(29, 168);
            btn6.Name="btn6";
            btn6.Size=new Size(94, 72);
            btn6.TabIndex=6;
            btn6.Text="6";
            btn6.UseVisualStyleBackColor=true;
            btn6.Click+=button6_Click;
            // 
            // btn7
            // 
            btn7.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location=new Point(156, 168);
            btn7.Name="btn7";
            btn7.Size=new Size(94, 72);
            btn7.TabIndex=7;
            btn7.Text="7";
            btn7.UseVisualStyleBackColor=true;
            btn7.Click+=button7_Click;
            // 
            // btn8
            // 
            btn8.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location=new Point(292, 169);
            btn8.Name="btn8";
            btn8.Size=new Size(94, 72);
            btn8.TabIndex=8;
            btn8.Text="8";
            btn8.UseVisualStyleBackColor=true;
            btn8.Click+=btn8_Click;
            // 
            // btn9
            // 
            btn9.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location=new Point(439, 168);
            btn9.Name="btn9";
            btn9.Size=new Size(94, 72);
            btn9.TabIndex=9;
            btn9.Text="9";
            btn9.UseVisualStyleBackColor=true;
            btn9.Click+=button9_Click;
            // 
            // btn0
            // 
            btn0.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location=new Point(581, 168);
            btn0.Name="btn0";
            btn0.Size=new Size(94, 72);
            btn0.TabIndex=10;
            btn0.Text="0";
            btn0.UseVisualStyleBackColor=true;
            btn0.Click+=btn0_Click;
            // 
            // btnplus
            // 
            btnplus.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnplus.Location=new Point(29, 246);
            btnplus.Name="btnplus";
            btnplus.Size=new Size(94, 72);
            btnplus.TabIndex=11;
            btnplus.Text="+";
            btnplus.UseVisualStyleBackColor=true;
            btnplus.Click+=btnplus_Click;
            // 
            // btnminus
            // 
            btnminus.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnminus.Location=new Point(156, 246);
            btnminus.Name="btnminus";
            btnminus.Size=new Size(94, 72);
            btnminus.TabIndex=12;
            btnminus.Text="-";
            btnminus.UseVisualStyleBackColor=true;
            btnminus.Click+=btnminus_Click;
            // 
            // btnmul
            // 
            btnmul.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnmul.Location=new Point(292, 247);
            btnmul.Name="btnmul";
            btnmul.Size=new Size(94, 71);
            btnmul.TabIndex=13;
            btnmul.Text="*";
            btnmul.UseVisualStyleBackColor=true;
            btnmul.Click+=btnmul_Click;
            // 
            // btndivide
            // 
            btndivide.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btndivide.Location=new Point(439, 246);
            btndivide.Name="btndivide";
            btndivide.Size=new Size(94, 72);
            btndivide.TabIndex=14;
            btndivide.Text="/";
            btndivide.UseVisualStyleBackColor=true;
            btndivide.Click+=btndivide_Click;
            // 
            // btnclr
            // 
            btnclr.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnclr.Location=new Point(581, 257);
            btnclr.Name="btnclr";
            btnclr.Size=new Size(94, 72);
            btnclr.TabIndex=15;
            btnclr.Text="Clear";
            btnclr.UseVisualStyleBackColor=true;
            btnclr.Click+=this.btnclr_Click;
            // 
            // btnequal
            // 
            btnequal.Font=new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnequal.Location=new Point(156, 334);
            btnequal.Name="btnequal";
            btnequal.Size=new Size(377, 73);
            btnequal.TabIndex=16;
            btnequal.Text="=";
            btnequal.UseVisualStyleBackColor=true;
            btnequal.Click+=this.btnequal_Click;
            // 
            // txtTotal
            // 
            txtTotal.Font=new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtTotal.Location=new Point(69, 12);
            txtTotal.Multiline=true;
            txtTotal.Name="txtTotal";
            txtTotal.Size=new Size(583, 75);
            txtTotal.TabIndex=17;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(8F, 20F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(txtTotal);
            Controls.Add(btnequal);
            Controls.Add(btnclr);
            Controls.Add(btndivide);
            Controls.Add(btnmul);
            Controls.Add(btnminus);
            Controls.Add(btnplus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name="Form1";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

       

        #endregion
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnplus;
        private Button btnminus;
        private Button btnmul;
        private Button btndivide;
        private Button btnclr;
        private Button btnequal;
        private TextBox txtTotal;
    }
}