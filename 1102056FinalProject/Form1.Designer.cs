namespace _1102056FinalProject
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.text_time = new System.Windows.Forms.TextBox();
            this.picbox_com = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_com)).BeginInit();
            this.SuspendLayout();
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Transparent;
            this.btn3.BackgroundImage = global::_1102056FinalProject.Properties.Resources.S__11124741;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.Location = new System.Drawing.Point(456, 232);
            this.btn3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(124, 126);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Transparent;
            this.btn2.BackgroundImage = global::_1102056FinalProject.Properties.Resources.S__11124739;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.Location = new System.Drawing.Point(288, 232);
            this.btn2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(124, 126);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.BackgroundImage = global::_1102056FinalProject.Properties.Resources.S__11124742;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.Location = new System.Drawing.Point(123, 232);
            this.btn1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(124, 126);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // text_time
            // 
            this.text_time.BackColor = System.Drawing.SystemColors.Info;
            this.text_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.text_time.Location = new System.Drawing.Point(160, 22);
            this.text_time.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.text_time.Name = "text_time";
            this.text_time.Size = new System.Drawing.Size(373, 27);
            this.text_time.TabIndex = 4;
            this.text_time.Text = "記錄";
            this.text_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picbox_com
            // 
            this.picbox_com.BackColor = System.Drawing.Color.Transparent;
            this.picbox_com.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbox_com.Location = new System.Drawing.Point(282, 82);
            this.picbox_com.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.picbox_com.Name = "picbox_com";
            this.picbox_com.Size = new System.Drawing.Size(130, 130);
            this.picbox_com.TabIndex = 5;
            this.picbox_com.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "S__11124745.jpg");
            this.imageList1.Images.SetKeyName(1, "S__11124742.jpg");
            this.imageList1.Images.SetKeyName(2, "S__11124739.jpg");
            this.imageList1.Images.SetKeyName(3, "S__11124741.jpg");
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(614, 357);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(85, 31);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "不玩了";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 357);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(85, 31);
            this.btn_new.TabIndex = 7;
            this.btn_new.Text = "重新計算";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 400);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.picbox_com);
            this.Controls.Add(this.text_time);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Font = new System.Drawing.Font("細明體", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "剪刀石頭布";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_com)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox text_time;
        private System.Windows.Forms.PictureBox picbox_com;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_new;
    }
}

