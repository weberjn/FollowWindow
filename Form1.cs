using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FollowWindow
{
    public partial class Form1 : Form
    {

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labelPos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "labelHello";
            // 
            // labelPos
            // 
            this.labelPos.AutoSize = true;
            this.labelPos.Location = new System.Drawing.Point(77, 173);
            this.labelPos.Name = "labelPos";
            this.labelPos.Size = new System.Drawing.Size(35, 13);
            this.labelPos.TabIndex = 1;
            this.labelPos.Text = "label2";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 260);
            this.Controls.Add(this.labelPos);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
