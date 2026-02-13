
namespace HW_PuzzleGame
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
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.lableInfoPlay = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.lableInfoGame = new System.Windows.Forms.Label();
            this.labelInfoCountTries = new System.Windows.Forms.Label();
            this.lableCountTries = new System.Windows.Forms.Label();
            this.labelTask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Location = new System.Drawing.Point(348, 270);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(66, 23);
            this.buttonStartGame.TabIndex = 0;
            this.buttonStartGame.Text = "Начать";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // lableInfoPlay
            // 
            this.lableInfoPlay.AutoSize = true;
            this.lableInfoPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lableInfoPlay.Location = new System.Drawing.Point(210, 336);
            this.lableInfoPlay.Name = "lableInfoPlay";
            this.lableInfoPlay.Size = new System.Drawing.Size(355, 15);
            this.lableInfoPlay.TabIndex = 1;
            this.lableInfoPlay.Text = "Угадайте число от 0 до 100 за минимальное число попыток";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(162, 270);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(474, 20);
            this.textBoxAnswer.TabIndex = 2;
            this.textBoxAnswer.Text = "Введите число в это поле";
            this.textBoxAnswer.Visible = false;
            this.textBoxAnswer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAnswer_KeyPress);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(642, 267);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(75, 23);
            this.buttonEnter.TabIndex = 3;
            this.buttonEnter.Text = "Ввод";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Visible = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // lableInfoGame
            // 
            this.lableInfoGame.AutoSize = true;
            this.lableInfoGame.Location = new System.Drawing.Point(159, 220);
            this.lableInfoGame.Name = "lableInfoGame";
            this.lableInfoGame.Size = new System.Drawing.Size(140, 13);
            this.lableInfoGame.TabIndex = 4;
            this.lableInfoGame.Text = "Введите число от 0 до 100";
            this.lableInfoGame.Visible = false;
            // 
            // labelInfoCountTries
            // 
            this.labelInfoCountTries.AutoSize = true;
            this.labelInfoCountTries.Location = new System.Drawing.Point(159, 325);
            this.labelInfoCountTries.Name = "labelInfoCountTries";
            this.labelInfoCountTries.Size = new System.Drawing.Size(76, 13);
            this.labelInfoCountTries.TabIndex = 5;
            this.labelInfoCountTries.Text = "Колв-о ходов:";
            this.labelInfoCountTries.Visible = false;
            // 
            // lableCountTries
            // 
            this.lableCountTries.AutoSize = true;
            this.lableCountTries.Location = new System.Drawing.Point(241, 325);
            this.lableCountTries.Name = "lableCountTries";
            this.lableCountTries.Size = new System.Drawing.Size(13, 13);
            this.lableCountTries.TabIndex = 6;
            this.lableCountTries.Text = "0";
            this.lableCountTries.Visible = false;
            // 
            // labelTask
            // 
            this.labelTask.AutoSize = true;
            this.labelTask.Location = new System.Drawing.Point(9, 9);
            this.labelTask.Margin = new System.Windows.Forms.Padding(0);
            this.labelTask.MaximumSize = new System.Drawing.Size(770, 0);
            this.labelTask.Name = "labelTask";
            this.labelTask.Size = new System.Drawing.Size(767, 104);
            this.labelTask.TabIndex = 7;
            this.labelTask.Text = resources.GetString("labelTask.Text");
            this.labelTask.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTask);
            this.Controls.Add(this.lableCountTries);
            this.Controls.Add(this.labelInfoCountTries);
            this.Controls.Add(this.lableInfoGame);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.lableInfoPlay);
            this.Controls.Add(this.buttonStartGame);
            this.Name = "Form1";
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartGame;
        private System.Windows.Forms.Label lableInfoPlay;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label lableInfoGame;
        private System.Windows.Forms.Label labelInfoCountTries;
        private System.Windows.Forms.Label lableCountTries;
        private System.Windows.Forms.Label labelTask;
    }
}

