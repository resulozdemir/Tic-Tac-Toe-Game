
namespace XOX_oyunu
{
    partial class XOX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XOX));
            this.topLeft = new System.Windows.Forms.Button();
            this.topMiddle = new System.Windows.Forms.Button();
            this.topRight = new System.Windows.Forms.Button();
            this.leftMiddle = new System.Windows.Forms.Button();
            this.middle = new System.Windows.Forms.Button();
            this.middleRight = new System.Windows.Forms.Button();
            this.buttomLeft = new System.Windows.Forms.Button();
            this.buttomMiddle = new System.Windows.Forms.Button();
            this.buttomRight = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.yenidenOyna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topLeft
            // 
            resources.ApplyResources(this.topLeft, "topLeft");
            this.topLeft.Name = "topLeft";
            this.topLeft.UseVisualStyleBackColor = true;
            this.topLeft.Click += new System.EventHandler(this.button1_Click);
            // 
            // topMiddle
            // 
            resources.ApplyResources(this.topMiddle, "topMiddle");
            this.topMiddle.Name = "topMiddle";
            this.topMiddle.UseVisualStyleBackColor = true;
            this.topMiddle.Click += new System.EventHandler(this.topMiddle_Click);
            // 
            // topRight
            // 
            resources.ApplyResources(this.topRight, "topRight");
            this.topRight.Name = "topRight";
            this.topRight.UseVisualStyleBackColor = true;
            this.topRight.Click += new System.EventHandler(this.topRight_Click);
            // 
            // leftMiddle
            // 
            resources.ApplyResources(this.leftMiddle, "leftMiddle");
            this.leftMiddle.Name = "leftMiddle";
            this.leftMiddle.UseVisualStyleBackColor = true;
            this.leftMiddle.Click += new System.EventHandler(this.leftMiddle_Click);
            // 
            // middle
            // 
            resources.ApplyResources(this.middle, "middle");
            this.middle.Name = "middle";
            this.middle.UseVisualStyleBackColor = true;
            this.middle.Click += new System.EventHandler(this.middle_Click);
            // 
            // middleRight
            // 
            resources.ApplyResources(this.middleRight, "middleRight");
            this.middleRight.Name = "middleRight";
            this.middleRight.UseVisualStyleBackColor = true;
            this.middleRight.Click += new System.EventHandler(this.middleRight_Click);
            // 
            // buttomLeft
            // 
            resources.ApplyResources(this.buttomLeft, "buttomLeft");
            this.buttomLeft.Name = "buttomLeft";
            this.buttomLeft.UseVisualStyleBackColor = true;
            this.buttomLeft.Click += new System.EventHandler(this.buttomLeft_Click);
            // 
            // buttomMiddle
            // 
            this.buttomMiddle.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.buttomMiddle, "buttomMiddle");
            this.buttomMiddle.Name = "buttomMiddle";
            this.buttomMiddle.UseVisualStyleBackColor = false;
            this.buttomMiddle.Click += new System.EventHandler(this.buttomMiddle_Click);
            // 
            // buttomRight
            // 
            this.buttomRight.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.buttomRight, "buttomRight");
            this.buttomRight.Name = "buttomRight";
            this.buttomRight.UseVisualStyleBackColor = true;
            this.buttomRight.Click += new System.EventHandler(this.buttomRight_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Name = "label1";
            // 
            // yenidenOyna
            // 
            resources.ApplyResources(this.yenidenOyna, "yenidenOyna");
            this.yenidenOyna.Name = "yenidenOyna";
            this.yenidenOyna.UseVisualStyleBackColor = true;
            this.yenidenOyna.Click += new System.EventHandler(this.yenidenOyna_Click);
            // 
            // XOX
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.yenidenOyna);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttomRight);
            this.Controls.Add(this.buttomMiddle);
            this.Controls.Add(this.buttomLeft);
            this.Controls.Add(this.middleRight);
            this.Controls.Add(this.middle);
            this.Controls.Add(this.leftMiddle);
            this.Controls.Add(this.topRight);
            this.Controls.Add(this.topMiddle);
            this.Controls.Add(this.topLeft);
            this.MaximizeBox = false;
            this.Name = "XOX";
            this.Load += new System.EventHandler(this.XOX_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topLeft;
        private System.Windows.Forms.Button topMiddle;
        private System.Windows.Forms.Button topRight;
        private System.Windows.Forms.Button leftMiddle;
        private System.Windows.Forms.Button middle;
        private System.Windows.Forms.Button middleRight;
        private System.Windows.Forms.Button buttomLeft;
        private System.Windows.Forms.Button buttomMiddle;
        private System.Windows.Forms.Button buttomRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yenidenOyna;
    }
}

