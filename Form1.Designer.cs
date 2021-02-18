
namespace Run__button__RUN__
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonYes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Question = new MaterialSkin.Controls.MaterialLabel();
            this.ButtonNo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.SuspendLayout();
            // 
            // ButtonYes
            // 
            this.ButtonYes.Depth = 0;
            this.ButtonYes.Location = new System.Drawing.Point(559, 302);
            this.ButtonYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonYes.Name = "ButtonYes";
            this.ButtonYes.Primary = true;
            this.ButtonYes.Size = new System.Drawing.Size(87, 24);
            this.ButtonYes.TabIndex = 2;
            this.ButtonYes.Text = "Да";
            this.ButtonYes.UseVisualStyleBackColor = true;
            this.ButtonYes.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Question
            // 
            this.Question.AutoSize = true;
            this.Question.Depth = 0;
            this.Question.Font = new System.Drawing.Font("Roboto", 11F);
            this.Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Question.Location = new System.Drawing.Point(354, 118);
            this.Question.MouseState = MaterialSkin.MouseState.HOVER;
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(84, 19);
            this.Question.TabIndex = 4;
            this.Question.Text = "Ты педик?";
            // 
            // ButtonNo
            // 
            this.ButtonNo.Depth = 0;
            this.ButtonNo.Location = new System.Drawing.Point(190, 302);
            this.ButtonNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonNo.Name = "ButtonNo";
            this.ButtonNo.Primary = true;
            this.ButtonNo.Size = new System.Drawing.Size(87, 24);
            this.ButtonNo.TabIndex = 2;
            this.ButtonNo.Text = "Нет";
            this.ButtonNo.UseVisualStyleBackColor = true;
            this.ButtonNo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.materialRaisedButton2_MouseMove);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 444);
            this.Controls.Add(this.Question);
            this.Controls.Add(this.ButtonNo);
            this.Controls.Add(this.ButtonYes);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Проверка ориентации";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton ButtonYes;
        private MaterialSkin.Controls.MaterialLabel Question;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonNo;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
    }
}

