namespace WF_Udvoitel
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonPlusOne = new System.Windows.Forms.Button();
            this.buttonMultiplyTwo = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.lablePlayerNumber = new System.Windows.Forms.Label();
            this.lableCountTries = new System.Windows.Forms.Label();
            this.lableInfoPlayerNumber = new System.Windows.Forms.Label();
            this.lableInfoCountTries = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.lablePlayInfo = new System.Windows.Forms.Label();
            this.labelInfoRandomNumber = new System.Windows.Forms.Label();
            this.labelRandomNumber = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPlusOne
            // 
            this.buttonPlusOne.Location = new System.Drawing.Point(713, 12);
            this.buttonPlusOne.Name = "buttonPlusOne";
            this.buttonPlusOne.Size = new System.Drawing.Size(75, 23);
            this.buttonPlusOne.TabIndex = 0;
            this.buttonPlusOne.Text = "+1";
            this.buttonPlusOne.UseVisualStyleBackColor = true;
            this.buttonPlusOne.Visible = false;
            this.buttonPlusOne.Click += new System.EventHandler(this.buttonPlusOne_Click);
            // 
            // buttonMultiplyTwo
            // 
            this.buttonMultiplyTwo.Location = new System.Drawing.Point(713, 175);
            this.buttonMultiplyTwo.Name = "buttonMultiplyTwo";
            this.buttonMultiplyTwo.Size = new System.Drawing.Size(75, 23);
            this.buttonMultiplyTwo.TabIndex = 1;
            this.buttonMultiplyTwo.Text = "*2";
            this.buttonMultiplyTwo.UseVisualStyleBackColor = true;
            this.buttonMultiplyTwo.Visible = false;
            this.buttonMultiplyTwo.Click += new System.EventHandler(this.buttonMultiplyTwo_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(713, 333);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Сбросить";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Visible = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // lablePlayerNumber
            // 
            this.lablePlayerNumber.AutoSize = true;
            this.lablePlayerNumber.Location = new System.Drawing.Point(87, 180);
            this.lablePlayerNumber.Name = "lablePlayerNumber";
            this.lablePlayerNumber.Size = new System.Drawing.Size(13, 13);
            this.lablePlayerNumber.TabIndex = 3;
            this.lablePlayerNumber.Text = "0";
            this.lablePlayerNumber.Visible = false;
            // 
            // lableCountTries
            // 
            this.lableCountTries.AutoSize = true;
            this.lableCountTries.Location = new System.Drawing.Point(146, 338);
            this.lableCountTries.Name = "lableCountTries";
            this.lableCountTries.Size = new System.Drawing.Size(13, 13);
            this.lableCountTries.TabIndex = 4;
            this.lableCountTries.Text = "0";
            this.lableCountTries.Visible = false;
            // 
            // lableInfoPlayerNumber
            // 
            this.lableInfoPlayerNumber.AutoSize = true;
            this.lableInfoPlayerNumber.Location = new System.Drawing.Point(12, 180);
            this.lableInfoPlayerNumber.Name = "lableInfoPlayerNumber";
            this.lableInfoPlayerNumber.Size = new System.Drawing.Size(69, 13);
            this.lableInfoPlayerNumber.TabIndex = 5;
            this.lableInfoPlayerNumber.Text = "Ваше число:";
            this.lableInfoPlayerNumber.Visible = false;
            // 
            // lableInfoCountTries
            // 
            this.lableInfoCountTries.AutoSize = true;
            this.lableInfoCountTries.Location = new System.Drawing.Point(12, 338);
            this.lableInfoCountTries.Name = "lableInfoCountTries";
            this.lableInfoCountTries.Size = new System.Drawing.Size(128, 13);
            this.lableInfoCountTries.TabIndex = 6;
            this.lableInfoCountTries.Text = "Кол-во ваших действий:";
            this.lableInfoCountTries.Visible = false;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(377, 202);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 7;
            this.buttonPlay.Text = "Играть";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // lablePlayInfo
            // 
            this.lablePlayInfo.AutoSize = true;
            this.lablePlayInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lablePlayInfo.Location = new System.Drawing.Point(134, 249);
            this.lablePlayInfo.Name = "lablePlayInfo";
            this.lablePlayInfo.Size = new System.Drawing.Size(565, 24);
            this.lablePlayInfo.TabIndex = 8;
            this.lablePlayInfo.Text = "Получите заданное число за минимальное количество ходов";
            // 
            // labelInfoRandomNumber
            // 
            this.labelInfoRandomNumber.AutoSize = true;
            this.labelInfoRandomNumber.Location = new System.Drawing.Point(9, 17);
            this.labelInfoRandomNumber.Name = "labelInfoRandomNumber";
            this.labelInfoRandomNumber.Size = new System.Drawing.Size(91, 13);
            this.labelInfoRandomNumber.TabIndex = 9;
            this.labelInfoRandomNumber.Text = "Заданное число:";
            this.labelInfoRandomNumber.Visible = false;
            // 
            // labelRandomNumber
            // 
            this.labelRandomNumber.AutoSize = true;
            this.labelRandomNumber.Location = new System.Drawing.Point(109, 17);
            this.labelRandomNumber.Name = "labelRandomNumber";
            this.labelRandomNumber.Size = new System.Drawing.Size(13, 13);
            this.labelRandomNumber.TabIndex = 10;
            this.labelRandomNumber.Text = "0";
            this.labelRandomNumber.Visible = false;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(377, 380);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTask.Location = new System.Drawing.Point(18, 9);
            this.labelTask.MaximumSize = new System.Drawing.Size(770, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(770, 126);
            this.labelTask.TabIndex = 12;
            this.labelTask.Text = resources.GetString("labelTask.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelRandomNumber);
            this.Controls.Add(this.labelInfoRandomNumber);
            this.Controls.Add(this.lablePlayInfo);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.lableInfoCountTries);
            this.Controls.Add(this.lableInfoPlayerNumber);
            this.Controls.Add(this.lableCountTries);
            this.Controls.Add(this.lablePlayerNumber);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonMultiplyTwo);
            this.Controls.Add(this.buttonPlusOne);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPlusOne;
        private System.Windows.Forms.Button buttonMultiplyTwo;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label lablePlayerNumber;
        private System.Windows.Forms.Label lableCountTries;
        private System.Windows.Forms.Label lableInfoPlayerNumber;
        private System.Windows.Forms.Label lableInfoCountTries;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label lablePlayInfo;
        private System.Windows.Forms.Label labelInfoRandomNumber;
        private System.Windows.Forms.Label labelRandomNumber;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTask;
    }
}